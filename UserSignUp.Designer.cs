namespace TaskManagerWebApp
{
    partial class UserSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignUp));
            UserSignUpCancelbtn = new Button();
            UserSignUpSubmitbtn = new Button();
            UserSignUpNamelbl = new Label();
            UserSignUpNametxt = new TextBox();
            UserSignUpEmailtxt = new TextBox();
            UserSignUpEmaillbl = new Label();
            UserSignUpPasswrdtxt = new TextBox();
            UserSignUpPasswordlbl = new Label();
            UserSignUpConPasswordtxt = new TextBox();
            UserSignUpConPasswordllbl = new Label();
            UserSignUpGenderlbl = new Label();
            UserSignUpMalerdb = new RadioButton();
            UserSignUpFemalerdb = new RadioButton();
            SuspendLayout();
            // 
            // UserSignUpCancelbtn
            // 
            UserSignUpCancelbtn.Cursor = Cursors.Hand;
            UserSignUpCancelbtn.Location = new Point(231, 374);
            UserSignUpCancelbtn.Name = "UserSignUpCancelbtn";
            UserSignUpCancelbtn.Size = new Size(75, 23);
            UserSignUpCancelbtn.TabIndex = 0;
            UserSignUpCancelbtn.Text = "Cancel";
            UserSignUpCancelbtn.UseVisualStyleBackColor = true;
            UserSignUpCancelbtn.Click += UserSignUpCancelbtn_Click;
            // 
            // UserSignUpSubmitbtn
            // 
            UserSignUpSubmitbtn.Cursor = Cursors.Hand;
            UserSignUpSubmitbtn.Location = new Point(412, 374);
            UserSignUpSubmitbtn.Name = "UserSignUpSubmitbtn";
            UserSignUpSubmitbtn.Size = new Size(75, 23);
            UserSignUpSubmitbtn.TabIndex = 1;
            UserSignUpSubmitbtn.Text = "Submit";
            UserSignUpSubmitbtn.UseVisualStyleBackColor = true;
            UserSignUpSubmitbtn.Click += UserSignUpSubmitbtn_Click;
            // 
            // UserSignUpNamelbl
            // 
            UserSignUpNamelbl.AutoSize = true;
            UserSignUpNamelbl.BackColor = Color.Tan;
            UserSignUpNamelbl.BorderStyle = BorderStyle.FixedSingle;
            UserSignUpNamelbl.Cursor = Cursors.Hand;
            UserSignUpNamelbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserSignUpNamelbl.ImageAlign = ContentAlignment.MiddleRight;
            UserSignUpNamelbl.Location = new Point(189, 63);
            UserSignUpNamelbl.Name = "UserSignUpNamelbl";
            UserSignUpNamelbl.Size = new Size(72, 19);
            UserSignUpNamelbl.TabIndex = 2;
            UserSignUpNamelbl.Text = "Username:";
            // 
            // UserSignUpNametxt
            // 
            UserSignUpNametxt.Location = new Point(348, 59);
            UserSignUpNametxt.Name = "UserSignUpNametxt";
            UserSignUpNametxt.PlaceholderText = "Input Username";
            UserSignUpNametxt.Size = new Size(193, 23);
            UserSignUpNametxt.TabIndex = 3;
            // 
            // UserSignUpEmailtxt
            // 
            UserSignUpEmailtxt.Location = new Point(348, 111);
            UserSignUpEmailtxt.Name = "UserSignUpEmailtxt";
            UserSignUpEmailtxt.PlaceholderText = "Enter valid Email";
            UserSignUpEmailtxt.Size = new Size(193, 23);
            UserSignUpEmailtxt.TabIndex = 5;
            // 
            // UserSignUpEmaillbl
            // 
            UserSignUpEmaillbl.AutoSize = true;
            UserSignUpEmaillbl.BackColor = Color.Tan;
            UserSignUpEmaillbl.BorderStyle = BorderStyle.FixedSingle;
            UserSignUpEmaillbl.Cursor = Cursors.Hand;
            UserSignUpEmaillbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserSignUpEmaillbl.ImageAlign = ContentAlignment.MiddleRight;
            UserSignUpEmaillbl.Location = new Point(189, 115);
            UserSignUpEmaillbl.Name = "UserSignUpEmaillbl";
            UserSignUpEmaillbl.Size = new Size(44, 19);
            UserSignUpEmaillbl.TabIndex = 4;
            UserSignUpEmaillbl.Text = "Email:";
            // 
            // UserSignUpPasswrdtxt
            // 
            UserSignUpPasswrdtxt.Location = new Point(348, 170);
            UserSignUpPasswrdtxt.Name = "UserSignUpPasswrdtxt";
            UserSignUpPasswrdtxt.PasswordChar = '*';
            UserSignUpPasswrdtxt.PlaceholderText = "Create New Password";
            UserSignUpPasswrdtxt.Size = new Size(193, 23);
            UserSignUpPasswrdtxt.TabIndex = 7;
            // 
            // UserSignUpPasswordlbl
            // 
            UserSignUpPasswordlbl.AutoSize = true;
            UserSignUpPasswordlbl.BackColor = Color.Tan;
            UserSignUpPasswordlbl.BorderStyle = BorderStyle.FixedSingle;
            UserSignUpPasswordlbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserSignUpPasswordlbl.ImageAlign = ContentAlignment.MiddleRight;
            UserSignUpPasswordlbl.Location = new Point(189, 176);
            UserSignUpPasswordlbl.Name = "UserSignUpPasswordlbl";
            UserSignUpPasswordlbl.Size = new Size(66, 19);
            UserSignUpPasswordlbl.TabIndex = 6;
            UserSignUpPasswordlbl.Text = "Password";
            // 
            // UserSignUpConPasswordtxt
            // 
            UserSignUpConPasswordtxt.Location = new Point(348, 229);
            UserSignUpConPasswordtxt.Name = "UserSignUpConPasswordtxt";
            UserSignUpConPasswordtxt.PasswordChar = '*';
            UserSignUpConPasswordtxt.PlaceholderText = "Enter Password again";
            UserSignUpConPasswordtxt.Size = new Size(193, 23);
            UserSignUpConPasswordtxt.TabIndex = 9;
            // 
            // UserSignUpConPasswordllbl
            // 
            UserSignUpConPasswordllbl.AutoSize = true;
            UserSignUpConPasswordllbl.BackColor = Color.Tan;
            UserSignUpConPasswordllbl.BorderStyle = BorderStyle.FixedSingle;
            UserSignUpConPasswordllbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserSignUpConPasswordllbl.ImageAlign = ContentAlignment.MiddleRight;
            UserSignUpConPasswordllbl.Location = new Point(189, 235);
            UserSignUpConPasswordllbl.Name = "UserSignUpConPasswordllbl";
            UserSignUpConPasswordllbl.Size = new Size(119, 19);
            UserSignUpConPasswordllbl.TabIndex = 8;
            UserSignUpConPasswordllbl.Text = "Confirm Password:";
            // 
            // UserSignUpGenderlbl
            // 
            UserSignUpGenderlbl.AutoSize = true;
            UserSignUpGenderlbl.ImageAlign = ContentAlignment.MiddleRight;
            UserSignUpGenderlbl.Location = new Point(194, 303);
            UserSignUpGenderlbl.Name = "UserSignUpGenderlbl";
            UserSignUpGenderlbl.Size = new Size(0, 15);
            UserSignUpGenderlbl.TabIndex = 10;
            UserSignUpGenderlbl.Visible = false;
            // 
            // UserSignUpMalerdb
            // 
            UserSignUpMalerdb.AutoSize = true;
            UserSignUpMalerdb.BackColor = Color.Tan;
            UserSignUpMalerdb.Cursor = Cursors.Hand;
            UserSignUpMalerdb.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserSignUpMalerdb.Location = new Point(348, 297);
            UserSignUpMalerdb.Name = "UserSignUpMalerdb";
            UserSignUpMalerdb.Size = new Size(55, 21);
            UserSignUpMalerdb.TabIndex = 11;
            UserSignUpMalerdb.TabStop = true;
            UserSignUpMalerdb.Text = "Male";
            UserSignUpMalerdb.UseVisualStyleBackColor = false;
            UserSignUpMalerdb.UseWaitCursor = true;
            UserSignUpMalerdb.CheckedChanged += UserSignUpMalerdb_CheckedChanged;
            // 
            // UserSignUpFemalerdb
            // 
            UserSignUpFemalerdb.AutoSize = true;
            UserSignUpFemalerdb.BackColor = Color.Tan;
            UserSignUpFemalerdb.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserSignUpFemalerdb.Location = new Point(474, 297);
            UserSignUpFemalerdb.Name = "UserSignUpFemalerdb";
            UserSignUpFemalerdb.Size = new Size(67, 21);
            UserSignUpFemalerdb.TabIndex = 12;
            UserSignUpFemalerdb.TabStop = true;
            UserSignUpFemalerdb.Text = "Female";
            UserSignUpFemalerdb.UseVisualStyleBackColor = false;
            UserSignUpFemalerdb.UseWaitCursor = true;
            // 
            // UserSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(UserSignUpFemalerdb);
            Controls.Add(UserSignUpMalerdb);
            Controls.Add(UserSignUpGenderlbl);
            Controls.Add(UserSignUpConPasswordtxt);
            Controls.Add(UserSignUpConPasswordllbl);
            Controls.Add(UserSignUpPasswrdtxt);
            Controls.Add(UserSignUpPasswordlbl);
            Controls.Add(UserSignUpEmailtxt);
            Controls.Add(UserSignUpEmaillbl);
            Controls.Add(UserSignUpNametxt);
            Controls.Add(UserSignUpNamelbl);
            Controls.Add(UserSignUpSubmitbtn);
            Controls.Add(UserSignUpCancelbtn);
            Name = "UserSignUp";
            Text = "UserSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UserSignUpCancelbtn;
        private Button UserSignUpSubmitbtn;
        private Label UserSignUpNamelbl;
        private TextBox UserSignUpNametxt;
        private TextBox UserSignUpEmailtxt;
        private Label UserSignUpEmaillbl;
        private TextBox UserSignUpPasswrdtxt;
        private Label UserSignUpPasswordlbl;
        private TextBox UserSignUpConPasswordtxt;
        private Label UserSignUpConPasswordllbl;
        private Label UserSignUpGenderlbl;
        private RadioButton UserSignUpMalerdb;
        private RadioButton UserSignUpFemalerdb;
    }
}