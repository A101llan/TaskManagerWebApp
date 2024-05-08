namespace TaskManagerWebApp
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            AdminSignUpbtn = new Button();
            AdminSignOutbtn = new Button();
            UsersDataGrid = new DataGridView();
            RowID = new DataGridViewTextBoxColumn();
            UserID = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            UserEmail = new DataGridViewTextBoxColumn();
            UserGender = new DataGridViewTextBoxColumn();
            UserRole = new DataGridViewTextBoxColumn();
            UserIDDVGtxt = new TextBox();
            UserDeleteDVGbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)UsersDataGrid).BeginInit();
            SuspendLayout();
            // 
            // AdminSignUpbtn
            // 
            AdminSignUpbtn.Location = new Point(438, 12);
            AdminSignUpbtn.Name = "AdminSignUpbtn";
            AdminSignUpbtn.Size = new Size(127, 23);
            AdminSignUpbtn.TabIndex = 0;
            AdminSignUpbtn.Text = "Add New Admin";
            AdminSignUpbtn.UseVisualStyleBackColor = true;
            AdminSignUpbtn.Click += AdminSignUpbtn_Click;
            // 
            // AdminSignOutbtn
            // 
            AdminSignOutbtn.Location = new Point(620, 12);
            AdminSignOutbtn.Name = "AdminSignOutbtn";
            AdminSignOutbtn.Size = new Size(75, 23);
            AdminSignOutbtn.TabIndex = 1;
            AdminSignOutbtn.Text = "Sign Out";
            AdminSignOutbtn.UseVisualStyleBackColor = true;
            AdminSignOutbtn.Click += AdminSignOutbtn_Click;
            // 
            // UsersDataGrid
            // 
            UsersDataGrid.BackgroundColor = SystemColors.ButtonFace;
            UsersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersDataGrid.Columns.AddRange(new DataGridViewColumn[] { RowID, UserID, UserName, UserEmail, UserGender, UserRole });
            UsersDataGrid.GridColor = SystemColors.InactiveBorder;
            UsersDataGrid.Location = new Point(212, 116);
            UsersDataGrid.Name = "UsersDataGrid";
            UsersDataGrid.Size = new Size(543, 258);
            UsersDataGrid.TabIndex = 2;
            UsersDataGrid.CellContentClick += UsersDataGrid_CellContentClick;
            // 
            // RowID
            // 
            RowID.HeaderText = "Row ID";
            RowID.Name = "RowID";
            RowID.ReadOnly = true;
            // 
            // UserID
            // 
            UserID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UserID.HeaderText = "User ID";
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Width = 69;
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UserName.HeaderText = "Name";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            UserName.Width = 64;
            // 
            // UserEmail
            // 
            UserEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UserEmail.HeaderText = "Email";
            UserEmail.Name = "UserEmail";
            UserEmail.ReadOnly = true;
            UserEmail.Width = 61;
            // 
            // UserGender
            // 
            UserGender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UserGender.HeaderText = "Gender";
            UserGender.Name = "UserGender";
            UserGender.ReadOnly = true;
            UserGender.Width = 70;
            // 
            // UserRole
            // 
            UserRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            UserRole.HeaderText = "Role";
            UserRole.Name = "UserRole";
            UserRole.Width = 55;
            // 
            // UserIDDVGtxt
            // 
            UserIDDVGtxt.Location = new Point(15, 193);
            UserIDDVGtxt.Name = "UserIDDVGtxt";
            UserIDDVGtxt.PlaceholderText = "User ID";
            UserIDDVGtxt.Size = new Size(163, 23);
            UserIDDVGtxt.TabIndex = 9;
            // 
            // UserDeleteDVGbtn
            // 
            UserDeleteDVGbtn.Location = new Point(15, 243);
            UserDeleteDVGbtn.Name = "UserDeleteDVGbtn";
            UserDeleteDVGbtn.Size = new Size(163, 23);
            UserDeleteDVGbtn.TabIndex = 10;
            UserDeleteDVGbtn.Text = "Delete";
            UserDeleteDVGbtn.UseVisualStyleBackColor = true;
            UserDeleteDVGbtn.Click += UserDeleteDVGbtn_Click;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(UserDeleteDVGbtn);
            Controls.Add(UserIDDVGtxt);
            Controls.Add(UsersDataGrid);
            Controls.Add(AdminSignOutbtn);
            Controls.Add(AdminSignUpbtn);
            Name = "AdminHome";
            Text = "AdminHome";
            ((System.ComponentModel.ISupportInitialize)UsersDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AdminSignUpbtn;
        private Button AdminSignOutbtn;
        private DataGridView UsersDataGrid;
        private TextBox UserIDDVGtxt;
        private Button UserDeleteDVGbtn;
        private DataGridViewTextBoxColumn RowID;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserEmail;
        private DataGridViewTextBoxColumn UserGender;
        private DataGridViewTextBoxColumn UserRole;
    }
}