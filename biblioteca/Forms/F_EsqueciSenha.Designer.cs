namespace biblioteca
{
    partial class F_EsqueciSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_EsqueciSenha));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.TextBox();
            this.RepetirSenha = new System.Windows.Forms.TextBox();
            this.lb_Rsenha = new System.Windows.Forms.Label();
            this.Acao = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NivelBasico = new System.Windows.Forms.RadioButton();
            this.NivelAvancado = new System.Windows.Forms.RadioButton();
            this.SenhaMSG = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(7, 269);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(65, 13);
            this.lb_senha.TabIndex = 3;
            this.lb_senha.Text = "Nova senha";
            this.lb_senha.Visible = false;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(10, 188);
            this.Nome.MaxLength = 120;
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(245, 20);
            this.Nome.TabIndex = 0;
            this.Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nome_KeyPress);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(10, 227);
            this.Username.MaxLength = 40;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(97, 20);
            this.Username.TabIndex = 1;
            // 
            // Senha
            // 
            this.Senha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(10, 285);
            this.Senha.MaxLength = 32;
            this.Senha.Name = "Senha";
            this.Senha.PasswordChar = '•';
            this.Senha.Size = new System.Drawing.Size(97, 22);
            this.Senha.TabIndex = 4;
            this.Senha.Visible = false;
            this.Senha.TextChanged += new System.EventHandler(this.SenhaTextChenged);
            // 
            // RepetirSenha
            // 
            this.RepetirSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepetirSenha.Location = new System.Drawing.Point(116, 285);
            this.RepetirSenha.MaxLength = 32;
            this.RepetirSenha.Name = "RepetirSenha";
            this.RepetirSenha.PasswordChar = '•';
            this.RepetirSenha.Size = new System.Drawing.Size(97, 22);
            this.RepetirSenha.TabIndex = 5;
            this.RepetirSenha.Visible = false;
            this.RepetirSenha.TextChanged += new System.EventHandler(this.RSenhaTextChenged);
            // 
            // lb_Rsenha
            // 
            this.lb_Rsenha.AutoSize = true;
            this.lb_Rsenha.Location = new System.Drawing.Point(113, 269);
            this.lb_Rsenha.Name = "lb_Rsenha";
            this.lb_Rsenha.Size = new System.Drawing.Size(73, 13);
            this.lb_Rsenha.TabIndex = 9;
            this.lb_Rsenha.Text = "Repetir senha";
            this.lb_Rsenha.Visible = false;
            // 
            // Acao
            // 
            this.Acao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Acao.FlatAppearance.BorderSize = 0;
            this.Acao.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Acao.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Acao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acao.Location = new System.Drawing.Point(151, 350);
            this.Acao.Name = "Acao";
            this.Acao.Size = new System.Drawing.Size(84, 25);
            this.Acao.TabIndex = 6;
            this.Acao.Text = "Buscar";
            this.Acao.UseVisualStyleBackColor = true;
            this.Acao.Click += new System.EventHandler(this.AcaoClick);
            // 
            // Cancel
            // 
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(34, 350);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(84, 25);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "INFORME ALGUNS DADOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Você é:";
            // 
            // NivelBasico
            // 
            this.NivelBasico.AutoSize = true;
            this.NivelBasico.Location = new System.Drawing.Point(125, 230);
            this.NivelBasico.Name = "NivelBasico";
            this.NivelBasico.Size = new System.Drawing.Size(57, 17);
            this.NivelBasico.TabIndex = 2;
            this.NivelBasico.TabStop = true;
            this.NivelBasico.Text = "Básico";
            this.NivelBasico.UseVisualStyleBackColor = true;
            // 
            // NivelAvancado
            // 
            this.NivelAvancado.AutoSize = true;
            this.NivelAvancado.Location = new System.Drawing.Point(188, 230);
            this.NivelAvancado.Name = "NivelAvancado";
            this.NivelAvancado.Size = new System.Drawing.Size(74, 17);
            this.NivelAvancado.TabIndex = 3;
            this.NivelAvancado.TabStop = true;
            this.NivelAvancado.Text = "Avançado";
            this.NivelAvancado.UseVisualStyleBackColor = true;
            // 
            // SenhaMSG
            // 
            this.SenhaMSG.AutoSize = true;
            this.SenhaMSG.Location = new System.Drawing.Point(12, 310);
            this.SenhaMSG.Name = "SenhaMSG";
            this.SenhaMSG.Size = new System.Drawing.Size(16, 13);
            this.SenhaMSG.TabIndex = 19;
            this.SenhaMSG.Text = "...";
            this.SenhaMSG.Visible = false;
            // 
            // F_EsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(269, 407);
            this.Controls.Add(this.SenhaMSG);
            this.Controls.Add(this.NivelAvancado);
            this.Controls.Add(this.NivelBasico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Acao);
            this.Controls.Add(this.lb_Rsenha);
            this.Controls.Add(this.RepetirSenha);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_EsqueciSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar senha de acesso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.TextBox RepetirSenha;
        private System.Windows.Forms.Label lb_Rsenha;
        private System.Windows.Forms.Button Acao;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton NivelBasico;
        private System.Windows.Forms.RadioButton NivelAvancado;
        private System.Windows.Forms.Label SenhaMSG;
    }
}