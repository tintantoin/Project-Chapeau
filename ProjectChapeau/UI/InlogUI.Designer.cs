namespace UI
{
    partial class InlogUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InlogUI));
            this.picChapeauLogIn = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.pnlPopUpInlog = new System.Windows.Forms.Panel();
            this.lblPopUpInlog = new System.Windows.Forms.Label();
            this.btnInvalidNameOrPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picChapeauLogIn)).BeginInit();
            this.pnlPopUpInlog.SuspendLayout();
            this.SuspendLayout();
            // 
            // picChapeauLogIn
            // 
            this.picChapeauLogIn.Image = ((System.Drawing.Image)(resources.GetObject("picChapeauLogIn.Image")));
            this.picChapeauLogIn.Location = new System.Drawing.Point(172, 33);
            this.picChapeauLogIn.Name = "picChapeauLogIn";
            this.picChapeauLogIn.Size = new System.Drawing.Size(173, 110);
            this.picChapeauLogIn.TabIndex = 0;
            this.picChapeauLogIn.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(82, 298);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(82, 266);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "USERNAME:";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(190, 259);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(125, 27);
            this.txtboxUsername.TabIndex = 3;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(190, 295);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.Size = new System.Drawing.Size(125, 27);
            this.txtboxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(198, 361);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Location = new System.Drawing.Point(190, 407);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(120, 20);
            this.lblForgotPassword.TabIndex = 6;
            this.lblForgotPassword.Text = "Forgot password";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // pnlPopUpInlog
            // 
            this.pnlPopUpInlog.Controls.Add(this.lblPopUpInlog);
            this.pnlPopUpInlog.Controls.Add(this.btnInvalidNameOrPass);
            this.pnlPopUpInlog.Location = new System.Drawing.Point(12, 12);
            this.pnlPopUpInlog.Name = "pnlPopUpInlog";
            this.pnlPopUpInlog.Size = new System.Drawing.Size(530, 631);
            this.pnlPopUpInlog.TabIndex = 7;
            // 
            // lblPopUpInlog
            // 
            this.lblPopUpInlog.AutoSize = true;
            this.lblPopUpInlog.Location = new System.Drawing.Point(224, 290);
            this.lblPopUpInlog.Name = "lblPopUpInlog";
            this.lblPopUpInlog.Size = new System.Drawing.Size(18, 20);
            this.lblPopUpInlog.TabIndex = 1;
            this.lblPopUpInlog.Text = "...";
            // 
            // btnInvalidNameOrPass
            // 
            this.btnInvalidNameOrPass.Location = new System.Drawing.Point(186, 376);
            this.btnInvalidNameOrPass.Name = "btnInvalidNameOrPass";
            this.btnInvalidNameOrPass.Size = new System.Drawing.Size(94, 59);
            this.btnInvalidNameOrPass.TabIndex = 0;
            this.btnInvalidNameOrPass.Text = "Oke";
            this.btnInvalidNameOrPass.UseVisualStyleBackColor = true;
            this.btnInvalidNameOrPass.Click += new System.EventHandler(this.btnInvalidNameOrPass_Click);
            // 
            // InlogUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 692);
            this.Controls.Add(this.pnlPopUpInlog);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.picChapeauLogIn);
            this.Name = "InlogUI";
            this.Text = "InlogUI";
            ((System.ComponentModel.ISupportInitialize)(this.picChapeauLogIn)).EndInit();
            this.pnlPopUpInlog.ResumeLayout(false);
            this.pnlPopUpInlog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picChapeauLogIn;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtboxUsername;
        private TextBox txtboxPassword;
        private Button btnLogin;
        private Label lblForgotPassword;
        private Panel pnlPopUpInlog;
        private Label lblPopUpInlog;
        private Button btnInvalidNameOrPass;
    }
}