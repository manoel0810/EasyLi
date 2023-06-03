namespace biblioteca
{
    partial class BookCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCheckout));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeUsuario = new System.Windows.Forms.TextBox();
            this.Livro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Turma = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Matricula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tombo = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário (Ctrl + W)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Livro (Ctrl + Q)";
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NomeUsuario.Location = new System.Drawing.Point(111, 113);
            this.NomeUsuario.MaxLength = 64;
            this.NomeUsuario.Name = "NomeUsuario";
            this.NomeUsuario.Size = new System.Drawing.Size(408, 20);
            this.NomeUsuario.TabIndex = 5;
            // 
            // Livro
            // 
            this.Livro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Livro.Location = new System.Drawing.Point(111, 25);
            this.Livro.MaxLength = 64;
            this.Livro.Name = "Livro";
            this.Livro.Size = new System.Drawing.Size(409, 20);
            this.Livro.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data";
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(12, 63);
            this.Data.Mask = "00/00/0000";
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(86, 20);
            this.Data.TabIndex = 2;
            this.Data.TabStop = false;
            this.Data.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Turma";
            // 
            // Turma
            // 
            this.Turma.FormattingEnabled = true;
            this.Turma.Location = new System.Drawing.Point(360, 63);
            this.Turma.Name = "Turma";
            this.Turma.Size = new System.Drawing.Size(160, 21);
            this.Turma.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Location = new System.Drawing.Point(445, 163);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 8;
            this.Save.Text = "Salvar";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.SaveClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Matrícula";
            // 
            // Matricula
            // 
            this.Matricula.Location = new System.Drawing.Point(14, 113);
            this.Matricula.MaxLength = 8;
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(91, 20);
            this.Matricula.TabIndex = 4;
            this.Matricula.Tag = "";
            this.Matricula.Leave += new System.EventHandler(this.MatriculaLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tombo";
            // 
            // Tombo
            // 
            this.Tombo.Location = new System.Drawing.Point(12, 25);
            this.Tombo.MaxLength = 8;
            this.Tombo.Name = "Tombo";
            this.Tombo.Size = new System.Drawing.Size(94, 20);
            this.Tombo.TabIndex = 0;
            this.Tombo.Leave += new System.EventHandler(this.TomboLeave);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Location = new System.Drawing.Point(364, 163);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Voltar";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.ExitClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "E-Mail (Opicional)";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(15, 165);
            this.Email.MaxLength = 128;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(341, 20);
            this.Email.TabIndex = 6;
            // 
            // BookCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 200);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Tombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Matricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Turma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Livro);
            this.Controls.Add(this.NomeUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retirada de livro";
            this.Load += new System.EventHandler(this.FormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeUsuario;
        private System.Windows.Forms.TextBox Livro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Turma;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Matricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tombo;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Email;
    }
}