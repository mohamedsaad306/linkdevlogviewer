namespace LinkDevelopment.LogViewer
{
    partial class LogViewer
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
            this.ck_applyDateFilter = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lst_controllers = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_removeStatus = new System.Windows.Forms.Button();
            this.lst_statusPatterns = new System.Windows.Forms.ListBox();
            this.btn_addStatus = new System.Windows.Forms.Button();
            this.txt_filter = new System.Windows.Forms.TextBox();
            this.txt_responseBodyFilter = new System.Windows.Forms.TextBox();
            this.txt_headerFilter = new System.Windows.Forms.TextBox();
            this.txt_requestBodyFilter = new System.Windows.Forms.TextBox();
            this.ck_applyMethodFilter = new System.Windows.Forms.CheckBox();
            this.ck_applyHeadersFilter = new System.Windows.Forms.CheckBox();
            this.ck_applyRequestBodyFilter = new System.Windows.Forms.CheckBox();
            this.ck_applyResponseBodyFilter = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadLogsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 24);
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
            this.dataGridView1.Size = new System.Drawing.Size(774, 475);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(873, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(873, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // clearFilter
            // 
            this.clearFilter.Location = new System.Drawing.Point(873, 66);
            this.clearFilter.Name = "clearFilter";
            this.clearFilter.Size = new System.Drawing.Size(247, 23);
            this.clearFilter.TabIndex = 4;
            this.clearFilter.Text = "Clear Filter ";
            this.clearFilter.UseVisualStyleBackColor = true;
            this.clearFilter.Click += new System.EventHandler(this.clear_Click);
            // 
            // com_filterMethods
            // 
            this.com_filterMethods.FormattingEnabled = true;
            this.com_filterMethods.Items.AddRange(new object[] {
            "All"});
            this.com_filterMethods.Location = new System.Drawing.Point(873, 148);
            this.com_filterMethods.Name = "com_filterMethods";
            this.com_filterMethods.Size = new System.Drawing.Size(252, 21);
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
            this.lbl_logsCount.Size = new System.Drawing.Size(13, 13);
            this.lbl_logsCount.TabIndex = 7;
            this.lbl_logsCount.Text = "0";
            this.lbl_logsCount.Click += new System.EventHandler(this.lbl_logsCount_Click);
            // 
            // ck_applyDateFilter
            // 
            this.ck_applyDateFilter.AutoSize = true;
            this.ck_applyDateFilter.Location = new System.Drawing.Point(1131, 127);
            this.ck_applyDateFilter.Name = "ck_applyDateFilter";
            this.ck_applyDateFilter.Size = new System.Drawing.Size(15, 14);
            this.ck_applyDateFilter.TabIndex = 8;
            this.ck_applyDateFilter.UseVisualStyleBackColor = true;
            this.ck_applyDateFilter.CheckedChanged += new System.EventHandler(this.ck_FilterByDate_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(795, 326);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(351, 198);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lst_controllers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(343, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Controllers/Svc";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lst_controllers
            // 
            this.lst_controllers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_controllers.FormattingEnabled = true;
            this.lst_controllers.Location = new System.Drawing.Point(3, 3);
            this.lst_controllers.Name = "lst_controllers";
            this.lst_controllers.Size = new System.Drawing.Size(337, 166);
            this.lst_controllers.TabIndex = 0;
            this.lst_controllers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_removeStatus);
            this.tabPage2.Controls.Add(this.lst_statusPatterns);
            this.tabPage2.Controls.Add(this.btn_addStatus);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(343, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Status Patterns";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_removeStatus
            // 
            this.btn_removeStatus.Location = new System.Drawing.Point(265, 35);
            this.btn_removeStatus.Name = "btn_removeStatus";
            this.btn_removeStatus.Size = new System.Drawing.Size(75, 23);
            this.btn_removeStatus.TabIndex = 2;
            this.btn_removeStatus.Text = "Remove";
            this.btn_removeStatus.UseVisualStyleBackColor = true;
            this.btn_removeStatus.Click += new System.EventHandler(this.btn_removeStatus_Click);
            // 
            // lst_statusPatterns
            // 
            this.lst_statusPatterns.Dock = System.Windows.Forms.DockStyle.Left;
            this.lst_statusPatterns.FormattingEnabled = true;
            this.lst_statusPatterns.Location = new System.Drawing.Point(3, 3);
            this.lst_statusPatterns.Name = "lst_statusPatterns";
            this.lst_statusPatterns.Size = new System.Drawing.Size(256, 166);
            this.lst_statusPatterns.TabIndex = 1;
            // 
            // btn_addStatus
            // 
            this.btn_addStatus.Location = new System.Drawing.Point(265, 6);
            this.btn_addStatus.Name = "btn_addStatus";
            this.btn_addStatus.Size = new System.Drawing.Size(75, 23);
            this.btn_addStatus.TabIndex = 0;
            this.btn_addStatus.Text = "Add";
            this.btn_addStatus.UseVisualStyleBackColor = true;
            this.btn_addStatus.Click += new System.EventHandler(this.btn_addStatus_Click);
            // 
            // txt_filter
            // 
            this.txt_filter.Location = new System.Drawing.Point(13, 28);
            this.txt_filter.Name = "txt_filter";
            this.txt_filter.Size = new System.Drawing.Size(773, 20);
            this.txt_filter.TabIndex = 10;
            // 
            // txt_responseBodyFilter
            // 
            this.txt_responseBodyFilter.Location = new System.Drawing.Point(873, 250);
            this.txt_responseBodyFilter.Multiline = true;
            this.txt_responseBodyFilter.Name = "txt_responseBodyFilter";
            this.txt_responseBodyFilter.Size = new System.Drawing.Size(252, 43);
            this.txt_responseBodyFilter.TabIndex = 11;
            this.txt_responseBodyFilter.TextChanged += new System.EventHandler(this.txt_responseBodyFilter_TextChanged);
            // 
            // txt_headerFilter
            // 
            this.txt_headerFilter.Location = new System.Drawing.Point(873, 175);
            this.txt_headerFilter.Name = "txt_headerFilter";
            this.txt_headerFilter.Size = new System.Drawing.Size(252, 20);
            this.txt_headerFilter.TabIndex = 12;
            this.txt_headerFilter.TextChanged += new System.EventHandler(this.txt_headerFilter_TextChanged);
            // 
            // txt_requestBodyFilter
            // 
            this.txt_requestBodyFilter.Location = new System.Drawing.Point(873, 201);
            this.txt_requestBodyFilter.Multiline = true;
            this.txt_requestBodyFilter.Name = "txt_requestBodyFilter";
            this.txt_requestBodyFilter.Size = new System.Drawing.Size(252, 43);
            this.txt_requestBodyFilter.TabIndex = 13;
            this.txt_requestBodyFilter.TextChanged += new System.EventHandler(this.txt_requestBodyFilter_TextChanged);
            // 
            // ck_applyMethodFilter
            // 
            this.ck_applyMethodFilter.AutoSize = true;
            this.ck_applyMethodFilter.Location = new System.Drawing.Point(1131, 155);
            this.ck_applyMethodFilter.Name = "ck_applyMethodFilter";
            this.ck_applyMethodFilter.Size = new System.Drawing.Size(15, 14);
            this.ck_applyMethodFilter.TabIndex = 14;
            this.ck_applyMethodFilter.UseVisualStyleBackColor = true;
            // 
            // ck_applyHeadersFilter
            // 
            this.ck_applyHeadersFilter.AutoSize = true;
            this.ck_applyHeadersFilter.Location = new System.Drawing.Point(1131, 181);
            this.ck_applyHeadersFilter.Name = "ck_applyHeadersFilter";
            this.ck_applyHeadersFilter.Size = new System.Drawing.Size(15, 14);
            this.ck_applyHeadersFilter.TabIndex = 15;
            this.ck_applyHeadersFilter.UseVisualStyleBackColor = true;
            // 
            // ck_applyRequestBodyFilter
            // 
            this.ck_applyRequestBodyFilter.AutoSize = true;
            this.ck_applyRequestBodyFilter.Location = new System.Drawing.Point(1131, 230);
            this.ck_applyRequestBodyFilter.Name = "ck_applyRequestBodyFilter";
            this.ck_applyRequestBodyFilter.Size = new System.Drawing.Size(15, 14);
            this.ck_applyRequestBodyFilter.TabIndex = 16;
            this.ck_applyRequestBodyFilter.UseVisualStyleBackColor = true;
            // 
            // ck_applyResponseBodyFilter
            // 
            this.ck_applyResponseBodyFilter.AutoSize = true;
            this.ck_applyResponseBodyFilter.Location = new System.Drawing.Point(1131, 279);
            this.ck_applyResponseBodyFilter.Name = "ck_applyResponseBodyFilter";
            this.ck_applyResponseBodyFilter.Size = new System.Drawing.Size(15, 14);
            this.ck_applyResponseBodyFilter.TabIndex = 17;
            this.ck_applyResponseBodyFilter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1050, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ck_applyResponseBodyFilter);
            this.Controls.Add(this.ck_applyRequestBodyFilter);
            this.Controls.Add(this.ck_applyHeadersFilter);
            this.Controls.Add(this.ck_applyMethodFilter);
            this.Controls.Add(this.txt_requestBodyFilter);
            this.Controls.Add(this.txt_headerFilter);
            this.Controls.Add(this.txt_responseBodyFilter);
            this.Controls.Add(this.txt_filter);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ck_applyDateFilter);
            this.Controls.Add(this.lbl_logsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com_filterMethods);
            this.Controls.Add(this.clearFilter);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LogViewer";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox ck_applyDateFilter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_filter;
        private System.Windows.Forms.ListBox lst_controllers;
        private System.Windows.Forms.TextBox txt_responseBodyFilter;
        private System.Windows.Forms.TextBox txt_headerFilter;
        private System.Windows.Forms.TextBox txt_requestBodyFilter;
        private System.Windows.Forms.CheckBox ck_applyMethodFilter;
        private System.Windows.Forms.CheckBox ck_applyHeadersFilter;
        private System.Windows.Forms.CheckBox ck_applyRequestBodyFilter;
        private System.Windows.Forms.CheckBox ck_applyResponseBodyFilter;
        private System.Windows.Forms.Button btn_removeStatus;
        private System.Windows.Forms.ListBox lst_statusPatterns;
        private System.Windows.Forms.Button btn_addStatus;
        private System.Windows.Forms.Button button1;
    }
}

