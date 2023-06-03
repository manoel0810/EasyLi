namespace biblioteca.Forms
{
    partial class BookRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookRegister));
            this.Titulo = new System.Windows.Forms.TextBox();
            this.Tombo = new System.Windows.Forms.TextBox();
            this.Autor = new System.Windows.Forms.TextBox();
            this.Publicacao = new System.Windows.Forms.TextBox();
            this.ISBN13 = new System.Windows.Forms.MaskedTextBox();
            this.ISBN10 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cover = new System.Windows.Forms.PictureBox();
            this.Salvar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.Dados = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).BeginInit();
            this.Dados.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Titulo.Location = new System.Drawing.Point(15, 26);
            this.Titulo.MaxLength = 64;
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(314, 20);
            this.Titulo.TabIndex = 0;
            // 
            // Tombo
            // 
            this.Tombo.Location = new System.Drawing.Point(367, 26);
            this.Tombo.MaxLength = 16;
            this.Tombo.Name = "Tombo";
            this.Tombo.Size = new System.Drawing.Size(68, 20);
            this.Tombo.TabIndex = 1;
            // 
            // Autor
            // 
            this.Autor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Autor.Location = new System.Drawing.Point(15, 63);
            this.Autor.MaxLength = 64;
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(314, 20);
            this.Autor.TabIndex = 2;
            // 
            // Publicacao
            // 
            this.Publicacao.Location = new System.Drawing.Point(335, 63);
            this.Publicacao.MaxLength = 24;
            this.Publicacao.Name = "Publicacao";
            this.Publicacao.Size = new System.Drawing.Size(100, 20);
            this.Publicacao.TabIndex = 3;
            // 
            // ISBN13
            // 
            this.ISBN13.Location = new System.Drawing.Point(15, 113);
            this.ISBN13.Mask = "999,999999999-9";
            this.ISBN13.Name = "ISBN13";
            this.ISBN13.Size = new System.Drawing.Size(100, 20);
            this.ISBN13.TabIndex = 4;
            // 
            // ISBN10
            // 
            this.ISBN10.Location = new System.Drawing.Point(121, 113);
            this.ISBN10.Mask = "999999999-9";
            this.ISBN10.Name = "ISBN10";
            this.ISBN10.Size = new System.Drawing.Size(100, 20);
            this.ISBN10.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Título*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tombo*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor(es)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Publicação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ISBN-13";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "ISBN-10";
            // 
            // Cover
            // 
            this.Cover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cover.Location = new System.Drawing.Point(466, 10);
            this.Cover.Name = "Cover";
            this.Cover.Size = new System.Drawing.Size(95, 139);
            this.Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cover.TabIndex = 3;
            this.Cover.TabStop = false;
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(360, 110);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 6;
            this.Salvar.Text = "Registrar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Buscar
            // 
            this.Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Buscar.Location = new System.Drawing.Point(279, 110);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 7;
            this.Buscar.Text = "Pesquisar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Dados
            // 
            this.Dados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dados.Controls.Add(this.Titulo);
            this.Dados.Controls.Add(this.Buscar);
            this.Dados.Controls.Add(this.Tombo);
            this.Dados.Controls.Add(this.Salvar);
            this.Dados.Controls.Add(this.Autor);
            this.Dados.Controls.Add(this.Publicacao);
            this.Dados.Controls.Add(this.label7);
            this.Dados.Controls.Add(this.ISBN13);
            this.Dados.Controls.Add(this.label6);
            this.Dados.Controls.Add(this.ISBN10);
            this.Dados.Controls.Add(this.label4);
            this.Dados.Controls.Add(this.label1);
            this.Dados.Controls.Add(this.label3);
            this.Dados.Controls.Add(this.label2);
            this.Dados.Location = new System.Drawing.Point(14, 10);
            this.Dados.Name = "Dados";
            this.Dados.Size = new System.Drawing.Size(440, 139);
            this.Dados.TabIndex = 8;
            // 
            // BookRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 159);
            this.Controls.Add(this.Dados);
            this.Controls.Add(this.Cover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BookRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar livros";
            this.Load += new System.EventHandler(this.BookRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cover)).EndInit();
            this.Dados.ResumeLayout(false);
            this.Dados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.TextBox Tombo;
        private System.Windows.Forms.TextBox Autor;
        private System.Windows.Forms.TextBox Publicacao;
        private System.Windows.Forms.MaskedTextBox ISBN13;
        private System.Windows.Forms.MaskedTextBox ISBN10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Cover;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Panel Dados;
    }
}