namespace TaskManagerWebApp
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            UserSignInbtn = new Button();
            UserSignUpbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // UserSignInbtn
            // 
            UserSignInbtn.BackColor = Color.Tan;
            UserSignInbtn.FlatStyle = FlatStyle.System;
            UserSignInbtn.Location = new Point(458, 320);
            UserSignInbtn.Name = "UserSignInbtn";
            UserSignInbtn.Size = new Size(75, 23);
            UserSignInbtn.TabIndex = 1;
            UserSignInbtn.Text = "Sign In";
            UserSignInbtn.UseVisualStyleBackColor = false;
            UserSignInbtn.Click += UserSignInbtn_Click;
            // 
            // UserSignUpbtn
            // 
            UserSignUpbtn.BackColor = Color.Tan;
            UserSignUpbtn.BackgroundImageLayout = ImageLayout.None;
            UserSignUpbtn.Cursor = Cursors.Hand;
            UserSignUpbtn.FlatStyle = FlatStyle.System;
            UserSignUpbtn.ForeColor = Color.SeaShell;
            UserSignUpbtn.Location = new Point(193, 320);
            UserSignUpbtn.Name = "UserSignUpbtn";
            UserSignUpbtn.Size = new Size(75, 23);
            UserSignUpbtn.TabIndex = 2;
            UserSignUpbtn.Text = "Sign Up";
            UserSignUpbtn.UseVisualStyleBackColor = false;
            UserSignUpbtn.Click += UserSignUpbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Ink Free", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(199, 47);
            label1.Name = "label1";
            label1.Size = new Size(334, 34);
            label1.TabIndex = 3;
            label1.Text = "Welcome to Task Maestro";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Tan;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Ink Free", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 123);
            label2.Name = "label2";
            label2.Size = new Size(468, 26);
            label2.TabIndex = 4;
            label2.Text = "Your ultimate weapon against procrastination!";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UserSignUpbtn);
            Controls.Add(UserSignInbtn);
            Name = "Index";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UserSignInbtn;
        private Button UserSignUpbtn;
        private Label label1;
        private Label label2;
    }
}
