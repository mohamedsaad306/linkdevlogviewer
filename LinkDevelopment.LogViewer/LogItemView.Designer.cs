namespace LinkDevelopment.LogViewer
{
    partial class LogItemView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.txt_Method = new System.Windows.Forms.TextBox();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.txt_Headers = new System.Windows.Forms.TextBox();
            this.txt_requestBody = new System.Windows.Forms.TextBox();
            this.txt_ResponseBody = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TakenTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Target URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Headers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Request Body";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ResponseBody";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Method";
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(118, 26);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(195, 20);
            this.txt_Date.TabIndex = 7;
            // 
            // txt_Time
            // 
            this.txt_Time.Location = new System.Drawing.Point(319, 26);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(100, 20);
            this.txt_Time.TabIndex = 8;
            // 
            // txt_Method
            // 
            this.txt_Method.Location = new System.Drawing.Point(12, 26);
            this.txt_Method.Name = "txt_Method";
            this.txt_Method.Size = new System.Drawing.Size(100, 20);
            this.txt_Method.TabIndex = 9;
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(12, 76);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(407, 20);
            this.txt_Url.TabIndex = 10;
            // 
            // txt_Headers
            // 
            this.txt_Headers.Location = new System.Drawing.Point(12, 124);
            this.txt_Headers.Multiline = true;
            this.txt_Headers.Name = "txt_Headers";
            this.txt_Headers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Headers.Size = new System.Drawing.Size(627, 101);
            this.txt_Headers.TabIndex = 11;
            // 
            // txt_requestBody
            // 
            this.txt_requestBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_requestBody.Location = new System.Drawing.Point(12, 255);
            this.txt_requestBody.Multiline = true;
            this.txt_requestBody.Name = "txt_requestBody";
            this.txt_requestBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_requestBody.Size = new System.Drawing.Size(627, 123);
            this.txt_requestBody.TabIndex = 12;
            // 
            // txt_ResponseBody
            // 
            this.txt_ResponseBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ResponseBody.Location = new System.Drawing.Point(12, 407);
            this.txt_ResponseBody.Multiline = true;
            this.txt_ResponseBody.Name = "txt_ResponseBody";
            this.txt_ResponseBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ResponseBody.Size = new System.Drawing.Size(627, 177);
            this.txt_ResponseBody.TabIndex = 13;
            this.txt_ResponseBody.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // LogItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 605);
            this.Controls.Add(this.txt_ResponseBody);
            this.Controls.Add(this.txt_requestBody);
            this.Controls.Add(this.txt_Headers);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.txt_Method);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogItemView";
            this.Text = "LogItemView";
            this.Load += new System.EventHandler(this.LogItemView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.TextBox txt_Method;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.TextBox txt_Headers;
        private System.Windows.Forms.TextBox txt_requestBody;
        private System.Windows.Forms.TextBox txt_ResponseBody;
    }
}