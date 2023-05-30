namespace biblioteca
{
    partial class F_NovoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_NovoUsuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Create = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.TextBox();
            this.RSenha = new System.Windows.Forms.TextBox();
            this.Serial = new System.Windows.Forms.TextBox();
            this.lb_nível = new System.Windows.Forms.Label();
            this.lb_senhas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.Transparent;
            this.Create.Cursor = System.Windows.Forms.Cursors.Default;
            this.Create.FlatAppearance.BorderSize = 0;
            this.Create.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Create.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(142, 346);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(97, 29);
            this.Create.TabIndex = 5;
            this.Create.Text = "Criar";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.CreateClick);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(30, 346);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 29);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Fechar";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username (Para login)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Repetir Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Serial";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(14, 167);
            this.Nome.MaxLength = 120;
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(243, 20);
            this.Nome.TabIndex = 0;
            this.Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nome_KeyPress);
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(14, 207);
            this.Username.MaxLength = 40;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(114, 21);
            this.Username.TabIndex = 1;
            // 
            // Senha
            // 
            this.Senha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(14, 272);
            this.Senha.MaxLength = 32;
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '•';
            this.Senha.Size = new System.Drawing.Size(96, 22);
            this.Senha.TabIndex = 3;
            this.Senha.TextChanged += new System.EventHandler(this.SenhaChenged);
            // 
            // RSenha
            // 
            this.RSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RSenha.Location = new System.Drawing.Point(120, 272);
            this.RSenha.MaxLength = 32;
            this.RSenha.Name = "RSenha";
            this.RSenha.PasswordChar = '•';
            this.RSenha.Size = new System.Drawing.Size(96, 22);
            this.RSenha.TabIndex = 4;
            this.RSenha.TextChanged += new System.EventHandler(this.RSenhaChenged);
            // 
            // Serial
            // 
            this.Serial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Serial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serial.Location = new System.Drawing.Point(143, 206);
            this.Serial.MaxLength = 12;
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(114, 21);
            this.Serial.TabIndex = 2;
            this.Serial.TextChanged += new System.EventHandler(this.SerialTextChenged);
            this.Serial.MouseHover += new System.EventHandler(this.Serial_MouseHover);
            // 
            // lb_nível
            // 
            this.lb_nível.AutoSize = true;
            this.lb_nível.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nível.Location = new System.Drawing.Point(146, 228);
            this.lb_nível.Name = "lb_nível";
            this.lb_nível.Size = new System.Drawing.Size(16, 15);
            this.lb_nível.TabIndex = 14;
            this.lb_nível.Text = "...";
            this.lb_nível.Visible = false;
            // 
            // lb_senhas
            // 
            this.lb_senhas.AutoSize = true;
            this.lb_senhas.Location = new System.Drawing.Point(15, 300);
            this.lb_senhas.Name = "lb_senhas";
            this.lb_senhas.Size = new System.Drawing.Size(16, 13);
            this.lb_senhas.TabIndex = 15;
            this.lb_senhas.Text = "...";
            this.lb_senhas.Visible = false;
            // 
            // F_NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(269, 407);
            this.Controls.Add(this.lb_senhas);
            this.Controls.Add(this.lb_nível);
            this.Controls.Add(this.Serial);
            this.Controls.Add(this.RSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.TextBox RSenha;
        private System.Windows.Forms.TextBox Serial;
        private System.Windows.Forms.Label lb_nível;
        private System.Windows.Forms.Label lb_senhas;
    }
}