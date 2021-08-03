
namespace UniversityApp
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.universityAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlStudentdataGridView = new System.Windows.Forms.DataGridView();
            this.ctrlProfessordataGridView = new System.Windows.Forms.DataGridView();
            this.ctrlCoursedataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDays = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHours = new System.Windows.Forms.ComboBox();
            this.btnAddNewSchedule = new System.Windows.Forms.Button();
            this.btnViewSchedules = new System.Windows.Forms.Button();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProfessordataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCoursedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.universityAppToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // universityAppToolStripMenuItem
            // 
            this.universityAppToolStripMenuItem.Name = "universityAppToolStripMenuItem";
            this.universityAppToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.universityAppToolStripMenuItem.Text = "Menu";
            // 
            // ctrlStudentdataGridView
            // 
            this.ctrlStudentdataGridView.AllowUserToAddRows = false;
            this.ctrlStudentdataGridView.AllowUserToDeleteRows = false;
            this.ctrlStudentdataGridView.AutoGenerateColumns = false;
            this.ctrlStudentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlStudentdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.ctrlStudentdataGridView.DataSource = this.studentBindingSource;
            this.ctrlStudentdataGridView.Location = new System.Drawing.Point(30, 105);
            this.ctrlStudentdataGridView.Name = "ctrlStudentdataGridView";
            this.ctrlStudentdataGridView.ReadOnly = true;
            this.ctrlStudentdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlStudentdataGridView.Size = new System.Drawing.Size(443, 198);
            this.ctrlStudentdataGridView.TabIndex = 2;
            // 
            // ctrlProfessordataGridView
            // 
            this.ctrlProfessordataGridView.AllowUserToAddRows = false;
            this.ctrlProfessordataGridView.AllowUserToDeleteRows = false;
            this.ctrlProfessordataGridView.AutoGenerateColumns = false;
            this.ctrlProfessordataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlProfessordataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rankDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.ageDataGridViewTextBoxColumn1,
            this.iDDataGridViewTextBoxColumn1});
            this.ctrlProfessordataGridView.DataSource = this.professorBindingSource;
            this.ctrlProfessordataGridView.Location = new System.Drawing.Point(628, 105);
            this.ctrlProfessordataGridView.Name = "ctrlProfessordataGridView";
            this.ctrlProfessordataGridView.ReadOnly = true;
            this.ctrlProfessordataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlProfessordataGridView.Size = new System.Drawing.Size(445, 198);
            this.ctrlProfessordataGridView.TabIndex = 3;
            // 
            // ctrlCoursedataGridView
            // 
            this.ctrlCoursedataGridView.AllowUserToAddRows = false;
            this.ctrlCoursedataGridView.AllowUserToDeleteRows = false;
            this.ctrlCoursedataGridView.AutoGenerateColumns = false;
            this.ctrlCoursedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctrlCoursedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn2});
            this.ctrlCoursedataGridView.DataSource = this.courseBindingSource;
            this.ctrlCoursedataGridView.Location = new System.Drawing.Point(326, 323);
            this.ctrlCoursedataGridView.Name = "ctrlCoursedataGridView";
            this.ctrlCoursedataGridView.ReadOnly = true;
            this.ctrlCoursedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlCoursedataGridView.Size = new System.Drawing.Size(443, 198);
            this.ctrlCoursedataGridView.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(512, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "University Scheduler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(195, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(836, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Professors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(513, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Courses";
            // 
            // dateTimePickerDays
            // 
            this.dateTimePickerDays.Location = new System.Drawing.Point(12, 28);
            this.dateTimePickerDays.Name = "dateTimePickerDays";
            this.dateTimePickerDays.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDays.TabIndex = 11;
            // 
            // dateTimePickerHours
            // 
            this.dateTimePickerHours.FormattingEnabled = true;
            this.dateTimePickerHours.Items.AddRange(new object[] {
            "08:00-10:00",
            "10:00-12:00",
            "12:00-14:00",
            "14:00-16:00",
            "16:00-18:00",
            "18:00-20:00"});
            this.dateTimePickerHours.Location = new System.Drawing.Point(218, 27);
            this.dateTimePickerHours.Name = "dateTimePickerHours";
            this.dateTimePickerHours.Size = new System.Drawing.Size(121, 21);
            this.dateTimePickerHours.TabIndex = 24;
            this.dateTimePickerHours.SelectedIndexChanged += new System.EventHandler(this.dateTimePickerHours_SelectedIndexChanged);
            // 
            // btnAddNewSchedule
            // 
            this.btnAddNewSchedule.Location = new System.Drawing.Point(363, 28);
            this.btnAddNewSchedule.Name = "btnAddNewSchedule";
            this.btnAddNewSchedule.Size = new System.Drawing.Size(143, 32);
            this.btnAddNewSchedule.TabIndex = 25;
            this.btnAddNewSchedule.Text = "Add New Schedule";
            this.btnAddNewSchedule.UseVisualStyleBackColor = true;
            this.btnAddNewSchedule.Click += new System.EventHandler(this.btnAddNewSchedule_Click);
            // 
            // btnViewSchedules
            // 
            this.btnViewSchedules.Location = new System.Drawing.Point(859, 323);
            this.btnViewSchedules.Name = "btnViewSchedules";
            this.btnViewSchedules.Size = new System.Drawing.Size(143, 32);
            this.btnViewSchedules.TabIndex = 26;
            this.btnViewSchedules.Text = "View Schedules";
            this.btnViewSchedules.UseVisualStyleBackColor = true;
            this.btnViewSchedules.Click += new System.EventHandler(this.btnViewSchedules_Click);
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(UniversityApp.Impl.Schedule);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(UniversityApp.Impl.Course);
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "Rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            this.surnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn1
            // 
            this.ageDataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn1.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            this.ageDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(UniversityApp.Impl.Professor);
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            this.registrationNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(UniversityApp.Impl.Student);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1174, 522);
            this.Controls.Add(this.btnViewSchedules);
            this.Controls.Add(this.btnAddNewSchedule);
            this.Controls.Add(this.dateTimePickerHours);
            this.Controls.Add(this.dateTimePickerDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlCoursedataGridView);
            this.Controls.Add(this.ctrlProfessordataGridView);
            this.Controls.Add(this.ctrlStudentdataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "University App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlStudentdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlProfessordataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCoursedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem universityAppToolStripMenuItem;
        private System.Windows.Forms.DataGridView ctrlStudentdataGridView;
        private System.Windows.Forms.DataGridView ctrlProfessordataGridView;
        private System.Windows.Forms.DataGridView ctrlCoursedataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDays;
        private System.Windows.Forms.ComboBox dateTimePickerHours;
        private System.Windows.Forms.Button btnAddNewSchedule;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnViewSchedules;
    }
}

