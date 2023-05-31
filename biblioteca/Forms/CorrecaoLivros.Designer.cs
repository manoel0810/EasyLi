
namespace biblioteca
{
    partial class CorrecaoLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorrecaoLivros));
            this.Livros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltroTitulo = new System.Windows.Forms.TextBox();
            this.FiltroTombo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataRegistro = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tombo = new System.Windows.Forms.TextBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Autores = new System.Windows.Forms.TextBox();
            this.Publicacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ISBN10 = new System.Windows.Forms.MaskedTextBox();
            this.ISBN13 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Livros)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Livros
            // 
            this.Livros.AllowUserToAddRows = false;
            this.Livros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Livros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Livros.EnableHeadersVisualStyles = false;
            this.Livros.Location = new System.Drawing.Point(353, 12);
            this.Livros.MultiSelect = false;
            this.Livros.Name = "Livros";
            this.Livros.ReadOnly = true;
            this.Livros.RowHeadersVisible = false;
            this.Livros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Livros.Size = new System.Drawing.Size(437, 446);
            this.Livros.TabIndex = 4;
            this.Livros.TabStop = false;
            this.Livros.SelectionChanged += new System.EventHandler(this.DGVSelectionChenged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtros de busca:";
            // 
            // FiltroTitulo
            // 
            this.FiltroTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FiltroTitulo.Location = new System.Drawing.Point(12, 30);
            this.FiltroTitulo.MaxLength = 120;
            this.FiltroTitulo.Name = "FiltroTitulo";
            this.FiltroTitulo.Size = new System.Drawing.Size(204, 20);
            this.FiltroTitulo.TabIndex = 0;
            this.FiltroTitulo.TextChanged += new System.EventHandler(this.FiltroTituloTextChenged);
            // 
            // FiltroTombo
            // 
            this.FiltroTombo.Location = new System.Drawing.Point(222, 30);
            this.FiltroTombo.MaxLength = 8;
            this.FiltroTombo.Name = "FiltroTombo";
            this.FiltroTombo.Size = new System.Drawing.Size(100, 20);
            this.FiltroTombo.TabIndex = 1;
            this.FiltroTombo.TextChanged += new System.EventHandler(this.FiltroTomboTextChenged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do exemplar";
            // 
            // Titulo
            // 
            this.Titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Titulo.Location = new System.Drawing.Point(13, 30);
            this.Titulo.MaxLength = 64;
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(310, 20);
            this.Titulo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data registrada";
            // 
            // DataRegistro
            // 
            this.DataRegistro.Location = new System.Drawing.Point(13, 70);
            this.DataRegistro.Mask = "00/00/0000";
            this.DataRegistro.Name = "DataRegistro";
            this.DataRegistro.Size = new System.Drawing.Size(92, 20);
            this.DataRegistro.TabIndex = 3;
            this.DataRegistro.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Código";
            // 
            // Tombo
            // 
            this.Tombo.Location = new System.Drawing.Point(119, 70);
            this.Tombo.MaxLength = 8;
            this.Tombo.Name = "Tombo";
            this.Tombo.Size = new System.Drawing.Size(92, 20);
            this.Tombo.TabIndex = 4;
            // 
            // Salvar
            // 
            this.Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salvar.Location = new System.Drawing.Point(272, 435);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 9;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.SalvaClick);
            // 
            // Excluir
            // 
            this.Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Excluir.ForeColor = System.Drawing.Color.Maroon;
            this.Excluir.Location = new System.Drawing.Point(10, 435);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 11;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.ExcluirClick);
            // 
            // Voltar
            // 
            this.Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Voltar.Location = new System.Drawing.Point(191, 435);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 23);
            this.Voltar.TabIndex = 10;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.VoltarClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Filtrar títulos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filtrar tombos";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FiltroTitulo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.FiltroTombo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(11, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 61);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Autores);
            this.panel2.Controls.Add(this.Publicacao);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ISBN10);
            this.panel2.Controls.Add(this.ISBN13);
            this.panel2.Controls.Add(this.Titulo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.DataRegistro);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Tombo);
            this.panel2.Location = new System.Drawing.Point(11, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 193);
            this.panel2.TabIndex = 16;
            // 
            // Autores
            // 
            this.Autores.Location = new System.Drawing.Point(12, 162);
            this.Autores.MaxLength = 64;
            this.Autores.Name = "Autores";
            this.Autores.Size = new System.Drawing.Size(311, 20);
            this.Autores.TabIndex = 8;
            this.Autores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Autores_KeyPress);
            // 
            // Publicacao
            // 
            this.Publicacao.Location = new System.Drawing.Point(220, 107);
            this.Publicacao.MaxLength = 24;
            this.Publicacao.Name = "Publicacao";
            this.Publicacao.Size = new System.Drawing.Size(103, 20);
            this.Publicacao.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Autor(s)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Publicação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "ISBN10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ISBN13";
            // 
            // ISBN10
            // 
            this.ISBN10.Location = new System.Drawing.Point(119, 107);
            this.ISBN10.Mask = "999999999-9";
            this.ISBN10.Name = "ISBN10";
            this.ISBN10.Size = new System.Drawing.Size(95, 20);
            this.ISBN10.TabIndex = 6;
            // 
            // ISBN13
            // 
            this.ISBN13.Location = new System.Drawing.Point(13, 107);
            this.ISBN13.Mask = "999,999999999-9";
            this.ISBN13.Name = "ISBN13";
            this.ISBN13.Size = new System.Drawing.Size(95, 20);
            this.ISBN13.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Dados do livro";
            // 
            // CorrecaoLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 470);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Livros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CorrecaoLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerênciamento de livros";
            this.Load += new System.EventHandler(this.CorrecaoLivros_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CorrecaoLivros_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Livros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Livros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FiltroTitulo;
        private System.Windows.Forms.TextBox FiltroTombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox DataRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tombo;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox ISBN10;
        private System.Windows.Forms.MaskedTextBox ISBN13;
        private System.Windows.Forms.TextBox Autores;
        private System.Windows.Forms.TextBox Publicacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
    }
}