using LinkDevelopment.LogViewer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkDevelopment.LogViewer
{
    public partial class Form1 : Form
    {
        public DataTable LogsDT { get; set; }
        public List<LogItem> LogItems { get; set; }
        public DataView filteredData { get; set; }

        public Form1()
        {
            InitializeComponent();
            //
            LogItems = new List<LogItem>();
        }

        private void loadLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    var txtFiles = Directory.EnumerateFiles(folderBrowser.SelectedPath, "*.log.txt");

                    foreach (string currentFile in txtFiles)
                    {
                        var fileLines = File.ReadAllLines(currentFile);
                        LogItems.AddRange(Utils.ParseFile(currentFile));
                    }
                    if (LogItems.Any())
                    {
                        FillGrid(LogItems);
                        FillMethodsFilter(LogItems);
                    }
                    else
                    {
                        MessageBox.Show("No Logs Found!");
                    }
                }
            }


        }

        private void FillMethodsFilter(List<LogItem> logItems)
        {
            var r = logItems.GroupBy(s => s.TargetMethod).ToList();
            r.ForEach(s => com_filterMethods.Items.Add(s.Key));
        
            //throw new NotImplementedException();
        }

        private void FillGrid(List<LogItem> _LogItems)
        {
            LogsDT = new DataTable();
            LogsDT.Columns.AddRange(new DataColumn[]{
                        new DataColumn() {
                            ColumnName = "Url",
                            ReadOnly = true
                        },
                        new DataColumn() {
                            ColumnName = "Method",
                            ReadOnly = true
                        },
                        new DataColumn()
                        {
                            ColumnName = "Date",
                            ReadOnly = true
                        },
                        new DataColumn()
                        {
                            ColumnName = "Status",
                            ReadOnly = true
                        },
                        new DataColumn()
                        {
                            ColumnName = "Time",
                            ReadOnly = true
                        },
                        new DataColumn ()
                        {
                            ColumnName = "Item",
                            DataType = typeof(LogItem),
                            ColumnMapping= MappingType.Hidden
                        }
                    });

            foreach (var item in LogItems)
            {

                var r = LogsDT.NewRow();
                r["Url"] = item.TargetURL;
                r["Date"] = item.Date;
                r["Method"] = item.TargetMethod;
                r["Time"] = item.TakenTimeSeconds;
                r["Item"] = item;
                LogsDT.Rows.Add(r);
            }
            // fill main grid
            dataGridView1.DataSource = LogsDT;
            filteredData = LogsDT.AsDataView();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lbl_logsCount.Text = dataGridView1.Rows.Count.ToString();
        }

        #region Filters
        private void FilterGrid(bool clear = false)
        {
            // cehck columns to filter 
            if (LogsDT != null)
            {
                string filter = string.Empty;
                filteredData = LogsDT.AsDataView();

                if (clear)
                {
                    filter = "";
                    textBox1.Text = "";
                    ck_FilterByDate.Checked = false;
                    //dateTimePicker1.Value = DateTime.MinValue;

                }
                else
                {
                    if (!string.IsNullOrEmpty(textBox1.Text))
                    {
                        filter = $"Url LIKE '*{textBox1.Text}*'";
                    }
                    if (ck_FilterByDate.Checked && !string.IsNullOrEmpty(dateTimePicker1.Value.ToShortDateString()))
                    {
                        filter += (string.IsNullOrEmpty(filter)) ? $"Date LIKE '*{dateTimePicker1.Value.ToShortDateString()}*'" : $" AND Date LIKE '*{dateTimePicker1.Value.ToShortDateString()}*'";
                    }
                    if (com_filterMethods.SelectedItem != null &&!string.IsNullOrEmpty(com_filterMethods.SelectedItem.ToString()))
                    {
                        filter += (string.IsNullOrEmpty(filter)) ? $"Method LIKE '*{com_filterMethods.SelectedItem.ToString()}*'" : $" AND Method LIKE '*{com_filterMethods.SelectedItem.ToString()}*'";
                    }

                }
                filteredData.RowFilter = filter;
                dataGridView1.DataSource = filteredData;
                dataGridView1.Refresh();
                lbl_logsCount.Text = dataGridView1.Rows.Count.ToString();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var toViewDatatable = LogsDT.AsDataView();
            //toViewDatatable.RowFilter = $"Url LIKE '*{textBox1.Text}*'";
            ////LogsDT.AsDataView().RowFilter = $"Url LIKE '*{textBox1.Text}*'";
            //dataGridView1.DataSource = toViewDatatable;
            //dataGridView1.Refresh();
            FilterGrid();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //var toViewDatatable = LogsDT.AsDataView();
            //toViewDatatable.RowFilter = $"Date LIKE '*{dateTimePicker1.Value.ToShortDateString()}*'";
            ////LogsDT.AsDataView().RowFilter = $"Url LIKE '*{textBox1.Text}*'";
            //dataGridView1.DataSource = toViewDatatable;
            //dataGridView1.Refresh();

            FilterGrid();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            FilterGrid(true);
        }
        private void ck_FilterByDate_CheckedChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }
        #endregion

        private void com_filterMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex>-1)
            {
                var t = ((System.Data.DataRowView)(dataGridView1.Rows[e.RowIndex].DataBoundItem)).Row["Item"] as LogItem;
                 
                LogItemView log = new LogItemView { item = t };
                log.item = t;
                log.Show();

            }

        }

        private void lbl_logsCount_Click(object sender, EventArgs e)
        {

        }
    }
}
