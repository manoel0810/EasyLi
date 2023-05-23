namespace biblioteca
{
    partial class F_Tabela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Tabela));
            this.dgv_livrosEmprestados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livrosEmprestados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_livrosEmprestados
            // 
            this.dgv_livrosEmprestados.AllowUserToAddRows = false;
            this.dgv_livrosEmprestados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_livrosEmprestados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_livrosEmprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_livrosEmprestados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_livrosEmprestados.EnableHeadersVisualStyles = false;
            this.dgv_livrosEmprestados.Location = new System.Drawing.Point(0, 0);
            this.dgv_livrosEmprestados.MultiSelect = false;
            this.dgv_livrosEmprestados.Name = "dgv_livrosEmprestados";
            this.dgv_livrosEmprestados.ReadOnly = true;
            this.dgv_livrosEmprestados.RowHeadersVisible = false;
            this.dgv_livrosEmprestados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_livrosEmprestados.Size = new System.Drawing.Size(996, 556);
            this.dgv_livrosEmprestados.TabIndex = 2;
            this.dgv_livrosEmprestados.TabStop = false;
            // 
            // F_Tabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 556);
            this.Controls.Add(this.dgv_livrosEmprestados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Tabela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabelas";
            this.Load += new System.EventHandler(this.F_Tabela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livrosEmprestados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_livrosEmprestados;
    }
}