namespace EarEchoEmporium
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.pbPass = new System.Windows.Forms.PictureBox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.cbShowPass = new System.Windows.Forms.CheckBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.lblReg);
            this.pnlLogin.Controls.Add(this.pbPass);
            this.pnlLogin.Controls.Add(this.pbUsername);
            this.pnlLogin.Controls.Add(this.cbShowPass);
            this.pnlLogin.Controls.Add(this.lblPass);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlLogin.Location = new System.Drawing.Point(387, -2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(376, 459);
            this.pnlLogin.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Bookman Old Style", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.lblLogin.Location = new System.Drawing.Point(16, 28);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(79, 29);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Login";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Bookman Old Style", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblReg.Location = new System.Drawing.Point(113, 384);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(162, 18);
            this.lblReg.TabIndex = 8;
            this.lblReg.Text = "No account? Click here";
            // 
            // pbPass
            // 
            this.pbPass.Image = ((System.Drawing.Image)(resources.GetObject("pbPass.Image")));
            this.pbPass.Location = new System.Drawing.Point(302, 239);
            this.pbPass.Name = "pbPass";
            this.pbPass.Size = new System.Drawing.Size(39, 34);
            this.pbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPass.TabIndex = 7;
            this.pbPass.TabStop = false;
            // 
            // pbUsername
            // 
            this.pbUsername.Image = ((System.Drawing.Image)(resources.GetObject("pbUsername.Image")));
            this.pbUsername.Location = new System.Drawing.Point(302, 141);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(39, 34);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsername.TabIndex = 6;
            this.pbUsername.TabStop = false;
            // 
            // cbShowPass
            // 
            this.cbShowPass.AutoSize = true;
            this.cbShowPass.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPass.Location = new System.Drawing.Point(61, 288);
            this.cbShowPass.Name = "cbShowPass";
            this.cbShowPass.Size = new System.Drawing.Size(129, 21);
            this.cbShowPass.TabIndex = 5;
            this.cbShowPass.Text = "Show Password";
            this.cbShowPass.UseVisualStyleBackColor = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.lblPass.Location = new System.Drawing.Point(43, 200);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(121, 26);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPass.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtPass.Location = new System.Drawing.Point(61, 239);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(235, 34);
            this.txtPass.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.lblUsername.Location = new System.Drawing.Point(43, 101);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(123, 26);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.txtUsername.Location = new System.Drawing.Point(61, 141);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(235, 34);
            this.txtUsername.TabIndex = 1;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.lblSlogan.Location = new System.Drawing.Point(64, 279);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(267, 52);
            this.lblSlogan.TabIndex = 3;
            this.lblSlogan.Text = "\"Echoes of clarity \r\nat EarEcho Emporium.\"";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(82, 40);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(223, 206);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.btnLogin.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnLogin.Location = new System.Drawing.Point(140, 341);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 40);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Log-in";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(762, 453);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pnlLogin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox cbShowPass;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.PictureBox pbPass;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnLogin;
    }
}

