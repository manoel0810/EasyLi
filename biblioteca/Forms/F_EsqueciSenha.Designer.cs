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
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_Rsenha = new System.Windows.Forms.TextBox();
            this.lb_Rsenha = new System.Windows.Forms.Label();
            this.btn_vari = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rb_basico = new System.Windows.Forms.RadioButton();
            this.rb_avancado = new System.Windows.Forms.RadioButton();
            this.lb_tipo = new System.Windows.Forms.Label();
            this.lb_senhas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(300, 163);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(65, 13);
            this.lb_senha.TabIndex = 3;
            this.lb_senha.Text = "Nova senha";
            this.lb_senha.Visible = false;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(303, 83);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(353, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(303, 124);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(127, 20);
            this.tb_username.TabIndex = 2;
            // 
            // tb_senha
            // 
            this.tb_senha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.Location = new System.Drawing.Point(303, 179);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '•';
            this.tb_senha.Size = new System.Drawing.Size(127, 22);
            this.tb_senha.TabIndex = 6;
            this.tb_senha.Visible = false;
            this.tb_senha.TextChanged += new System.EventHandler(this.tb_senha_TextChanged);
            // 
            // tb_Rsenha
            // 
            this.tb_Rsenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rsenha.Location = new System.Drawing.Point(458, 179);
            this.tb_Rsenha.Name = "tb_Rsenha";
            this.tb_Rsenha.PasswordChar = '•';
            this.tb_Rsenha.Size = new System.Drawing.Size(127, 22);
            this.tb_Rsenha.TabIndex = 7;
            this.tb_Rsenha.Visible = false;
            this.tb_Rsenha.TextChanged += new System.EventHandler(this.tb_Rsenha_TextChanged);
            // 
            // lb_Rsenha
            // 
            this.lb_Rsenha.AutoSize = true;
            this.lb_Rsenha.Location = new System.Drawing.Point(455, 163);
            this.lb_Rsenha.Name = "lb_Rsenha";
            this.lb_Rsenha.Size = new System.Drawing.Size(73, 13);
            this.lb_Rsenha.TabIndex = 9;
            this.lb_Rsenha.Text = "Repetir senha";
            this.lb_Rsenha.Visible = false;
            // 
            // btn_vari
            // 
            this.btn_vari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vari.FlatAppearance.BorderSize = 0;
            this.btn_vari.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_vari.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_vari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vari.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vari.Location = new System.Drawing.Point(474, 224);
            this.btn_vari.Name = "btn_vari";
            this.btn_vari.Size = new System.Drawing.Size(119, 25);
            this.btn_vari.TabIndex = 5;
            this.btn_vari.Text = "Buscar";
            this.btn_vari.UseVisualStyleBackColor = true;
            this.btn_vari.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(357, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "INFORME ALGUNS DADOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Você é:";
            // 
            // rb_basico
            // 
            this.rb_basico.AutoSize = true;
            this.rb_basico.Location = new System.Drawing.Point(488, 124);
            this.rb_basico.Name = "rb_basico";
            this.rb_basico.Size = new System.Drawing.Size(57, 17);
            this.rb_basico.TabIndex = 3;
            this.rb_basico.TabStop = true;
            this.rb_basico.Text = "Básico";
            this.rb_basico.UseVisualStyleBackColor = true;
            this.rb_basico.CheckedChanged += new System.EventHandler(this.rb_basico_CheckedChanged);
            // 
            // rb_avancado
            // 
            this.rb_avancado.AutoSize = true;
            this.rb_avancado.Location = new System.Drawing.Point(551, 124);
            this.rb_avancado.Name = "rb_avancado";
            this.rb_avancado.Size = new System.Drawing.Size(74, 17);
            this.rb_avancado.TabIndex = 4;
            this.rb_avancado.TabStop = true;
            this.rb_avancado.Text = "Avançado";
            this.rb_avancado.UseVisualStyleBackColor = true;
            this.rb_avancado.CheckedChanged += new System.EventHandler(this.rb_avancado_CheckedChanged);
            // 
            // lb_tipo
            // 
            this.lb_tipo.AutoSize = true;
            this.lb_tipo.Location = new System.Drawing.Point(535, 108);
            this.lb_tipo.Name = "lb_tipo";
            this.lb_tipo.Size = new System.Drawing.Size(16, 13);
            this.lb_tipo.TabIndex = 18;
            this.lb_tipo.Text = "...";
            this.lb_tipo.Visible = false;
            // 
            // lb_senhas
            // 
            this.lb_senhas.AutoSize = true;
            this.lb_senhas.Location = new System.Drawing.Point(300, 204);
            this.lb_senhas.Name = "lb_senhas";
            this.lb_senhas.Size = new System.Drawing.Size(16, 13);
            this.lb_senhas.TabIndex = 19;
            this.lb_senhas.Text = "...";
            this.lb_senhas.Visible = false;
            // 
            // F_EsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 282);
            this.Controls.Add(this.lb_senhas);
            this.Controls.Add(this.lb_tipo);
            this.Controls.Add(this.rb_avancado);
            this.Controls.Add(this.rb_basico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_vari);
            this.Controls.Add(this.lb_Rsenha);
            this.Controls.Add(this.tb_Rsenha);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_nome);
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
            this.Text = "Recuperar Senha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_Rsenha;
        private System.Windows.Forms.Label lb_Rsenha;
        private System.Windows.Forms.Button btn_vari;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb_basico;
        private System.Windows.Forms.RadioButton rb_avancado;
        private System.Windows.Forms.Label lb_tipo;
        private System.Windows.Forms.Label lb_senhas;
    }
}