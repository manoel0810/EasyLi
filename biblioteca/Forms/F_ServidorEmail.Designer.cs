namespace biblioteca
{
    partial class F_ServidorEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ServidorEmail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.LinkLabel();
            this.SaveSMTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email para SMTP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Host de acesso do smtp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(23, 29);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(344, 20);
            this.Email.TabIndex = 0;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(373, 29);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(142, 20);
            this.Host.TabIndex = 1;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(23, 67);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(56, 20);
            this.Port.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(85, 67);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(99, 20);
            this.Username.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(190, 65);
            this.Password.MaxLength = 24;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.Size = new System.Drawing.Size(99, 22);
            this.Password.TabIndex = 4;
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.LinkColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(20, 90);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(49, 13);
            this.Reset.TabIndex = 6;
            this.Reset.TabStop = true;
            this.Reset.Text = "Redefinir";
            this.Reset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResetClick);
            // 
            // SaveSMTP
            // 
            this.SaveSMTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveSMTP.Location = new System.Drawing.Point(440, 67);
            this.SaveSMTP.Name = "SaveSMTP";
            this.SaveSMTP.Size = new System.Drawing.Size(75, 23);
            this.SaveSMTP.TabIndex = 5;
            this.SaveSMTP.Text = "OK";
            this.SaveSMTP.UseVisualStyleBackColor = true;
            this.SaveSMTP.Click += new System.EventHandler(this.SaveClick);
            // 
            // F_ServidorEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 117);
            this.Controls.Add(this.SaveSMTP);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_ServidorEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações do Host";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.LinkLabel Reset;
        private System.Windows.Forms.Button SaveSMTP;
    }
}