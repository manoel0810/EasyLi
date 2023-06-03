namespace biblioteca
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarRetiradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDevoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosAtrasadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corrigirRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corrigirLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosPerdidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosRegistradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarPDFEspecíficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.informaçõesDoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.alterarPladoDeFundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoBloqueadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Backup = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nota = new System.Windows.Forms.NotifyIcon(this.components);
            this.BookReg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.servidorToolStripMenuItem,
            this.gestãoBloqueadosToolStripMenuItem,
            this.controleDeUsuáriosToolStripMenuItem,
            this.Backup,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarRetiradaToolStripMenuItem,
            this.registrarDevoluçãoToolStripMenuItem,
            this.livrosAtrasadosToolStripMenuItem,
            this.BookReg});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registrarRetiradaToolStripMenuItem
            // 
            this.registrarRetiradaToolStripMenuItem.Name = "registrarRetiradaToolStripMenuItem";
            this.registrarRetiradaToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.registrarRetiradaToolStripMenuItem.Text = "Registrar retirada (Ctrl + R)";
            this.registrarRetiradaToolStripMenuItem.Click += new System.EventHandler(this.TakeoutBook);
            // 
            // registrarDevoluçãoToolStripMenuItem
            // 
            this.registrarDevoluçãoToolStripMenuItem.Name = "registrarDevoluçãoToolStripMenuItem";
            this.registrarDevoluçãoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.registrarDevoluçãoToolStripMenuItem.Text = "Registrar devolução (Ctrl + D)";
            this.registrarDevoluçãoToolStripMenuItem.Click += new System.EventHandler(this.BookIn);
            // 
            // livrosAtrasadosToolStripMenuItem
            // 
            this.livrosAtrasadosToolStripMenuItem.Name = "livrosAtrasadosToolStripMenuItem";
            this.livrosAtrasadosToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.livrosAtrasadosToolStripMenuItem.Text = "Livros Atrasados";
            this.livrosAtrasadosToolStripMenuItem.Click += new System.EventHandler(this.OutTimeBooks);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.turmasToolStripMenuItem,
            this.toolStripMenuItem2,
            this.informaçõesDoProdutoToolStripMenuItem,
            this.suporteToolStripMenuItem,
            this.toolStripMenuItem3,
            this.alterarPladoDeFundoToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corrigirRegistrosToolStripMenuItem,
            this.corrigirLivrosToolStripMenuItem});
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            // 
            // corrigirRegistrosToolStripMenuItem
            // 
            this.corrigirRegistrosToolStripMenuItem.Name = "corrigirRegistrosToolStripMenuItem";
            this.corrigirRegistrosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.corrigirRegistrosToolStripMenuItem.Text = "Corrigir Registros (Ctrl + E)";
            this.corrigirRegistrosToolStripMenuItem.Click += new System.EventHandler(this.FixRecords);
            // 
            // corrigirLivrosToolStripMenuItem
            // 
            this.corrigirLivrosToolStripMenuItem.Name = "corrigirLivrosToolStripMenuItem";
            this.corrigirLivrosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.corrigirLivrosToolStripMenuItem.Text = "Corrigir Livros";
            this.corrigirLivrosToolStripMenuItem.Click += new System.EventHandler(this.FixBooks);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSenhaToolStripMenuItem,
            this.livrosPerdidosToolStripMenuItem,
            this.livrosRegistradosToolStripMenuItem,
            this.gerarPDFEspecíficoToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.loginToolStripMenuItem.Text = "Relatórios";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Livros Emprestados";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.PendingReturnsReport);
            // 
            // livrosPerdidosToolStripMenuItem
            // 
            this.livrosPerdidosToolStripMenuItem.Name = "livrosPerdidosToolStripMenuItem";
            this.livrosPerdidosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.livrosPerdidosToolStripMenuItem.Text = "Livros Perdidos e Bloqueados";
            this.livrosPerdidosToolStripMenuItem.Click += new System.EventHandler(this.Losteport);
            // 
            // livrosRegistradosToolStripMenuItem
            // 
            this.livrosRegistradosToolStripMenuItem.Name = "livrosRegistradosToolStripMenuItem";
            this.livrosRegistradosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.livrosRegistradosToolStripMenuItem.Text = "Livros Registrados";
            this.livrosRegistradosToolStripMenuItem.Click += new System.EventHandler(this.RegistredBooksList);
            // 
            // gerarPDFEspecíficoToolStripMenuItem
            // 
            this.gerarPDFEspecíficoToolStripMenuItem.Name = "gerarPDFEspecíficoToolStripMenuItem";
            this.gerarPDFEspecíficoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.gerarPDFEspecíficoToolStripMenuItem.Text = "Gerar PDF Específico";
            this.gerarPDFEspecíficoToolStripMenuItem.Click += new System.EventHandler(this.GenerateSpecialReport);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaTurmaToolStripMenuItem,
            this.gerenciarTurmasToolStripMenuItem});
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.turmasToolStripMenuItem.Text = "Turmas";
            // 
            // novaTurmaToolStripMenuItem
            // 
            this.novaTurmaToolStripMenuItem.Name = "novaTurmaToolStripMenuItem";
            this.novaTurmaToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.novaTurmaToolStripMenuItem.Text = "Nova Turma";
            this.novaTurmaToolStripMenuItem.Click += new System.EventHandler(this.ClassCreate);
            // 
            // gerenciarTurmasToolStripMenuItem
            // 
            this.gerenciarTurmasToolStripMenuItem.Name = "gerenciarTurmasToolStripMenuItem";
            this.gerenciarTurmasToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.gerenciarTurmasToolStripMenuItem.Text = "Excluir e Editar";
            this.gerenciarTurmasToolStripMenuItem.Click += new System.EventHandler(this.ClassEdit);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // informaçõesDoProdutoToolStripMenuItem
            // 
            this.informaçõesDoProdutoToolStripMenuItem.Name = "informaçõesDoProdutoToolStripMenuItem";
            this.informaçõesDoProdutoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.informaçõesDoProdutoToolStripMenuItem.Text = "Informações do Produto";
            this.informaçõesDoProdutoToolStripMenuItem.Click += new System.EventHandler(this.ProductInformation);
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.suporteToolStripMenuItem.Text = "Suporte";
            this.suporteToolStripMenuItem.Click += new System.EventHandler(this.Support);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(200, 6);
            // 
            // alterarPladoDeFundoToolStripMenuItem
            // 
            this.alterarPladoDeFundoToolStripMenuItem.Name = "alterarPladoDeFundoToolStripMenuItem";
            this.alterarPladoDeFundoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.alterarPladoDeFundoToolStripMenuItem.Text = "Alterar Plano de Fundo";
            this.alterarPladoDeFundoToolStripMenuItem.Click += new System.EventHandler(this.BackimageChenge);
            // 
            // servidorToolStripMenuItem
            // 
            this.servidorToolStripMenuItem.Name = "servidorToolStripMenuItem";
            this.servidorToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.servidorToolStripMenuItem.Text = "Servidor";
            this.servidorToolStripMenuItem.Click += new System.EventHandler(this.SMTPService);
            // 
            // gestãoBloqueadosToolStripMenuItem
            // 
            this.gestãoBloqueadosToolStripMenuItem.Name = "gestãoBloqueadosToolStripMenuItem";
            this.gestãoBloqueadosToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestãoBloqueadosToolStripMenuItem.Text = "Gestão Bloqueados";
            this.gestãoBloqueadosToolStripMenuItem.Click += new System.EventHandler(this.BlockedUsers);
            // 
            // controleDeUsuáriosToolStripMenuItem
            // 
            this.controleDeUsuáriosToolStripMenuItem.Name = "controleDeUsuáriosToolStripMenuItem";
            this.controleDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.controleDeUsuáriosToolStripMenuItem.Text = "Controle de Usuários";
            this.controleDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.UserControl);
            // 
            // Backup
            // 
            this.Backup.Name = "Backup";
            this.Backup.Size = new System.Drawing.Size(63, 20);
            this.Backup.Text = "Backups";
            this.Backup.Click += new System.EventHandler(this.Backups);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.sairToolStripMenuItem.Text = "Sair (Ctrl + S)";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // nota
            // 
            this.nota.Icon = ((System.Drawing.Icon)(resources.GetObject("nota.Icon")));
            this.nota.Text = "Google API - Upload em andamento...";
            // 
            // BookReg
            // 
            this.BookReg.Name = "BookReg";
            this.BookReg.Size = new System.Drawing.Size(230, 22);
            this.BookReg.Text = "Registrar livros";
            this.BookReg.Click += new System.EventHandler(this.BookReg_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyLi - Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_Menu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Menu_FormClosed);
            this.Load += new System.EventHandler(this.F_Menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_Menu_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarRetiradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDevoluçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corrigirRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçõesDoProdutoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem livrosPerdidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarTurmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gerarPDFEspecíficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem alterarPladoDeFundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoBloqueadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosAtrasadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Backup;
        private System.Windows.Forms.NotifyIcon nota;
        private System.Windows.Forms.ToolStripMenuItem livrosRegistradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corrigirLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BookReg;
    }
}