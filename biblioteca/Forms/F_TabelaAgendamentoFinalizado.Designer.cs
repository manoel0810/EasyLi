namespace biblioteca
{
    partial class F_TabelaAgendamentoFinalizado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TabelaAgendamentoFinalizado));
            this.dgv_eventosFinalizados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eventosFinalizados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_eventosFinalizados
            // 
            this.dgv_eventosFinalizados.AllowUserToAddRows = false;
            this.dgv_eventosFinalizados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_eventosFinalizados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_eventosFinalizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_eventosFinalizados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_eventosFinalizados.EnableHeadersVisualStyles = false;
            this.dgv_eventosFinalizados.Location = new System.Drawing.Point(0, 0);
            this.dgv_eventosFinalizados.MultiSelect = false;
            this.dgv_eventosFinalizados.Name = "dgv_eventosFinalizados";
            this.dgv_eventosFinalizados.ReadOnly = true;
            this.dgv_eventosFinalizados.RowHeadersVisible = false;
            this.dgv_eventosFinalizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_eventosFinalizados.Size = new System.Drawing.Size(970, 577);
            this.dgv_eventosFinalizados.TabIndex = 4;
            this.dgv_eventosFinalizados.TabStop = false;
            // 
            // F_TabelaAgendamentoFinalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 577);
            this.Controls.Add(this.dgv_eventosFinalizados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_TabelaAgendamentoFinalizado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamentos Finalizados";
            this.Load += new System.EventHandler(this.F_TabelaAgendamentoFinalizado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_eventosFinalizados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_eventosFinalizados;
    }
}