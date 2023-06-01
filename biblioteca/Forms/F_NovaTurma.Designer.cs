namespace biblioteca
{
    partial class F_NovaTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_NovaTurma));
            this.Turma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.Turmas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // Turma
            // 
            this.Turma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Turma.Location = new System.Drawing.Point(12, 195);
            this.Turma.MaxLength = 40;
            this.Turma.Name = "Turma";
            this.Turma.Size = new System.Drawing.Size(263, 20);
            this.Turma.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME DA NOVA TURMA";
            // 
            // Adicionar
            // 
            this.Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adicionar.Location = new System.Drawing.Point(200, 221);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Adicionar.TabIndex = 1;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.AdicionarClick);
            // 
            // Voltar
            // 
            this.Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Voltar.Location = new System.Drawing.Point(122, 221);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(72, 23);
            this.Voltar.TabIndex = 2;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.VoltarClick);
            // 
            // Turmas
            // 
            this.Turmas.AllowUserToAddRows = false;
            this.Turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Turmas.EnableHeadersVisualStyles = false;
            this.Turmas.Location = new System.Drawing.Point(12, 12);
            this.Turmas.MultiSelect = false;
            this.Turmas.Name = "Turmas";
            this.Turmas.ReadOnly = true;
            this.Turmas.RowHeadersVisible = false;
            this.Turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Turmas.Size = new System.Drawing.Size(263, 152);
            this.Turmas.TabIndex = 4;
            this.Turmas.TabStop = false;
            // 
            // F_NovaTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.Turmas);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Turma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_NovaTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turmas - Criar novas turmas";
            this.Load += new System.EventHandler(this.FormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Turmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Turma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.DataGridView Turmas;
    }
}