namespace biblioteca
{
    partial class F_TabelaDevolvidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TabelaDevolvidos));
            this.dgv_livrosDevolvidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livrosDevolvidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_livrosDevolvidos
            // 
            this.dgv_livrosDevolvidos.AllowUserToAddRows = false;
            this.dgv_livrosDevolvidos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_livrosDevolvidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_livrosDevolvidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_livrosDevolvidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_livrosDevolvidos.EnableHeadersVisualStyles = false;
            this.dgv_livrosDevolvidos.Location = new System.Drawing.Point(0, 0);
            this.dgv_livrosDevolvidos.MultiSelect = false;
            this.dgv_livrosDevolvidos.Name = "dgv_livrosDevolvidos";
            this.dgv_livrosDevolvidos.ReadOnly = true;
            this.dgv_livrosDevolvidos.RowHeadersVisible = false;
            this.dgv_livrosDevolvidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_livrosDevolvidos.Size = new System.Drawing.Size(996, 556);
            this.dgv_livrosDevolvidos.TabIndex = 3;
            this.dgv_livrosDevolvidos.TabStop = false;
            // 
            // F_TabelaDevolvidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 556);
            this.Controls.Add(this.dgv_livrosDevolvidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_TabelaDevolvidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabelas - Esta tabela retorna os registros deste ano";
            this.Load += new System.EventHandler(this.F_TabelaDevolvidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livrosDevolvidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_livrosDevolvidos;
    }
}