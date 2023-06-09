namespace biblioteca.Forms
{
    partial class UserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl));
            this.Usuarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltroNome = new System.Windows.Forms.TextBox();
            this.FiltroMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Matricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Salvar = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.StatusChenge = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Usuarios
            // 
            this.Usuarios.AllowUserToAddRows = false;
            this.Usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Usuarios.EnableHeadersVisualStyles = false;
            this.Usuarios.Location = new System.Drawing.Point(356, 12);
            this.Usuarios.MultiSelect = false;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.ReadOnly = true;
            this.Usuarios.RowHeadersVisible = false;
            this.Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Usuarios.Size = new System.Drawing.Size(355, 306);
            this.Usuarios.TabIndex = 24;
            this.Usuarios.TabStop = false;
            this.Usuarios.SelectionChanged += new System.EventHandler(this.Usuarios_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FiltroMatricula);
            this.panel1.Controls.Add(this.FiltroNome);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 62);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.StatusChenge);
            this.panel2.Controls.Add(this.Excluir);
            this.panel2.Controls.Add(this.Voltar);
            this.panel2.Controls.Add(this.Salvar);
            this.panel2.Controls.Add(this.Status);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Matricula);
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.Nome);
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 234);
            this.panel2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Filtros de busca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Dados do usuário";
            // 
            // FiltroNome
            // 
            this.FiltroNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FiltroNome.Location = new System.Drawing.Point(9, 29);
            this.FiltroNome.MaxLength = 24;
            this.FiltroNome.Name = "FiltroNome";
            this.FiltroNome.Size = new System.Drawing.Size(219, 20);
            this.FiltroNome.TabIndex = 0;
            this.FiltroNome.TextChanged += new System.EventHandler(this.FiltroNome_TextChanged);
            // 
            // FiltroMatricula
            // 
            this.FiltroMatricula.Location = new System.Drawing.Point(234, 29);
            this.FiltroMatricula.MaxLength = 8;
            this.FiltroMatricula.Name = "FiltroMatricula";
            this.FiltroMatricula.Size = new System.Drawing.Size(86, 20);
            this.FiltroMatricula.TabIndex = 1;
            this.FiltroMatricula.TextChanged += new System.EventHandler(this.FiltroMatricula_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " Nomes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Matrículas";
            // 
            // Nome
            // 
            this.Nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Nome.Location = new System.Drawing.Point(10, 31);
            this.Nome.MaxLength = 64;
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(307, 20);
            this.Nome.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(10, 75);
            this.Email.MaxLength = 128;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(215, 20);
            this.Email.TabIndex = 3;
            // 
            // Matricula
            // 
            this.Matricula.Location = new System.Drawing.Point(231, 75);
            this.Matricula.MaxLength = 8;
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Size = new System.Drawing.Size(86, 20);
            this.Matricula.TabIndex = 4;
            this.Matricula.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nome completo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Matrícula";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "STATUS DO USUÁRIO:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(132, 112);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(62, 13);
            this.Status.TabIndex = 5;
            this.Status.Text = "<STATUS>";
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(244, 205);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 5;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(163, 205);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 6;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Excluir
            // 
            this.Excluir.ForeColor = System.Drawing.Color.Maroon;
            this.Excluir.Location = new System.Drawing.Point(8, 205);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 7;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // StatusChenge
            // 
            this.StatusChenge.AutoSize = true;
            this.StatusChenge.Location = new System.Drawing.Point(19, 128);
            this.StatusChenge.Name = "StatusChenge";
            this.StatusChenge.Size = new System.Drawing.Size(133, 17);
            this.StatusChenge.TabIndex = 8;
            this.StatusChenge.Text = "Desbloquear/Bloquear";
            this.StatusChenge.UseVisualStyleBackColor = true;
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Usuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de usuários";
            this.Load += new System.EventHandler(this.UserControl_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserControl_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Usuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FiltroMatricula;
        private System.Windows.Forms.TextBox FiltroNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Matricula;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.CheckBox StatusChenge;
    }
}