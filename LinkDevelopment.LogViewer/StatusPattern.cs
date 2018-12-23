using LinkDevelopment.LogViewer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkDevelopment.LogViewer
{
    public partial class StatusPattern : Form

    {
        public LogViewer MainForm { get; set; }

        public StatusPattern()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_addToList_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_patternString.Text) && (rd_fail.Checked||rd_sucecc.Checked))
            {
                var p = new StatusPatternModel
                {
                    PatternString = txt_patternString.Text,
                    Status = rd_sucecc.Checked ? StatusEnum.Sucess : StatusEnum.Fail
                };

                MainForm.addPatternToStatusList(p);
                this.Close();
            }
            else
            {
                MessageBox.Show("please fill all values.");
            }
        }
    }
}
