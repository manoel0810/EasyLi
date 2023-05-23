
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
            this.dgv_livros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomef = new System.Windows.Forms.TextBox();
            this.tb_codigof = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mask_data = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_exluit = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_livros
            // 
            this.dgv_livros.AllowUserToAddRows = false;
            this.dgv_livros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_livros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_livros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_livros.EnableHeadersVisualStyles = false;
            this.dgv_livros.Location = new System.Drawing.Point(328, 12);
            this.dgv_livros.MultiSelect = false;
            this.dgv_livros.Name = "dgv_livros";
            this.dgv_livros.ReadOnly = true;
            this.dgv_livros.RowHeadersVisible = false;
            this.dgv_livros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_livros.Size = new System.Drawing.Size(437, 446);
            this.dgv_livros.TabIndex = 4;
            this.dgv_livros.TabStop = false;
            this.dgv_livros.SelectionChanged += new System.EventHandler(this.dgv_livros_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtros de busca:";
            // 
            // tb_nomef
            // 
            this.tb_nomef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_nomef.Location = new System.Drawing.Point(12, 58);
            this.tb_nomef.Name = "tb_nomef";
            this.tb_nomef.Size = new System.Drawing.Size(204, 20);
            this.tb_nomef.TabIndex = 1;
            this.tb_nomef.TextChanged += new System.EventHandler(this.tb_nomef_TextChanged);
            // 
            // tb_codigof
            // 
            this.tb_codigof.Location = new System.Drawing.Point(222, 58);
            this.tb_codigof.Name = "tb_codigof";
            this.tb_codigof.Size = new System.Drawing.Size(100, 20);
            this.tb_codigof.TabIndex = 2;
            this.tb_codigof.TextChanged += new System.EventHandler(this.tb_codigof_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do exemplar";
            // 
            // tb_nome
            // 
            this.tb_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_nome.Location = new System.Drawing.Point(12, 160);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(310, 20);
            this.tb_nome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data registrada";
            // 
            // mask_data
            // 
            this.mask_data.Location = new System.Drawing.Point(12, 211);
            this.mask_data.Mask = "00/00/0000";
            this.mask_data.Name = "mask_data";
            this.mask_data.Size = new System.Drawing.Size(100, 20);
            this.mask_data.TabIndex = 4;
            this.mask_data.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Código";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(141, 211);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(100, 20);
            this.tb_codigo.TabIndex = 5;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Location = new System.Drawing.Point(247, 435);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 6;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_exluit
            // 
            this.btn_exluit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exluit.ForeColor = System.Drawing.Color.Maroon;
            this.btn_exluit.Location = new System.Drawing.Point(166, 435);
            this.btn_exluit.Name = "btn_exluit";
            this.btn_exluit.Size = new System.Drawing.Size(75, 23);
            this.btn_exluit.TabIndex = 7;
            this.btn_exluit.Text = "Excluir";
            this.btn_exluit.UseVisualStyleBackColor = true;
            this.btn_exluit.Click += new System.EventHandler(this.btn_exluit_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Location = new System.Drawing.Point(85, 435);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 8;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Por nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Por Código";
            // 
            // CorrecaoLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 470);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_exluit);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mask_data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_codigof);
            this.Controls.Add(this.tb_nomef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_livros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CorrecaoLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corrigir/Excluir";
            this.Load += new System.EventHandler(this.CorrecaoLivros_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CorrecaoLivros_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_livros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_livros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomef;
        private System.Windows.Forms.TextBox tb_codigof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mask_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_exluit;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}