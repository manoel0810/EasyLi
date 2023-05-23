namespace biblioteca
{
    partial class F_BuscarLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_BuscarLivro));
            this.dgv_buscaLivros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomeLivro = new System.Windows.Forms.TextBox();
            this.tb_tombo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_naoDevolvido = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_devolvido = new System.Windows.Forms.Button();
            this.cb_neae = new System.Windows.Forms.CheckBox();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscaLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_buscaLivros
            // 
            this.dgv_buscaLivros.AllowUserToAddRows = false;
            this.dgv_buscaLivros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buscaLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_buscaLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buscaLivros.EnableHeadersVisualStyles = false;
            this.dgv_buscaLivros.Location = new System.Drawing.Point(381, 12);
            this.dgv_buscaLivros.MultiSelect = false;
            this.dgv_buscaLivros.Name = "dgv_buscaLivros";
            this.dgv_buscaLivros.ReadOnly = true;
            this.dgv_buscaLivros.RowHeadersVisible = false;
            this.dgv_buscaLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_buscaLivros.Size = new System.Drawing.Size(757, 534);
            this.dgv_buscaLivros.TabIndex = 1;
            this.dgv_buscaLivros.TabStop = false;
            this.dgv_buscaLivros.SelectionChanged += new System.EventHandler(this.dgv_buscaLivros_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha um único campo para pesquisa. (Retorno deste ano)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tombo do Livro";
            // 
            // tb_nomeLivro
            // 
            this.tb_nomeLivro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_nomeLivro.Location = new System.Drawing.Point(15, 84);
            this.tb_nomeLivro.Name = "tb_nomeLivro";
            this.tb_nomeLivro.Size = new System.Drawing.Size(360, 20);
            this.tb_nomeLivro.TabIndex = 1;
            this.tb_nomeLivro.TextChanged += new System.EventHandler(this.tb_nomeLivro_TextChanged);
            // 
            // tb_tombo
            // 
            this.tb_tombo.Location = new System.Drawing.Point(15, 144);
            this.tb_tombo.Name = "tb_tombo";
            this.tb_tombo.Size = new System.Drawing.Size(116, 20);
            this.tb_tombo.TabIndex = 2;
            this.tb_tombo.TextChanged += new System.EventHandler(this.tb_tombo_TextChanged);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(311, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "Voltar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_naoDevolvido
            // 
            this.btn_naoDevolvido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_naoDevolvido.Location = new System.Drawing.Point(12, 524);
            this.btn_naoDevolvido.Name = "btn_naoDevolvido";
            this.btn_naoDevolvido.Size = new System.Drawing.Size(143, 23);
            this.btn_naoDevolvido.TabIndex = 5;
            this.btn_naoDevolvido.Text = "Registrar Como Perdido";
            this.btn_naoDevolvido.UseVisualStyleBackColor = true;
            this.btn_naoDevolvido.Click += new System.EventHandler(this.btn_naoDevolvido_Click);
            // 
            // tb_id
            // 
            this.tb_id.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_id.Location = new System.Drawing.Point(158, 144);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(69, 20);
            this.tb_id.TabIndex = 7;
            this.tb_id.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // btn_devolvido
            // 
            this.btn_devolvido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_devolvido.Location = new System.Drawing.Point(241, 525);
            this.btn_devolvido.Name = "btn_devolvido";
            this.btn_devolvido.Size = new System.Drawing.Size(64, 23);
            this.btn_devolvido.TabIndex = 4;
            this.btn_devolvido.Text = "Devolvido";
            this.btn_devolvido.UseVisualStyleBackColor = true;
            this.btn_devolvido.Click += new System.EventHandler(this.btn_devolvido_Click);
            // 
            // cb_neae
            // 
            this.cb_neae.AutoSize = true;
            this.cb_neae.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_neae.Location = new System.Drawing.Point(15, 208);
            this.cb_neae.Name = "cb_neae";
            this.cb_neae.Size = new System.Drawing.Size(184, 17);
            this.cb_neae.TabIndex = 9;
            this.cb_neae.Text = "Exibir não apenas \"Emprestados\"";
            this.cb_neae.UseVisualStyleBackColor = true;
            // 
            // tb_estado
            // 
            this.tb_estado.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_estado.Location = new System.Drawing.Point(260, 144);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.ReadOnly = true;
            this.tb_estado.Size = new System.Drawing.Size(100, 20);
            this.tb_estado.TabIndex = 10;
            this.tb_estado.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(171, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Notificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estado";
            // 
            // F_BuscarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 558);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_estado);
            this.Controls.Add(this.cb_neae);
            this.Controls.Add(this.btn_devolvido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_naoDevolvido);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_tombo);
            this.Controls.Add(this.tb_nomeLivro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_buscaLivros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_BuscarLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Livro";
            this.Load += new System.EventHandler(this.F_BuscarLivro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_BuscarLivro_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscaLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_buscaLivros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomeLivro;
        private System.Windows.Forms.TextBox tb_tombo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_naoDevolvido;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_devolvido;
        private System.Windows.Forms.CheckBox cb_neae;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}