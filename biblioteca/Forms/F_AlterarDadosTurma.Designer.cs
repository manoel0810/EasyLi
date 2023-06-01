namespace biblioteca
{
    partial class F_AlterarDadosTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AlterarDadosTurma));
            this.Turmas = new System.Windows.Forms.DataGridView();
            this.Salvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.Turma = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Turmas)).BeginInit();
            this.SuspendLayout();
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
            this.Turmas.Size = new System.Drawing.Size(309, 149);
            this.Turmas.TabIndex = 3;
            this.Turmas.TabStop = false;
            this.Turmas.SelectionChanged += new System.EventHandler(this.TurmasSelectionChenged);
            // 
            // Salvar
            // 
            this.Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salvar.Location = new System.Drawing.Point(265, 208);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(56, 22);
            this.Salvar.TabIndex = 4;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.SalvarClick);
            // 
            // Excluir
            // 
            this.Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Excluir.Location = new System.Drawing.Point(203, 208);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(56, 22);
            this.Excluir.TabIndex = 5;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.ExcluirClick);
            // 
            // Voltar
            // 
            this.Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Voltar.Location = new System.Drawing.Point(141, 208);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(56, 22);
            this.Voltar.TabIndex = 6;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.VoltarClick);
            // 
            // Turma
            // 
            this.Turma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Turma.Location = new System.Drawing.Point(12, 184);
            this.Turma.MaxLength = 40;
            this.Turma.Name = "Turma";
            this.Turma.Size = new System.Drawing.Size(309, 20);
            this.Turma.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.Cursor = System.Windows.Forms.Cursors.No;
            this.ID.Location = new System.Drawing.Point(12, 210);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(49, 20);
            this.ID.TabIndex = 8;
            this.ID.TabStop = false;
            this.ID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome Da Turma";
            // 
            // F_AlterarDadosTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Turma);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Turmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_AlterarDadosTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turmas - Correção de dados";
            this.Load += new System.EventHandler(this.FormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_AlterarDadosTurma_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Turmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Turmas;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.TextBox Turma;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
    }
}