namespace Work_Tasks
{
    partial class frmWorkTasks
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
            this.dtgData = new System.Windows.Forms.DataGridView();
            this.txtbFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rchtxtDescr = new System.Windows.Forms.RichTextBox();
            this.txtbTitle = new System.Windows.Forms.TextBox();
            this.chbRD = new System.Windows.Forms.CheckBox();
            this.chbSupport = new System.Windows.Forms.CheckBox();
            this.chbSales = new System.Windows.Forms.CheckBox();
            this.chbMarketing = new System.Windows.Forms.CheckBox();
            this.chbHR = new System.Windows.Forms.CheckBox();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstbTasks = new System.Windows.Forms.ListBox();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.btnAssignEmployee = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbcMenu = new System.Windows.Forms.TabControl();
            this.tbpTasks = new System.Windows.Forms.TabPage();
            this.tbpSearch = new System.Windows.Forms.TabPage();
            this.cmbSearchDepartment = new System.Windows.Forms.ComboBox();
            this.cmbSearchStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveTasks = new System.Windows.Forms.Button();
            this.btnLoadTasks = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbcMenu.SuspendLayout();
            this.tbpTasks.SuspendLayout();
            this.tbpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgData
            // 
            this.dtgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgData.Location = new System.Drawing.Point(1004, 94);
            this.dtgData.Name = "dtgData";
            this.dtgData.RowHeadersWidth = 51;
            this.dtgData.RowTemplate.Height = 24;
            this.dtgData.Size = new System.Drawing.Size(613, 541);
            this.dtgData.TabIndex = 0;
            // 
            // txtbFile
            // 
            this.txtbFile.Location = new System.Drawing.Point(1004, 62);
            this.txtbFile.Name = "txtbFile";
            this.txtbFile.Size = new System.Drawing.Size(334, 22);
            this.txtbFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1344, 58);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(104, 30);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1454, 58);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 30);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(25, 371);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(129, 42);
            this.btnCreateTask.TabIndex = 29;
            this.btnCreateTask.Text = "Create Task";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            this.btnCreateTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Open",
            "In Progress",
            "Completed",
            "Blocked",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(112, 319);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(232, 24);
            this.cmbStatus.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Title:";
            // 
            // rchtxtDescr
            // 
            this.rchtxtDescr.Location = new System.Drawing.Point(112, 65);
            this.rchtxtDescr.Name = "rchtxtDescr";
            this.rchtxtDescr.Size = new System.Drawing.Size(232, 233);
            this.rchtxtDescr.TabIndex = 24;
            this.rchtxtDescr.Text = "";
            // 
            // txtbTitle
            // 
            this.txtbTitle.Location = new System.Drawing.Point(112, 19);
            this.txtbTitle.Name = "txtbTitle";
            this.txtbTitle.Size = new System.Drawing.Size(128, 22);
            this.txtbTitle.TabIndex = 23;
            // 
            // chbRD
            // 
            this.chbRD.AutoSize = true;
            this.chbRD.Location = new System.Drawing.Point(112, 506);
            this.chbRD.Name = "chbRD";
            this.chbRD.Size = new System.Drawing.Size(198, 20);
            this.chbRD.TabIndex = 41;
            this.chbRD.Text = "Research and Development";
            this.chbRD.UseVisualStyleBackColor = true;
            // 
            // chbSupport
            // 
            this.chbSupport.AutoSize = true;
            this.chbSupport.Location = new System.Drawing.Point(297, 434);
            this.chbSupport.Name = "chbSupport";
            this.chbSupport.Size = new System.Drawing.Size(76, 20);
            this.chbSupport.TabIndex = 40;
            this.chbSupport.Text = "Support";
            this.chbSupport.UseVisualStyleBackColor = true;
            // 
            // chbSales
            // 
            this.chbSales.AutoSize = true;
            this.chbSales.Location = new System.Drawing.Point(176, 434);
            this.chbSales.Name = "chbSales";
            this.chbSales.Size = new System.Drawing.Size(64, 20);
            this.chbSales.TabIndex = 39;
            this.chbSales.Text = "Sales";
            this.chbSales.UseVisualStyleBackColor = true;
            // 
            // chbMarketing
            // 
            this.chbMarketing.AutoSize = true;
            this.chbMarketing.Location = new System.Drawing.Point(162, 469);
            this.chbMarketing.Name = "chbMarketing";
            this.chbMarketing.Size = new System.Drawing.Size(88, 20);
            this.chbMarketing.TabIndex = 38;
            this.chbMarketing.Text = "Marketing";
            this.chbMarketing.UseVisualStyleBackColor = true;
            // 
            // chbHR
            // 
            this.chbHR.AutoSize = true;
            this.chbHR.Location = new System.Drawing.Point(14, 434);
            this.chbHR.Name = "chbHR";
            this.chbHR.Size = new System.Drawing.Size(141, 20);
            this.chbHR.TabIndex = 37;
            this.chbHR.Text = "Human Resources";
            this.chbHR.UseVisualStyleBackColor = true;
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(114, 123);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(332, 22);
            this.txtSearchTitle.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Work_Tasks.Properties.Resources._9349901;
            this.pictureBox1.Location = new System.Drawing.Point(9, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // lstbTasks
            // 
            this.lstbTasks.FormattingEnabled = true;
            this.lstbTasks.ItemHeight = 16;
            this.lstbTasks.Location = new System.Drawing.Point(509, 23);
            this.lstbTasks.Name = "lstbTasks";
            this.lstbTasks.Size = new System.Drawing.Size(489, 500);
            this.lstbTasks.TabIndex = 45;
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Location = new System.Drawing.Point(83, 555);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(261, 22);
            this.dtpDeadline.TabIndex = 46;
            // 
            // btnAssignEmployee
            // 
            this.btnAssignEmployee.Location = new System.Drawing.Point(1004, 23);
            this.btnAssignEmployee.Name = "btnAssignEmployee";
            this.btnAssignEmployee.Size = new System.Drawing.Size(294, 33);
            this.btnAssignEmployee.TabIndex = 47;
            this.btnAssignEmployee.Text = "Assign Employee";
            this.btnAssignEmployee.UseVisualStyleBackColor = true;
            this.btnAssignEmployee.Click += new System.EventHandler(this.btnAssignEmployee_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(160, 371);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 43);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(297, 372);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 41);
            this.btnRemove.TabIndex = 49;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(338, 374);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 42);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbcMenu
            // 
            this.tbcMenu.Controls.Add(this.tbpTasks);
            this.tbcMenu.Controls.Add(this.tbpSearch);
            this.tbcMenu.Location = new System.Drawing.Point(12, 4);
            this.tbcMenu.Name = "tbcMenu";
            this.tbcMenu.SelectedIndex = 0;
            this.tbcMenu.Size = new System.Drawing.Size(470, 641);
            this.tbcMenu.TabIndex = 51;
            // 
            // tbpTasks
            // 
            this.tbpTasks.Controls.Add(this.label8);
            this.tbpTasks.Controls.Add(this.rchtxtDescr);
            this.tbpTasks.Controls.Add(this.txtbTitle);
            this.tbpTasks.Controls.Add(this.btnRemove);
            this.tbpTasks.Controls.Add(this.label1);
            this.tbpTasks.Controls.Add(this.btnUpdate);
            this.tbpTasks.Controls.Add(this.label2);
            this.tbpTasks.Controls.Add(this.cmbStatus);
            this.tbpTasks.Controls.Add(this.dtpDeadline);
            this.tbpTasks.Controls.Add(this.label3);
            this.tbpTasks.Controls.Add(this.btnCreateTask);
            this.tbpTasks.Controls.Add(this.chbHR);
            this.tbpTasks.Controls.Add(this.chbMarketing);
            this.tbpTasks.Controls.Add(this.chbRD);
            this.tbpTasks.Controls.Add(this.chbSales);
            this.tbpTasks.Controls.Add(this.chbSupport);
            this.tbpTasks.Location = new System.Drawing.Point(4, 25);
            this.tbpTasks.Name = "tbpTasks";
            this.tbpTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTasks.Size = new System.Drawing.Size(462, 612);
            this.tbpTasks.TabIndex = 0;
            this.tbpTasks.Text = "Tasks";
            this.tbpTasks.UseVisualStyleBackColor = true;
            // 
            // tbpSearch
            // 
            this.tbpSearch.Controls.Add(this.cmbSearchDepartment);
            this.tbpSearch.Controls.Add(this.cmbSearchStatus);
            this.tbpSearch.Controls.Add(this.label7);
            this.tbpSearch.Controls.Add(this.label6);
            this.tbpSearch.Controls.Add(this.label5);
            this.tbpSearch.Controls.Add(this.label4);
            this.tbpSearch.Controls.Add(this.txtSearchTitle);
            this.tbpSearch.Controls.Add(this.btnSearch);
            this.tbpSearch.Controls.Add(this.pictureBox1);
            this.tbpSearch.Location = new System.Drawing.Point(4, 25);
            this.tbpSearch.Name = "tbpSearch";
            this.tbpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSearch.Size = new System.Drawing.Size(462, 612);
            this.tbpSearch.TabIndex = 1;
            this.tbpSearch.Text = "Search";
            this.tbpSearch.UseVisualStyleBackColor = true;
            // 
            // cmbSearchDepartment
            // 
            this.cmbSearchDepartment.FormattingEnabled = true;
            this.cmbSearchDepartment.Items.AddRange(new object[] {
            "Human Resources",
            "Sales",
            "Support",
            "Marketing",
            "Development and Research"});
            this.cmbSearchDepartment.Location = new System.Drawing.Point(114, 317);
            this.cmbSearchDepartment.Name = "cmbSearchDepartment";
            this.cmbSearchDepartment.Size = new System.Drawing.Size(332, 24);
            this.cmbSearchDepartment.TabIndex = 56;
            // 
            // cmbSearchStatus
            // 
            this.cmbSearchStatus.FormattingEnabled = true;
            this.cmbSearchStatus.Items.AddRange(new object[] {
            "Open",
            "In Progress",
            "Completed",
            "Blocked",
            "Cancelled"});
            this.cmbSearchStatus.Location = new System.Drawing.Point(114, 218);
            this.cmbSearchStatus.Name = "cmbSearchStatus";
            this.cmbSearchStatus.Size = new System.Drawing.Size(332, 24);
            this.cmbSearchStatus.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Search by:";
            // 
            // btnSaveTasks
            // 
            this.btnSaveTasks.Location = new System.Drawing.Point(509, 550);
            this.btnSaveTasks.Name = "btnSaveTasks";
            this.btnSaveTasks.Size = new System.Drawing.Size(211, 55);
            this.btnSaveTasks.TabIndex = 52;
            this.btnSaveTasks.Text = "Save Task Data";
            this.btnSaveTasks.UseVisualStyleBackColor = true;
            this.btnSaveTasks.Click += new System.EventHandler(this.btnSaveTasks_Click);
            // 
            // btnLoadTasks
            // 
            this.btnLoadTasks.Location = new System.Drawing.Point(787, 550);
            this.btnLoadTasks.Name = "btnLoadTasks";
            this.btnLoadTasks.Size = new System.Drawing.Size(211, 55);
            this.btnLoadTasks.TabIndex = 53;
            this.btnLoadTasks.Text = "Load Task Data";
            this.btnLoadTasks.UseVisualStyleBackColor = true;
            this.btnLoadTasks.Click += new System.EventHandler(this.btnLoadTasks_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "Deadline:";
            // 
            // frmWorkTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 647);
            this.Controls.Add(this.btnLoadTasks);
            this.Controls.Add(this.btnSaveTasks);
            this.Controls.Add(this.tbcMenu);
            this.Controls.Add(this.btnAssignEmployee);
            this.Controls.Add(this.lstbTasks);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtbFile);
            this.Controls.Add(this.dtgData);
            this.Name = "frmWorkTasks";
            this.Text = "Work Tasks";
            ((System.ComponentModel.ISupportInitialize)(this.dtgData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbcMenu.ResumeLayout(false);
            this.tbpTasks.ResumeLayout(false);
            this.tbpTasks.PerformLayout();
            this.tbpSearch.ResumeLayout(false);
            this.tbpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgData;
        private System.Windows.Forms.TextBox txtbFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchtxtDescr;
        private System.Windows.Forms.TextBox txtbTitle;
        private System.Windows.Forms.CheckBox chbRD;
        private System.Windows.Forms.CheckBox chbSupport;
        private System.Windows.Forms.CheckBox chbSales;
        private System.Windows.Forms.CheckBox chbMarketing;
        private System.Windows.Forms.CheckBox chbHR;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstbTasks;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Button btnAssignEmployee;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl tbcMenu;
        private System.Windows.Forms.TabPage tbpTasks;
        private System.Windows.Forms.TabPage tbpSearch;
        private System.Windows.Forms.ComboBox cmbSearchDepartment;
        private System.Windows.Forms.ComboBox cmbSearchStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveTasks;
        private System.Windows.Forms.Button btnLoadTasks;
        private System.Windows.Forms.Label label8;
    }
}

