using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_TabelaPerdidos : Form
    {
        public F_TabelaPerdidos()
        {
            InitializeComponent();
        }

        private void F_TabelaPerdidos_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matrícula', T_TURMA AS 'Turma', T_LIVRO AS 'livro', T_TOMBO AS 'Tombo', T_DATA AS 'Data', T_STATUS AS 'Status' FROM tb_dadosaluno WHERE T_STATUS='" + Globais.perdido + "' ORDER BY T_ALUNO";
            dgv_LivrosPerdidos.DataSource = Banco.DQL(vquery);
            dgv_LivrosPerdidos.Columns[0].Width = 50; //ID
            dgv_LivrosPerdidos.Columns[1].Width = 280; //ALUNO
            dgv_LivrosPerdidos.Columns[2].Width = 60; //MATRICULA
            dgv_LivrosPerdidos.Columns[3].Width = 100; //TURMA
            dgv_LivrosPerdidos.Columns[4].Width = 280; //LIVRO
            dgv_LivrosPerdidos.Columns[5].Width = 60; //TOMBO
            dgv_LivrosPerdidos.Columns[6].Width = 75; //DATA
            dgv_LivrosPerdidos.Columns[7].Width = 70; //STATUS
        }
    }
}
