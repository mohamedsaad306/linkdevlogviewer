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
        public Form1()
        {
            InitializeComponent();
        }

        private void loadLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowser.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    var txtFiles = Directory.EnumerateFiles(folderBrowser.SelectedPath, "*.log.txt");

                    DataTable dt = new DataTable();
                    var dtColumn = new DataColumn();
                    dtColumn.ColumnName = "content";
                    dtColumn.Caption = "content";
                    dtColumn.ReadOnly = false;
                 
                    // Add id column to the DataColumnCollection.

                    dt.Columns.Add(dtColumn);

                    foreach (string currentFile in txtFiles)
                    {
                        var fileLines = File.ReadAllLines(currentFile);
                        var logItems = Utils.ParseFile(currentFile);

                        foreach (var item in logItems)
                        {
                            var r = dt.NewRow();
                           // r.Table.Columns.Add("Method");
                            //r["Method"] = item.TargetURL;
                            
                            dataGridView1.Rows.Add(item.TargetURL,item.TargetMethod,item.Date,item.Status);
                        }
                        //foreach (var line in fileLines)
                        //{
                        //    var r = dt.NewRow();
                        //    dt.Rows.Add(r["Method"] = line);
                        //}
                    }
                  //  dataGridView1.DataSource = dt;
                   // dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    MessageBox.Show($"{txtFiles.Count()} found ");
                }
            }


        }
    }
}
