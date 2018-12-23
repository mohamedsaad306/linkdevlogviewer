using LinkDevelopment.LogViewer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkDevelopment.LogViewer
{
    public partial class LogViewer : Form
    {
        public DataTable LogsDT { get; set; }
        public List<LogItem> LogItems { get; set; }
        public DataView filteredData { get; set; }

        public List<StatusPatternModel> StatusPatterns { get; set; }
        public LogViewer()
        {
            InitializeComponent();
            //
            LogItems = new List<LogItem>();
            StatusPatterns = new List<StatusPatternModel>();
        }



        private void FillMethodsComboBoxFilter(List<LogItem> logItems)
        {
            var r = logItems.GroupBy(s => s.TargetMethod).ToList();
            r.ForEach(s => com_filterMethods.Items.Add(s.Key));
            //throw new NotImplementedException();
        }

        private void FillLogsGrid(List<LogItem> _LogItems)
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
                            ReadOnly = false
                        },
                        new DataColumn()
                        {
                            ColumnName = "Time",
                            ReadOnly = true
                        },
                        new DataColumn()
                        {
                            ColumnName = "Headers",
                            ReadOnly = false,
                            ColumnMapping= MappingType.Hidden
                        },
                        new DataColumn()
                        {
                            ColumnName = "RequestBody",
                            ReadOnly = false,
                            ColumnMapping= MappingType.Hidden
                        },
                        new DataColumn()
                        {
                            ColumnName = "ResponseBody",
                            ReadOnly = false,
                            ColumnMapping= MappingType.Hidden
                        },
                        new DataColumn ()
                        {
                            ColumnName = "Item",
                            DataType = typeof(LogItem),
                            ColumnMapping= MappingType.Hidden,
                              ReadOnly = false,
                        }
                    });

            foreach (var item in LogItems)
            {

                var r = LogsDT.NewRow();
                r["Url"] = item.TargetURL;
                r["Date"] = item.Date;
                r["Method"] = item.TargetMethod;
                r["Time"] = item.TakenTimeSeconds;
                //hidden 
                r["Headers"] = item.RequestHeaders;
                r["RequestBody"] = item.RequestBody;
                r["ResponseBody"] = item.ResponseBody;

                r["Item"] = item;
                LogsDT.Rows.Add(r);
            }
            // fill main grid
            dataGridView1.DataSource = LogsDT;
            filteredData = LogsDT.AsDataView();
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lbl_logsCount.Text = dataGridView1.Rows.Count.ToString();
        }

        public void addPatternToStatusList(StatusPatternModel pattern)
        {
            if (!StatusPatterns.Where(p => p.PatternString == pattern.PatternString).Any())
            {
                StatusPatterns.Add(pattern);
                lst_statusPatterns.Items.Add(pattern.PatternString);
            }
            else
            {
                MessageBox.Show("This Pattern Already Exist.");
            }
        }

        #region Filters
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
                        FillLogsGrid(LogItems);
                        FillMethodsComboBoxFilter(LogItems);
                    }
                    else
                    {
                        MessageBox.Show("No Logs Found!");
                    }
                }
            }


        }
        private void FilterGrid(bool clear = false)
        {
            // cehck columns to filter 
            if (LogsDT != null)
            {
                string filter = string.Empty;
                filteredData = LogsDT.AsDataView();

                if (clear)
                {
                    filter = string.Empty;
                    textBox1.Text = string.Empty;
                    ck_applyDateFilter.Checked = false;
                    com_filterMethods.SelectedIndex = -1;
                    txt_headerFilter.Text = string.Empty;
                    txt_requestBodyFilter.Text = string.Empty;
                    txt_responseBodyFilter.Text = string.Empty;
                    //dateTimePicker1.Value = DateTime.MinValue;

                }
                else
                {
                    filter = buildFilter();

                }
                try
                {
                    filteredData.RowFilter = filter;
                    dataGridView1.DataSource = filteredData;
                    dataGridView1.Refresh();
                    txt_filter.Text = filter;
                    lbl_logsCount.Text = dataGridView1.Rows.Count.ToString();
                }
                catch (EvaluateException e)
                {
                    filter = Utils.EscapeLikeValue(filter);
                    filteredData.RowFilter = filter;
                    dataGridView1.DataSource = filteredData;
                    dataGridView1.Refresh();
                    txt_filter.Text = filter;
                    lbl_logsCount.Text = dataGridView1.Rows.Count.ToString();
                }
            }
        }

        private string buildFilter()
        {
            string filter = string.Empty;
            // URL 
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                filter = $"Url LIKE '*{textBox1.Text}*'";
            }
            // Date 
            if (ck_applyDateFilter.Checked && !string.IsNullOrEmpty(dateTimePicker1.Value.ToShortDateString()))
            {
                if (!string.IsNullOrEmpty(filter))
                    filter += "AND ";
                filter += $"Date LIKE '*{dateTimePicker1.Value.ToShortDateString()}*'";
            }
            // Method 
            if (com_filterMethods.SelectedItem != null && com_filterMethods.SelectedItem.ToString() != "All")
            {
                if (!string.IsNullOrEmpty(filter))
                    filter += "AND ";
                filter += $"Method LIKE '*{com_filterMethods.SelectedItem.ToString()}*'";
            }
            // response  Body 
            if (!string.IsNullOrEmpty(txt_headerFilter.Text))
            {
                if (!string.IsNullOrEmpty(filter))
                    filter += "AND ";
                filter += $"Headers LIKE '*{txt_headerFilter.Text}*'";
            }
            // request Body 
            if (!string.IsNullOrEmpty(txt_requestBodyFilter.Text))
            {
                if (!string.IsNullOrEmpty(filter))
                    filter += "AND ";
                filter += $"RequestBody LIKE '*{txt_requestBodyFilter.Text}*'";
            }
            // response  Body 
            if (!string.IsNullOrEmpty(txt_responseBodyFilter.Text))
            {
                if (!string.IsNullOrEmpty(filter))
                    filter += "AND ";
                filter += $"ResponseBody LIKE '*{Utils.EscapeLikeValue(txt_responseBodyFilter.Text)}*'";
            }

            return filter;
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

        #region Events 
        private void com_filterMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_responseBodyFilter_TextChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void txt_headerFilter_TextChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void txt_requestBodyFilter_TextChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void btn_addStatus_Click(object sender, EventArgs e)
        {
            StatusPattern newForm = new LinkDevelopment.LogViewer.StatusPattern();
            newForm.MainForm = this;
            newForm.Show();
        }
        private void btn_removeStatus_Click(object sender, EventArgs e)
        {
            var statusPatternToRemove = lst_statusPatterns.SelectedItem;
            if (statusPatternToRemove != null)
            {
                lst_statusPatterns.Items.Remove(statusPatternToRemove);
                StatusPatterns.Remove(StatusPatterns.Where(p => p.PatternString == (String)statusPatternToRemove).First());
            }
        }

        private void applyStatusFilterOnGrid(List<StatusPatternModel> _statuses)
        {
            if (_statuses.Any())
            {
                foreach (StatusPatternModel status in _statuses)
                {
                    // apply Filter 
                    filteredData = LogsDT.AsDataView();
                    LogsDT.Rows.Cast<DataRow>().Where(dr => dr.Field<string>("ResponseBody").Contains(status.PatternString)).ToList()
                        .ForEach(r =>
                                    {
                                        r.Field<LogItem>("Item").Status = status.Status;
                                        r["Status"] = (status.Status == StatusEnum.Fail)?"Fail":"Success";
                                    });
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells.Count>0)
                        {
                            if (row.Cells["Status"].Value == "Fail")
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                            else if (row.Cells["Status"].Value == "Success")
                            {
                                row.DefaultCellStyle.BackColor = Color.Green;
                            } 
                        }
                    }
                    //filteredData.RowFilter = $"ResponseBody LIKE '*{Utils.EscapeLikeValue(status.PatternString)}*'";
                    //   filteredData.
                  

                    //DataRowView[] foundRows = dd.FindRows()
                    //var result1 = filteredData.Cast<DataRowView>().Where(rv => rv.Row.Field<string>("ResponseBody").Contains(StatusPatterns[0].PatternString) ).ToList().ForEach();


                }
            }

        }




        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            applyStatusFilterOnGrid(StatusPatterns);
        }
    }
}
