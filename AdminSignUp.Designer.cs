namespace TaskManagerWebApp
{
    partial class AdminSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSignUp));
            AdminSignUpCancelbtn = new Button();
            AdminSignUpSubmitbtn = new Button();
            AdminSignUpNamelbl = new Label();
            AdminSignUpNametxt = new TextBox();
            AdminSignUpEmailtxt = new TextBox();
            AdminSignUpEmaillbl = new Label();
            AdminSignUpPasswrdtxt = new TextBox();
            AdminSignUpPasswordlbl = new Label();
            AdminSignUpConPasswordtxt = new TextBox();
            AdminSignUpConPasswordllbl = new Label();
            AdminSignUpGenderlbl = new Label();
            AdminSignUpMalerdb = new RadioButton();
            AdminSignUpFemalerdb = new RadioButton();
            SuspendLayout();
            // 
            // AdminSignUpCancelbtn
            // 
            AdminSignUpCancelbtn.Location = new Point(414, 376);
            AdminSignUpCancelbtn.Name = "AdminSignUpCancelbtn";
            AdminSignUpCancelbtn.Size = new Size(75, 23);
            AdminSignUpCancelbtn.TabIndex = 0;
            AdminSignUpCancelbtn.Text = "Cancel";
            AdminSignUpCancelbtn.UseVisualStyleBackColor = true;
            AdminSignUpCancelbtn.Click += AdminSignUpCancelbtn_Click;
            // 
            // AdminSignUpSubmitbtn
            // 
            AdminSignUpSubmitbtn.Location = new Point(560, 374);
            AdminSignUpSubmitbtn.Name = "AdminSignUpSubmitbtn";
            AdminSignUpSubmitbtn.Size = new Size(75, 23);
            AdminSignUpSubmitbtn.TabIndex = 1;
            AdminSignUpSubmitbtn.Text = "Submit";
            AdminSignUpSubmitbtn.UseVisualStyleBackColor = true;
            AdminSignUpSubmitbtn.Click += AdminSignUpSubmitbtn_Click;
            // 
            // AdminSignUpNamelbl
            // 
            AdminSignUpNamelbl.AutoSize = true;
            AdminSignUpNamelbl.ImageAlign = ContentAlignment.MiddleRight;
            AdminSignUpNamelbl.Location = new Point(189, 63);
            AdminSignUpNamelbl.Name = "AdminSignUpNamelbl";
            AdminSignUpNamelbl.Size = new Size(42, 15);
            AdminSignUpNamelbl.TabIndex = 2;
            AdminSignUpNamelbl.Text = "Name:";
            // 
            // AdminSignUpNametxt
            // 
            AdminSignUpNametxt.Location = new Point(305, 60);
            AdminSignUpNametxt.Name = "AdminSignUpNametxt";
            AdminSignUpNametxt.PlaceholderText = "Enter Name ";
            AdminSignUpNametxt.Size = new Size(193, 23);
            AdminSignUpNametxt.TabIndex = 3;
            // 
            // AdminSignUpEmailtxt
            // 
            AdminSignUpEmailtxt.Location = new Point(305, 109);
            AdminSignUpEmailtxt.Name = "AdminSignUpEmailtxt";
            AdminSignUpEmailtxt.PlaceholderText = "Enter valid Email";
            AdminSignUpEmailtxt.Size = new Size(193, 23);
            AdminSignUpEmailtxt.TabIndex = 5;
            // 
            // AdminSignUpEmaillbl
            // 
            AdminSignUpEmaillbl.AutoSize = true;
            AdminSignUpEmaillbl.ImageAlign = ContentAlignment.MiddleRight;
            AdminSignUpEmaillbl.Location = new Point(189, 112);
            AdminSignUpEmaillbl.Name = "AdminSignUpEmaillbl";
            AdminSignUpEmaillbl.Size = new Size(39, 15);
            AdminSignUpEmaillbl.TabIndex = 4;
            AdminSignUpEmaillbl.Text = "Email:";
            // 
            // AdminSignUpPasswrdtxt
            // 
            AdminSignUpPasswrdtxt.Location = new Point(305, 163);
            AdminSignUpPasswrdtxt.Name = "AdminSignUpPasswrdtxt";
            AdminSignUpPasswrdtxt.PasswordChar = '*';
            AdminSignUpPasswrdtxt.PlaceholderText = "Create password";
            AdminSignUpPasswrdtxt.Size = new Size(193, 23);
            AdminSignUpPasswrdtxt.TabIndex = 7;
            // 
            // AdminSignUpPasswordlbl
            // 
            AdminSignUpPasswordlbl.AutoSize = true;
            AdminSignUpPasswordlbl.ImageAlign = ContentAlignment.MiddleRight;
            AdminSignUpPasswordlbl.Location = new Point(189, 170);
            AdminSignUpPasswordlbl.Name = "AdminSignUpPasswordlbl";
            AdminSignUpPasswordlbl.Size = new Size(57, 15);
            AdminSignUpPasswordlbl.TabIndex = 6;
            AdminSignUpPasswordlbl.Text = "Password";
            // 
            // AdminSignUpConPasswordtxt
            // 
            AdminSignUpConPasswordtxt.Location = new Point(305, 232);
            AdminSignUpConPasswordtxt.Name = "AdminSignUpConPasswordtxt";
            AdminSignUpConPasswordtxt.PasswordChar = '*';
            AdminSignUpConPasswordtxt.PlaceholderText = "Enter password to confirm";
            AdminSignUpConPasswordtxt.Size = new Size(193, 23);
            AdminSignUpConPasswordtxt.TabIndex = 9;
            // 
            // AdminSignUpConPasswordllbl
            // 
            AdminSignUpConPasswordllbl.AutoSize = true;
            AdminSignUpConPasswordllbl.ImageAlign = ContentAlignment.MiddleRight;
            AdminSignUpConPasswordllbl.Location = new Point(189, 235);
            AdminSignUpConPasswordllbl.Name = "AdminSignUpConPasswordllbl";
            AdminSignUpConPasswordllbl.Size = new Size(107, 15);
            AdminSignUpConPasswordllbl.TabIndex = 8;
            AdminSignUpConPasswordllbl.Text = "Confirm Password:";
            // 
            // AdminSignUpGenderlbl
            // 
            AdminSignUpGenderlbl.AutoSize = true;
            AdminSignUpGenderlbl.ImageAlign = ContentAlignment.MiddleRight;
            AdminSignUpGenderlbl.Location = new Point(194, 303);
            AdminSignUpGenderlbl.Name = "AdminSignUpGenderlbl";
            AdminSignUpGenderlbl.Size = new Size(0, 15);
            AdminSignUpGenderlbl.TabIndex = 10;
            AdminSignUpGenderlbl.Visible = false;
            // 
            // AdminSignUpMalerdb
            // 
            AdminSignUpMalerdb.AutoSize = true;
            AdminSignUpMalerdb.Location = new Point(245, 297);
            AdminSignUpMalerdb.Name = "AdminSignUpMalerdb";
            AdminSignUpMalerdb.Size = new Size(51, 19);
            AdminSignUpMalerdb.TabIndex = 11;
            AdminSignUpMalerdb.TabStop = true;
            AdminSignUpMalerdb.Text = "Male";
            AdminSignUpMalerdb.UseVisualStyleBackColor = true;
            AdminSignUpMalerdb.UseWaitCursor = true;
            // 
            // AdminSignUpFemalerdb
            // 
            AdminSignUpFemalerdb.AutoSize = true;
            AdminSignUpFemalerdb.Location = new Point(366, 297);
            AdminSignUpFemalerdb.Name = "AdminSignUpFemalerdb";
            AdminSignUpFemalerdb.Size = new Size(63, 19);
            AdminSignUpFemalerdb.TabIndex = 12;
            AdminSignUpFemalerdb.TabStop = true;
            AdminSignUpFemalerdb.Text = "Female";
            AdminSignUpFemalerdb.UseVisualStyleBackColor = true;
            AdminSignUpFemalerdb.UseWaitCursor = true;
            // 
            // AdminSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(AdminSignUpFemalerdb);
            Controls.Add(AdminSignUpMalerdb);
            Controls.Add(AdminSignUpGenderlbl);
            Controls.Add(AdminSignUpConPasswordtxt);
            Controls.Add(AdminSignUpConPasswordllbl);
            Controls.Add(AdminSignUpPasswrdtxt);
            Controls.Add(AdminSignUpPasswordlbl);
            Controls.Add(AdminSignUpEmailtxt);
            Controls.Add(AdminSignUpEmaillbl);
            Controls.Add(AdminSignUpNametxt);
            Controls.Add(AdminSignUpNamelbl);
            Controls.Add(AdminSignUpSubmitbtn);
            Controls.Add(AdminSignUpCancelbtn);
            Name = "AdminSignUp";
            Text = "AdminSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AdminSignUpCancelbtn;
        private Button AdminSignUpSubmitbtn;
        private Label AdminSignUpNamelbl;
        private TextBox AdminSignUpNametxt;
        private TextBox AdminSignUpEmailtxt;
        private Label AdminSignUpEmaillbl;
        private TextBox AdminSignUpPasswrdtxt;
        private Label AdminSignUpPasswordlbl;
        private TextBox AdminSignUpConPasswordtxt;
        private Label AdminSignUpConPasswordllbl;
        private Label AdminSignUpGenderlbl;
        private RadioButton AdminSignUpMalerdb;
        private RadioButton AdminSignUpFemalerdb;
    }
}