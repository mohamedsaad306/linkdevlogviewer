namespace LinkDevelopment.LogViewer
{
    partial class StatusPattern
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
            this.btn_addToList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_patternString = new System.Windows.Forms.TextBox();
            this.rd_sucecc = new System.Windows.Forms.RadioButton();
            this.rd_fail = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_addToList
            // 
            this.btn_addToList.Location = new System.Drawing.Point(271, 63);
            this.btn_addToList.Name = "btn_addToList";
            this.btn_addToList.Size = new System.Drawing.Size(75, 23);
            this.btn_addToList.TabIndex = 0;
            this.btn_addToList.Text = "Add ";
            this.btn_addToList.UseVisualStyleBackColor = true;
            this.btn_addToList.Click += new System.EventHandler(this.btn_addToList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pattern";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_patternString
            // 
            this.txt_patternString.Location = new System.Drawing.Point(15, 37);
            this.txt_patternString.Name = "txt_patternString";
            this.txt_patternString.Size = new System.Drawing.Size(331, 20);
            this.txt_patternString.TabIndex = 2;
            // 
            // rd_sucecc
            // 
            this.rd_sucecc.AutoSize = true;
            this.rd_sucecc.Location = new System.Drawing.Point(15, 66);
            this.rd_sucecc.Name = "rd_sucecc";
            this.rd_sucecc.Size = new System.Drawing.Size(66, 17);
            this.rd_sucecc.TabIndex = 3;
            this.rd_sucecc.TabStop = true;
            this.rd_sucecc.Text = "Success";
            this.rd_sucecc.UseVisualStyleBackColor = true;
            // 
            // rd_fail
            // 
            this.rd_fail.AutoSize = true;
            this.rd_fail.Location = new System.Drawing.Point(121, 66);
            this.rd_fail.Name = "rd_fail";
            this.rd_fail.Size = new System.Drawing.Size(56, 17);
            this.rd_fail.TabIndex = 4;
            this.rd_fail.TabStop = true;
            this.rd_fail.Text = "Failure";
            this.rd_fail.UseVisualStyleBackColor = true;
            // 
            // StatusPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 104);
            this.Controls.Add(this.rd_fail);
            this.Controls.Add(this.rd_sucecc);
            this.Controls.Add(this.txt_patternString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addToList);
            this.Name = "StatusPattern";
            this.Text = "StatusPattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addToList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_patternString;
        private System.Windows.Forms.RadioButton rd_sucecc;
        private System.Windows.Forms.RadioButton rd_fail;
    }
}