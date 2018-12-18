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
    public partial class LogItemView : Form
    {
        public LogItem  item { get; set; }
        public LogItemView()
        {
            InitializeComponent();
            // set text boxes 
            if (item != null) 
            {
                txt_Date.Text = item.Date.ToString();
                txt_Method.Text = item.TargetMethod;
                txt_Url.Text = item.TargetURL;
                txt_requestBody.Text = item.RequestBody;
                txt_ResponseBody.Text = item.ResponseBody; 
            }


        }

        private void LogItemView_Load(object sender, EventArgs e)
        {
            if (item != null)
            {
                txt_Date.Text = item.Date.ToString();
                txt_Method.Text = item.TargetMethod;
                txt_Url.Text = item.TargetURL;
                txt_requestBody.Text = item.RequestBody;
                txt_ResponseBody.Text = item.ResponseBody;
                txt_Time.Text = item.TakenTimeSeconds.ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
