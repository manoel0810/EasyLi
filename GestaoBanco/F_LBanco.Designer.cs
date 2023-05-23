namespace GestaoBanco
{
    partial class F_LBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_LBanco));
            this.rb_mov = new System.Windows.Forms.RadioButton();
            this.rb_tur = new System.Windows.Forms.RadioButton();
            this.rb_age = new System.Windows.Forms.RadioButton();
            this.rb_liv = new System.Windows.Forms.RadioButton();
            this.rb_log = new System.Windows.Forms.RadioButton();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.cb_dev = new System.Windows.Forms.CheckBox();
            this.cb_emp = new System.Windows.Forms.CheckBox();
            this.cb_todos = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rb_mov
            // 
            this.rb_mov.AutoSize = true;
            this.rb_mov.Location = new System.Drawing.Point(12, 21);
            this.rb_mov.Name = "rb_mov";
            this.rb_mov.Size = new System.Drawing.Size(128, 17);
            this.rb_mov.TabIndex = 0;
            this.rb_mov.TabStop = true;
            this.rb_mov.Text = "Tabela \"Movimentos\"";
            this.rb_mov.UseVisualStyleBackColor = true;
            this.rb_mov.CheckedChanged += new System.EventHandler(this.rb_mov_CheckedChanged);
            // 
            // rb_tur
            // 
            this.rb_tur.AutoSize = true;
            this.rb_tur.Location = new System.Drawing.Point(192, 57);
            this.rb_tur.Name = "rb_tur";
            this.rb_tur.Size = new System.Drawing.Size(106, 17);
            this.rb_tur.TabIndex = 1;
            this.rb_tur.TabStop = true;
            this.rb_tur.Text = "Tabela \"Turmas\"";
            this.rb_tur.UseVisualStyleBackColor = true;
            // 
            // rb_age
            // 
            this.rb_age.AutoSize = true;
            this.rb_age.Location = new System.Drawing.Point(12, 101);
            this.rb_age.Name = "rb_age";
            this.rb_age.Size = new System.Drawing.Size(108, 17);
            this.rb_age.TabIndex = 2;
            this.rb_age.TabStop = true;
            this.rb_age.Text = "Tabela \"Agenda\"";
            this.rb_age.UseVisualStyleBackColor = true;
            // 
            // rb_liv
            // 
            this.rb_liv.AutoSize = true;
            this.rb_liv.Location = new System.Drawing.Point(192, 34);
            this.rb_liv.Name = "rb_liv";
            this.rb_liv.Size = new System.Drawing.Size(110, 17);
            this.rb_liv.TabIndex = 3;
            this.rb_liv.TabStop = true;
            this.rb_liv.Text = "Tabela \"Eventos\"";
            this.rb_liv.UseVisualStyleBackColor = true;
            // 
            // rb_log
            // 
            this.rb_log.AutoSize = true;
            this.rb_log.Location = new System.Drawing.Point(12, 147);
            this.rb_log.Name = "rb_log";
            this.rb_log.Size = new System.Drawing.Size(97, 17);
            this.rb_log.TabIndex = 4;
            this.rb_log.TabStop = true;
            this.rb_log.Text = "Tabela \"Login\"";
            this.rb_log.UseVisualStyleBackColor = true;
            this.rb_log.Visible = false;
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(192, 80);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(55, 17);
            this.rb_todos.TabIndex = 5;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Método de Limpeza:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpar.Location = new System.Drawing.Point(223, 141);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 7;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voltar.Location = new System.Drawing.Point(142, 141);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 8;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // cb_dev
            // 
            this.cb_dev.AutoSize = true;
            this.cb_dev.Location = new System.Drawing.Point(38, 38);
            this.cb_dev.Name = "cb_dev";
            this.cb_dev.Size = new System.Drawing.Size(79, 17);
            this.cb_dev.TabIndex = 9;
            this.cb_dev.Text = "Devolvidos";
            this.cb_dev.UseVisualStyleBackColor = true;
            // 
            // cb_emp
            // 
            this.cb_emp.AutoSize = true;
            this.cb_emp.Location = new System.Drawing.Point(38, 58);
            this.cb_emp.Name = "cb_emp";
            this.cb_emp.Size = new System.Drawing.Size(87, 17);
            this.cb_emp.TabIndex = 10;
            this.cb_emp.Text = "Emprestados";
            this.cb_emp.UseVisualStyleBackColor = true;
            // 
            // cb_todos
            // 
            this.cb_todos.AutoSize = true;
            this.cb_todos.Location = new System.Drawing.Point(38, 79);
            this.cb_todos.Name = "cb_todos";
            this.cb_todos.Size = new System.Drawing.Size(56, 17);
            this.cb_todos.TabIndex = 11;
            this.cb_todos.Text = "Todos";
            this.cb_todos.UseVisualStyleBackColor = true;
            // 
            // F_LBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 174);
            this.Controls.Add(this.cb_todos);
            this.Controls.Add(this.cb_emp);
            this.Controls.Add(this.cb_dev);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_todos);
            this.Controls.Add(this.rb_log);
            this.Controls.Add(this.rb_liv);
            this.Controls.Add(this.rb_age);
            this.Controls.Add(this.rb_tur);
            this.Controls.Add(this.rb_mov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_LBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções de Limpeza";
            this.Load += new System.EventHandler(this.F_LBanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_mov;
        private System.Windows.Forms.RadioButton rb_tur;
        private System.Windows.Forms.RadioButton rb_age;
        private System.Windows.Forms.RadioButton rb_liv;
        private System.Windows.Forms.RadioButton rb_log;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.CheckBox cb_dev;
        private System.Windows.Forms.CheckBox cb_emp;
        private System.Windows.Forms.CheckBox cb_todos;
    }
}