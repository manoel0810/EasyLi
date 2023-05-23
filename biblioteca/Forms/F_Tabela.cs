using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_Tabela : Form
    {
        public F_Tabela()
        {
            InitializeComponent();
        }

        private void F_Tabela_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matrícula', T_TURMA AS 'Turma', T_LIVRO AS 'livro', T_TOMBO AS 'Tombo', T_DATA AS 'Data', T_STATUS AS 'Status' FROM tb_dadosaluno WHERE T_STATUS='" + Global.BookStatus.Emprestado + "' ORDER BY T_TURMA, T_ALUNO";
            dgv_livrosEmprestados.DataSource = DatabaseController.DQL(vquery);
            dgv_livrosEmprestados.Columns[0].Width = 50; //ID
            dgv_livrosEmprestados.Columns[1].Width = 280; //ALUNO
            dgv_livrosEmprestados.Columns[2].Width = 60; //MATRICULA
            dgv_livrosEmprestados.Columns[3].Width = 100; //TURMA
            dgv_livrosEmprestados.Columns[4].Width = 280; //LIVRO
            dgv_livrosEmprestados.Columns[5].Width = 60; //TOMBO
            dgv_livrosEmprestados.Columns[6].Width = 75; //DATA
            dgv_livrosEmprestados.Columns[7].Width = 70; //STATUS
        }
    }
}
