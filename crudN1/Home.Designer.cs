namespace crudN1
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
            this.boxUser = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.Label();
            this.boxUserPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxUser
            // 
            this.boxUser.Location = new System.Drawing.Point(234, 55);
            this.boxUser.Name = "boxUser";
            this.boxUser.Size = new System.Drawing.Size(165, 26);
            this.boxUser.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Location = new System.Drawing.Point(82, 55);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(83, 20);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Username";
            // 
            // txtPass
            // 
            this.txtPass.AutoSize = true;
            this.txtPass.Location = new System.Drawing.Point(82, 160);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(78, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.Text = "Password";
            // 
            // boxUserPass
            // 
            this.boxUserPass.Location = new System.Drawing.Point(234, 154);
            this.boxUserPass.Name = "boxUserPass";
            this.boxUserPass.Size = new System.Drawing.Size(165, 26);
            this.boxUserPass.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(234, 263);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 31);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 365);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.boxUserPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.boxUser);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxUser;
        private System.Windows.Forms.Label txtUser;
        private System.Windows.Forms.Label txtPass;
        private System.Windows.Forms.TextBox boxUserPass;
        private System.Windows.Forms.Button btnLogin;
    }
}