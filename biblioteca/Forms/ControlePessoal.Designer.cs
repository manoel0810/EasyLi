namespace biblioteca
{
    partial class ControlePessoal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlePessoal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AlterarSenha = new System.Windows.Forms.CheckBox();
            this.DelteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.lb_tipo = new System.Windows.Forms.Label();
            this.SaveUser = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SenhaAtual = new System.Windows.Forms.TextBox();
            this.PainelSenhas = new System.Windows.Forms.Panel();
            this.RepetirNovaSenha = new System.Windows.Forms.TextBox();
            this.NovaSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PainelSenhas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(268, 273);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AlterarSenha);
            this.tabPage1.Controls.Add(this.DelteButton);
            this.tabPage1.Controls.Add(this.ExitButton);
            this.tabPage1.Controls.Add(this.lb_tipo);
            this.tabPage1.Controls.Add(this.SaveUser);
            this.tabPage1.Controls.Add(this.Username);
            this.tabPage1.Controls.Add(this.Nome);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.SenhaAtual);
            this.tabPage1.Controls.Add(this.PainelSenhas);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(260, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Meu Usuário";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AlterarSenha
            // 
            this.AlterarSenha.AutoSize = true;
            this.AlterarSenha.Location = new System.Drawing.Point(10, 123);
            this.AlterarSenha.Name = "AlterarSenha";
            this.AlterarSenha.Size = new System.Drawing.Size(155, 18);
            this.AlterarSenha.TabIndex = 3;
            this.AlterarSenha.Text = "Alterar a senha do usuário";
            this.AlterarSenha.UseVisualStyleBackColor = true;
            this.AlterarSenha.CheckedChanged += new System.EventHandler(this.AlterarSenha_CheckedChanged);
            // 
            // DelteButton
            // 
            this.DelteButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DelteButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelteButton.ForeColor = System.Drawing.Color.Maroon;
            this.DelteButton.Location = new System.Drawing.Point(9, 216);
            this.DelteButton.Name = "DelteButton";
            this.DelteButton.Size = new System.Drawing.Size(63, 22);
            this.DelteButton.TabIndex = 8;
            this.DelteButton.Text = "Excluir";
            this.DelteButton.UseVisualStyleBackColor = true;
            this.DelteButton.Click += new System.EventHandler(this.DeleteClick);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(120, 216);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(63, 22);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Voltar";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitClick);
            // 
            // lb_tipo
            // 
            this.lb_tipo.AutoSize = true;
            this.lb_tipo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tipo.Location = new System.Drawing.Point(196, 87);
            this.lb_tipo.Name = "lb_tipo";
            this.lb_tipo.Size = new System.Drawing.Size(16, 15);
            this.lb_tipo.TabIndex = 8;
            this.lb_tipo.Text = "...";
            // 
            // SaveUser
            // 
            this.SaveUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveUser.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveUser.Location = new System.Drawing.Point(189, 216);
            this.SaveUser.Name = "SaveUser";
            this.SaveUser.Size = new System.Drawing.Size(63, 22);
            this.SaveUser.TabIndex = 6;
            this.SaveUser.Text = "Aplicar";
            this.SaveUser.UseVisualStyleBackColor = true;
            this.SaveUser.Click += new System.EventHandler(this.SaveClick);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(9, 66);
            this.Username.MaxLength = 40;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(86, 20);
            this.Username.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(9, 27);
            this.Nome.MaxLength = 120;
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(243, 20);
            this.Nome.TabIndex = 0;
            this.Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nome_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "PRIVILÉGIO:";
            // 
            // SenhaAtual
            // 
            this.SenhaAtual.BackColor = System.Drawing.SystemColors.Control;
            this.SenhaAtual.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenhaAtual.Location = new System.Drawing.Point(133, 66);
            this.SenhaAtual.MaxLength = 32;
            this.SenhaAtual.Name = "SenhaAtual";
            this.SenhaAtual.PasswordChar = '•';
            this.SenhaAtual.Size = new System.Drawing.Size(119, 20);
            this.SenhaAtual.TabIndex = 2;
            this.SenhaAtual.MouseHover += new System.EventHandler(this.SenhaAtual_MouseHover);
            // 
            // PainelSenhas
            // 
            this.PainelSenhas.BackColor = System.Drawing.Color.White;
            this.PainelSenhas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PainelSenhas.Controls.Add(this.RepetirNovaSenha);
            this.PainelSenhas.Controls.Add(this.NovaSenha);
            this.PainelSenhas.Controls.Add(this.label8);
            this.PainelSenhas.Controls.Add(this.label9);
            this.PainelSenhas.Enabled = false;
            this.PainelSenhas.Location = new System.Drawing.Point(9, 141);
            this.PainelSenhas.Name = "PainelSenhas";
            this.PainelSenhas.Size = new System.Drawing.Size(243, 57);
            this.PainelSenhas.TabIndex = 3;
            // 
            // RepetirNovaSenha
            // 
            this.RepetirNovaSenha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepetirNovaSenha.Location = new System.Drawing.Point(126, 24);
            this.RepetirNovaSenha.MaxLength = 32;
            this.RepetirNovaSenha.Name = "RepetirNovaSenha";
            this.RepetirNovaSenha.PasswordChar = '•';
            this.RepetirNovaSenha.Size = new System.Drawing.Size(99, 20);
            this.RepetirNovaSenha.TabIndex = 5;
            // 
            // NovaSenha
            // 
            this.NovaSenha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovaSenha.Location = new System.Drawing.Point(21, 24);
            this.NovaSenha.MaxLength = 32;
            this.NovaSenha.Name = "NovaSenha";
            this.NovaSenha.PasswordChar = '•';
            this.NovaSenha.Size = new System.Drawing.Size(99, 20);
            this.NovaSenha.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 5;
            this.label8.Text = "NOVA SENHA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 14);
            this.label9.TabIndex = 6;
            this.label9.Text = "REPETIR SENHA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "ALTERAR NOME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "ALTERAR USER:";
            // 
            // F_ControleUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 273);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_ControleUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle do usuário";
            this.Load += new System.EventHandler(this.F_ControleUsuarios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.PainelSenhas.ResumeLayout(false);
            this.PainelSenhas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lb_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SenhaAtual;
        private System.Windows.Forms.Panel PainelSenhas;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveUser;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox RepetirNovaSenha;
        private System.Windows.Forms.TextBox NovaSenha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DelteButton;
        private System.Windows.Forms.CheckBox AlterarSenha;
    }
}