namespace TaskManagerWebApp
{
    partial class UserSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignIn));
            UserSignInCancelbtn = new Button();
            UserSignInEmaillbl = new Label();
            UserSignInEmailtxt = new TextBox();
            UserSignInPasswordtxt = new TextBox();
            UserSignInPasswordlbl = new Label();
            UserSignInSubmitbtn = new Button();
            SuspendLayout();
            // 
            // UserSignInCancelbtn
            // 
            UserSignInCancelbtn.BackColor = Color.Tan;
            UserSignInCancelbtn.BackgroundImageLayout = ImageLayout.None;
            UserSignInCancelbtn.Location = new Point(233, 324);
            UserSignInCancelbtn.Name = "UserSignInCancelbtn";
            UserSignInCancelbtn.Size = new Size(75, 23);
            UserSignInCancelbtn.TabIndex = 0;
            UserSignInCancelbtn.Text = "Cancel";
            UserSignInCancelbtn.UseVisualStyleBackColor = false;
            UserSignInCancelbtn.Click += UserSignInCancelbtn_Click;
            // 
            // UserSignInEmaillbl
            // 
            UserSignInEmaillbl.AutoSize = true;
            UserSignInEmaillbl.BackColor = Color.Tan;
            UserSignInEmaillbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserSignInEmaillbl.Location = new Point(202, 93);
            UserSignInEmaillbl.Name = "UserSignInEmaillbl";
            UserSignInEmaillbl.Size = new Size(39, 17);
            UserSignInEmaillbl.TabIndex = 1;
            UserSignInEmaillbl.Text = "Email";
            // 
            // UserSignInEmailtxt
            // 
            UserSignInEmailtxt.Location = new Point(312, 90);
            UserSignInEmailtxt.Name = "UserSignInEmailtxt";
            UserSignInEmailtxt.PlaceholderText = "Input Email";
            UserSignInEmailtxt.Size = new Size(200, 23);
            UserSignInEmailtxt.TabIndex = 2;
            // 
            // UserSignInPasswordtxt
            // 
            UserSignInPasswordtxt.BackColor = Color.White;
            UserSignInPasswordtxt.Location = new Point(312, 160);
            UserSignInPasswordtxt.Name = "UserSignInPasswordtxt";
            UserSignInPasswordtxt.PasswordChar = '*';
            UserSignInPasswordtxt.PlaceholderText = "Input password";
            UserSignInPasswordtxt.Size = new Size(200, 23);
            UserSignInPasswordtxt.TabIndex = 4;
            // 
            // UserSignInPasswordlbl
            // 
            UserSignInPasswordlbl.AutoSize = true;
            UserSignInPasswordlbl.BackColor = Color.Tan;
            UserSignInPasswordlbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserSignInPasswordlbl.Location = new Point(202, 163);
            UserSignInPasswordlbl.Name = "UserSignInPasswordlbl";
            UserSignInPasswordlbl.Size = new Size(64, 17);
            UserSignInPasswordlbl.TabIndex = 3;
            UserSignInPasswordlbl.Text = "Password";
            // 
            // UserSignInSubmitbtn
            // 
            UserSignInSubmitbtn.BackColor = Color.Tan;
            UserSignInSubmitbtn.Location = new Point(402, 324);
            UserSignInSubmitbtn.Name = "UserSignInSubmitbtn";
            UserSignInSubmitbtn.Size = new Size(75, 23);
            UserSignInSubmitbtn.TabIndex = 5;
            UserSignInSubmitbtn.Text = "Submit";
            UserSignInSubmitbtn.UseVisualStyleBackColor = false;
            UserSignInSubmitbtn.Click += UserSignInSubmitbtn_Click;
            // 
            // UserSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(UserSignInSubmitbtn);
            Controls.Add(UserSignInPasswordtxt);
            Controls.Add(UserSignInPasswordlbl);
            Controls.Add(UserSignInEmailtxt);
            Controls.Add(UserSignInEmaillbl);
            Controls.Add(UserSignInCancelbtn);
            Name = "UserSignIn";
            Text = "UserSignIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UserSignInCancelbtn;
        private Label UserSignInEmaillbl;
        private TextBox UserSignInEmailtxt;
        private TextBox UserSignInPasswordtxt;
        private Label UserSignInPasswordlbl;
        private Button UserSignInSubmitbtn;
    }
}