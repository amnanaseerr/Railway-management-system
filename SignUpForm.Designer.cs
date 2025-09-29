namespace RailwayReservationSystem
{
    partial class SignUpForm
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
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.llbPassword = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonBackToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(319, 78);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(100, 26);
            this.textBoxFullName.TabIndex = 0;
            this.textBoxFullName.TextChanged += new System.EventHandler(this.textBoxFullName_TextChanged);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(190, 81);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(123, 20);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Enter Full Name";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(319, 119);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 26);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(190, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(91, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Enter Email";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(319, 166);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 26);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // llbPassword
            // 
            this.llbPassword.AutoSize = true;
            this.llbPassword.Location = new System.Drawing.Point(190, 166);
            this.llbPassword.Name = "llbPassword";
            this.llbPassword.Size = new System.Drawing.Size(121, 20);
            this.llbPassword.TabIndex = 5;
            this.llbPassword.Text = "Enter Password";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(319, 213);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(100, 26);
            this.textBoxContact.TabIndex = 6;
            this.textBoxContact.UseSystemPasswordChar = true;
            this.textBoxContact.TextChanged += new System.EventHandler(this.textBoxContact_TextChanged);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(190, 213);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(108, 20);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Enter Contact";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(328, 264);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(75, 41);
            this.buttonSignUp.TabIndex = 8;
            this.buttonSignUp.Text = "SignUp";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonBackToLogin
            // 
            this.buttonBackToLogin.Location = new System.Drawing.Point(290, 321);
            this.buttonBackToLogin.Name = "buttonBackToLogin";
            this.buttonBackToLogin.Size = new System.Drawing.Size(148, 41);
            this.buttonBackToLogin.TabIndex = 9;
            this.buttonBackToLogin.Text = "Back to Login ";
            this.buttonBackToLogin.UseVisualStyleBackColor = true;
            this.buttonBackToLogin.Click += new System.EventHandler(this.buttonBackToLogin_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackToLogin);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.llbPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.textBoxFullName);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label llbPassword;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonBackToLogin;
    }
}