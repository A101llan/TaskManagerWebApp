namespace TaskManagerWebApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            UserSignOutbtn = new Button();
            TasksAddbtn = new Button();
            TasksUpdatebtn = new Button();
            TasksDeletebtn = new Button();
            TaskIDlbl = new Label();
            TaskIDtxt = new TextBox();
            TaskNametxt = new TextBox();
            TaskNamelbl = new Label();
            TaskDescriptiontxt = new TextBox();
            TaskDescriptionlbl = new Label();
            TaskPrioritylbl = new Label();
            TaskDueDatelbl = new Label();
            TaskDueDatePicker = new DateTimePicker();
            TasksDataGrid = new DataGridView();
            RowID = new DataGridViewTextBoxColumn();
            TaskID = new DataGridViewTextBoxColumn();
            UserID = new DataGridViewTextBoxColumn();
            TaskName = new DataGridViewTextBoxColumn();
            TaskDescription = new DataGridViewTextBoxColumn();
            TaskPriority = new DataGridViewTextBoxColumn();
            TaskStatus = new DataGridViewTextBoxColumn();
            TaskDueDate = new DataGridViewTextBoxColumn();
            TaskStatuslbl = new Label();
            TaskStatusCom = new ComboBox();
            TaskPriorityCom = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)TasksDataGrid).BeginInit();
            SuspendLayout();
            // 
            // UserSignOutbtn
            // 
            UserSignOutbtn.Location = new Point(655, 12);
            UserSignOutbtn.Name = "UserSignOutbtn";
            UserSignOutbtn.Size = new Size(75, 23);
            UserSignOutbtn.TabIndex = 0;
            UserSignOutbtn.Text = "Sign Out";
            UserSignOutbtn.UseVisualStyleBackColor = true;
            UserSignOutbtn.Click += UserSignOutbtn_Click;
            // 
            // TasksAddbtn
            // 
            TasksAddbtn.Location = new Point(30, 335);
            TasksAddbtn.Name = "TasksAddbtn";
            TasksAddbtn.Size = new Size(75, 23);
            TasksAddbtn.TabIndex = 1;
            TasksAddbtn.Text = "Add New";
            TasksAddbtn.UseVisualStyleBackColor = true;
            TasksAddbtn.Click += TasksAddbtn_Click;
            // 
            // TasksUpdatebtn
            // 
            TasksUpdatebtn.Location = new Point(123, 335);
            TasksUpdatebtn.Name = "TasksUpdatebtn";
            TasksUpdatebtn.Size = new Size(75, 23);
            TasksUpdatebtn.TabIndex = 2;
            TasksUpdatebtn.Text = "Update";
            TasksUpdatebtn.UseVisualStyleBackColor = true;
            TasksUpdatebtn.Click += TasksUpdatebtn_Click;
            // 
            // TasksDeletebtn
            // 
            TasksDeletebtn.Cursor = Cursors.Hand;
            TasksDeletebtn.Location = new Point(30, 374);
            TasksDeletebtn.Name = "TasksDeletebtn";
            TasksDeletebtn.Size = new Size(168, 23);
            TasksDeletebtn.TabIndex = 3;
            TasksDeletebtn.Text = "Delete";
            TasksDeletebtn.UseVisualStyleBackColor = true;
            TasksDeletebtn.Click += TasksDeletebtn_Click;
            // 
            // TaskIDlbl
            // 
            TaskIDlbl.AutoSize = true;
            TaskIDlbl.Location = new Point(12, 32);
            TaskIDlbl.Name = "TaskIDlbl";
            TaskIDlbl.Size = new Size(43, 15);
            TaskIDlbl.TabIndex = 4;
            TaskIDlbl.Text = "Task ID";
            TaskIDlbl.Visible = false;
            // 
            // TaskIDtxt
            // 
            TaskIDtxt.Location = new Point(110, 32);
            TaskIDtxt.Name = "TaskIDtxt";
            TaskIDtxt.Size = new Size(154, 23);
            TaskIDtxt.TabIndex = 5;
            TaskIDtxt.Visible = false;
            // 
            // TaskNametxt
            // 
            TaskNametxt.Location = new Point(110, 81);
            TaskNametxt.Name = "TaskNametxt";
            TaskNametxt.Size = new Size(154, 23);
            TaskNametxt.TabIndex = 7;
            // 
            // TaskNamelbl
            // 
            TaskNamelbl.AutoSize = true;
            TaskNamelbl.Location = new Point(12, 81);
            TaskNamelbl.Name = "TaskNamelbl";
            TaskNamelbl.Size = new Size(64, 15);
            TaskNamelbl.TabIndex = 6;
            TaskNamelbl.Text = "Task Name";
            // 
            // TaskDescriptiontxt
            // 
            TaskDescriptiontxt.Location = new Point(110, 131);
            TaskDescriptiontxt.Name = "TaskDescriptiontxt";
            TaskDescriptiontxt.Size = new Size(154, 23);
            TaskDescriptiontxt.TabIndex = 9;
            // 
            // TaskDescriptionlbl
            // 
            TaskDescriptionlbl.AutoSize = true;
            TaskDescriptionlbl.Location = new Point(12, 134);
            TaskDescriptionlbl.Name = "TaskDescriptionlbl";
            TaskDescriptionlbl.Size = new Size(92, 15);
            TaskDescriptionlbl.TabIndex = 8;
            TaskDescriptionlbl.Text = "Task Description";
            // 
            // TaskPrioritylbl
            // 
            TaskPrioritylbl.AutoSize = true;
            TaskPrioritylbl.Location = new Point(12, 282);
            TaskPrioritylbl.Name = "TaskPrioritylbl";
            TaskPrioritylbl.Size = new Size(70, 15);
            TaskPrioritylbl.TabIndex = 10;
            TaskPrioritylbl.Text = "Task Priority";
            // 
            // TaskDueDatelbl
            // 
            TaskDueDatelbl.AutoSize = true;
            TaskDueDatelbl.Location = new Point(12, 186);
            TaskDueDatelbl.Name = "TaskDueDatelbl";
            TaskDueDatelbl.Size = new Size(55, 15);
            TaskDueDatelbl.TabIndex = 12;
            TaskDueDatelbl.Text = "Due Date";
            // 
            // TaskDueDatePicker
            // 
            TaskDueDatePicker.Location = new Point(88, 178);
            TaskDueDatePicker.Name = "TaskDueDatePicker";
            TaskDueDatePicker.Size = new Size(200, 23);
            TaskDueDatePicker.TabIndex = 13;
            // 
            // TasksDataGrid
            // 
            TasksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TasksDataGrid.Columns.AddRange(new DataGridViewColumn[] { RowID, TaskID, UserID, TaskName, TaskDescription, TaskPriority, TaskStatus, TaskDueDate });
            TasksDataGrid.Location = new Point(303, 94);
            TasksDataGrid.Name = "TasksDataGrid";
            TasksDataGrid.Size = new Size(583, 303);
            TasksDataGrid.TabIndex = 16;
            TasksDataGrid.CellContentClick += TasksDataGrid_CellContentClick;
            // 
            // RowID
            // 
            RowID.HeaderText = "Row ID";
            RowID.Name = "RowID";
            RowID.ReadOnly = true;
            // 
            // TaskID
            // 
            TaskID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TaskID.HeaderText = "Task ID";
            TaskID.Name = "TaskID";
            TaskID.ReadOnly = true;
            TaskID.Width = 63;
            // 
            // UserID
            // 
            UserID.HeaderText = "User ID";
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            // 
            // TaskName
            // 
            TaskName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TaskName.HeaderText = "Task Name";
            TaskName.Name = "TaskName";
            TaskName.Width = 82;
            // 
            // TaskDescription
            // 
            TaskDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TaskDescription.HeaderText = "Task Description";
            TaskDescription.Name = "TaskDescription";
            TaskDescription.Width = 107;
            // 
            // TaskPriority
            // 
            TaskPriority.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TaskPriority.HeaderText = "Task Priority";
            TaskPriority.Name = "TaskPriority";
            TaskPriority.Width = 88;
            // 
            // TaskStatus
            // 
            TaskStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TaskStatus.HeaderText = "Task Status";
            TaskStatus.Name = "TaskStatus";
            TaskStatus.Width = 82;
            // 
            // TaskDueDate
            // 
            TaskDueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TaskDueDate.HeaderText = "Task Due Date";
            TaskDueDate.Name = "TaskDueDate";
            TaskDueDate.Width = 97;
            // 
            // TaskStatuslbl
            // 
            TaskStatuslbl.AutoSize = true;
            TaskStatuslbl.Location = new Point(12, 236);
            TaskStatuslbl.Name = "TaskStatuslbl";
            TaskStatuslbl.Size = new Size(64, 15);
            TaskStatuslbl.TabIndex = 17;
            TaskStatuslbl.Text = "Task Status";
            // 
            // TaskStatusCom
            // 
            TaskStatusCom.FormattingEnabled = true;
            TaskStatusCom.Items.AddRange(new object[] { "New", "Pending", "In Prgress", "Complete" });
            TaskStatusCom.Location = new Point(88, 233);
            TaskStatusCom.Name = "TaskStatusCom";
            TaskStatusCom.Size = new Size(176, 23);
            TaskStatusCom.TabIndex = 19;
            // 
            // TaskPriorityCom
            // 
            TaskPriorityCom.FormattingEnabled = true;
            TaskPriorityCom.Items.AddRange(new object[] { "Urgent", "Medium", "Low" });
            TaskPriorityCom.Location = new Point(88, 282);
            TaskPriorityCom.Name = "TaskPriorityCom";
            TaskPriorityCom.Size = new Size(176, 23);
            TaskPriorityCom.TabIndex = 20;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(898, 450);
            Controls.Add(TaskPriorityCom);
            Controls.Add(TaskStatusCom);
            Controls.Add(TaskStatuslbl);
            Controls.Add(TasksDataGrid);
            Controls.Add(TaskDueDatePicker);
            Controls.Add(TaskDueDatelbl);
            Controls.Add(TaskPrioritylbl);
            Controls.Add(TaskDescriptiontxt);
            Controls.Add(TaskDescriptionlbl);
            Controls.Add(TaskNametxt);
            Controls.Add(TaskNamelbl);
            Controls.Add(TaskIDtxt);
            Controls.Add(TaskIDlbl);
            Controls.Add(TasksDeletebtn);
            Controls.Add(TasksUpdatebtn);
            Controls.Add(TasksAddbtn);
            Controls.Add(UserSignOutbtn);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)TasksDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UserSignOutbtn;
        private Button TasksAddbtn;
        private Button TasksUpdatebtn;
        private Button TasksDeletebtn;
        private Label TaskIDlbl;
        private TextBox TaskIDtxt;
        private TextBox TaskNametxt;
        private Label TaskNamelbl;
        private TextBox TaskDescriptiontxt;
        private Label TaskDescriptionlbl;
        private Label TaskPrioritylbl;
        private Label TaskDueDatelbl;
        private DateTimePicker TaskDueDatePicker;
        private CheckedListBox TaskPriorityChLiBox;
        private DataGridView TasksDataGrid;
        private CheckedListBox TaskStatusChLiBox;
        private Label TaskStatuslbl;
        private ComboBox TaskStatusCom;
        private ComboBox TaskPriorityCom;
        private DataGridViewTextBoxColumn RowID;
        private DataGridViewTextBoxColumn TaskID;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn TaskName;
        private DataGridViewTextBoxColumn TaskDescription;
        private DataGridViewTextBoxColumn TaskPriority;
        private DataGridViewTextBoxColumn TaskStatus;
        private DataGridViewTextBoxColumn TaskDueDate;
    }
}