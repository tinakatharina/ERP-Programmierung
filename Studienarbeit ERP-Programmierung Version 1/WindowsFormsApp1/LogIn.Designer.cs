namespace WindowsFormsApp1
{
    partial class LogIn
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPicture = new System.Windows.Forms.PictureBox();
            this.welcomeLabel1 = new System.Windows.Forms.Label();
            this.welcomeLabel2 = new System.Windows.Forms.Label();
            this.welcomeLabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DeepPink;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(455, 237);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(155, 43);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "In SAP einloggen";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_click);
            // 
            // loginPicture
            // 
            this.loginPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginPicture.Image = ((System.Drawing.Image)(resources.GetObject("loginPicture.Image")));
            this.loginPicture.Location = new System.Drawing.Point(63, 63);
            this.loginPicture.Name = "loginPicture";
            this.loginPicture.Size = new System.Drawing.Size(280, 230);
            this.loginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginPicture.TabIndex = 1;
            this.loginPicture.TabStop = false;
            // 
            // welcomeLabel1
            // 
            this.welcomeLabel1.AutoSize = true;
            this.welcomeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel1.Location = new System.Drawing.Point(418, 90);
            this.welcomeLabel1.Name = "welcomeLabel1";
            this.welcomeLabel1.Size = new System.Drawing.Size(231, 44);
            this.welcomeLabel1.TabIndex = 2;
            this.welcomeLabel1.Text = "Willkommen";
            // 
            // welcomeLabel2
            // 
            this.welcomeLabel2.AutoSize = true;
            this.welcomeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel2.Location = new System.Drawing.Point(410, 154);
            this.welcomeLabel2.Name = "welcomeLabel2";
            this.welcomeLabel2.Size = new System.Drawing.Size(239, 25);
            this.welcomeLabel2.TabIndex = 3;
            this.welcomeLabel2.Text = "bei Ihrem Buisness Objekt";
            // 
            // welcomeLabel3
            // 
            this.welcomeLabel3.AutoSize = true;
            this.welcomeLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel3.Location = new System.Drawing.Point(410, 179);
            this.welcomeLabel3.Name = "welcomeLabel3";
            this.welcomeLabel3.Size = new System.Drawing.Size(226, 25);
            this.welcomeLabel3.TabIndex = 4;
            this.welcomeLabel3.Text = "Bus Partner Employee";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(770, 365);
            this.Controls.Add(this.welcomeLabel3);
            this.Controls.Add(this.welcomeLabel2);
            this.Controls.Add(this.welcomeLabel1);
            this.Controls.Add(this.loginPicture);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus Partner Employee";
            ((System.ComponentModel.ISupportInitialize)(this.loginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox loginPicture;
        private System.Windows.Forms.Label welcomeLabel1;
        private System.Windows.Forms.Label welcomeLabel2;
        private System.Windows.Forms.Label welcomeLabel3;
    }
}

