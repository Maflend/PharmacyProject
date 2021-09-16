
namespace PharmacyForms
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblValidLogin = new System.Windows.Forms.Label();
            this.lblValidPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignUp.Location = new System.Drawing.Point(149, 177);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(170, 33);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "Зарегистрироваться";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(149, 80);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(324, 29);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbTextChanged);
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLogin.Location = new System.Drawing.Point(149, 20);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(324, 29);
            this.tbLogin.TabIndex = 8;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbTextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(9, 83);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(123, 21);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Введите пароль";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(9, 23);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(113, 21);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Введите логин";
            // 
            // lblValidLogin
            // 
            this.lblValidLogin.AutoSize = true;
            this.lblValidLogin.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidLogin.ForeColor = System.Drawing.Color.Red;
            this.lblValidLogin.Location = new System.Drawing.Point(149, 52);
            this.lblValidLogin.Name = "lblValidLogin";
            this.lblValidLogin.Size = new System.Drawing.Size(80, 13);
            this.lblValidLogin.TabIndex = 11;
            this.lblValidLogin.Text = "Error message";
            // 
            // lblValidPassword
            // 
            this.lblValidPassword.AutoSize = true;
            this.lblValidPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValidPassword.ForeColor = System.Drawing.Color.Red;
            this.lblValidPassword.Location = new System.Drawing.Point(149, 112);
            this.lblValidPassword.Name = "lblValidPassword";
            this.lblValidPassword.Size = new System.Drawing.Size(80, 13);
            this.lblValidPassword.TabIndex = 12;
            this.lblValidPassword.Text = "Error message";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 222);
            this.Controls.Add(this.lblValidPassword);
            this.Controls.Add(this.lblValidLogin);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Name = "SignUpForm";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblValidLogin;
        private System.Windows.Forms.Label lblValidPassword;
    }
}