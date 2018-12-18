namespace LinkDevelopment.LogViewer
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.clearFilter = new System.Windows.Forms.Button();
            this.com_filterMethods = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_logsCount = new System.Windows.Forms.Label();
            this.ck_FilterByDate = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadLogsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadLogsToolStripMenuItem
            // 
            this.loadLogsToolStripMenuItem.Name = "loadLogsToolStripMenuItem";
            this.loadLogsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.loadLogsToolStripMenuItem.Text = "Load Logs";
            this.loadLogsToolStripMenuItem.Click += new System.EventHandler(this.loadLogsToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 368);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(873, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(873, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // clearFilter
            // 
            this.clearFilter.Location = new System.Drawing.Point(792, 104);
            this.clearFilter.Name = "clearFilter";
            this.clearFilter.Size = new System.Drawing.Size(281, 23);
            this.clearFilter.TabIndex = 4;
            this.clearFilter.Text = "Clear Filter ";
            this.clearFilter.UseVisualStyleBackColor = true;
            this.clearFilter.Click += new System.EventHandler(this.clear_Click);
            // 
            // com_filterMethods
            // 
            this.com_filterMethods.FormattingEnabled = true;
            this.com_filterMethods.Location = new System.Drawing.Point(873, 187);
            this.com_filterMethods.Name = "com_filterMethods";
            this.com_filterMethods.Size = new System.Drawing.Size(200, 21);
            this.com_filterMethods.TabIndex = 5;
            this.com_filterMethods.SelectedIndexChanged += new System.EventHandler(this.com_filterMethods_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(792, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Count:";
            // 
            // lbl_logsCount
            // 
            this.lbl_logsCount.AutoSize = true;
            this.lbl_logsCount.Location = new System.Drawing.Point(837, 49);
            this.lbl_logsCount.Name = "lbl_logsCount";
            this.lbl_logsCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_logsCount.TabIndex = 7;
            this.lbl_logsCount.Text = "label2";
            // 
            // ck_FilterByDate
            // 
            this.ck_FilterByDate.AutoSize = true;
            this.ck_FilterByDate.Location = new System.Drawing.Point(1053, 161);
            this.ck_FilterByDate.Name = "ck_FilterByDate";
            this.ck_FilterByDate.Size = new System.Drawing.Size(15, 14);
            this.ck_FilterByDate.TabIndex = 8;
            this.ck_FilterByDate.UseVisualStyleBackColor = true;
            this.ck_FilterByDate.CheckedChanged += new System.EventHandler(this.ck_FilterByDate_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 453);
            this.Controls.Add(this.ck_FilterByDate);
            this.Controls.Add(this.lbl_logsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com_filterMethods);
            this.Controls.Add(this.clearFilter);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadLogsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button clearFilter;
        private System.Windows.Forms.ComboBox com_filterMethods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_logsCount;
        private System.Windows.Forms.CheckBox ck_FilterByDate;
    }
}

