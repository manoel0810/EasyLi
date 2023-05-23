using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_TabelaDevolvidos : Form
    {
        public F_TabelaDevolvidos()
        {
            InitializeComponent();
        }

        private void F_TabelaDevolvidos_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matrícula', T_TURMA AS 'Turma', T_LIVRO AS 'livro', T_TOMBO AS 'Tombo', T_DATA AS 'Data', T_STATUS AS 'Status' FROM tb_dadosaluno WHERE T_DATA LIKE '" + Globais.data + "%' AND T_STATUS='" + Globais.filtrod + "' ORDER BY N_IDLIVROALUNO DESC";
            dgv_livrosDevolvidos.DataSource = Banco.DQL(vquery);
            dgv_livrosDevolvidos.Columns[0].Width = 50; //ID
            dgv_livrosDevolvidos.Columns[1].Width = 280; //ALUNO
            dgv_livrosDevolvidos.Columns[2].Width = 60; //MATRICULA
            dgv_livrosDevolvidos.Columns[3].Width = 100; //TURMA
            dgv_livrosDevolvidos.Columns[4].Width = 280; //LIVRO
            dgv_livrosDevolvidos.Columns[5].Width = 60; //TOMBO
            dgv_livrosDevolvidos.Columns[6].Width = 75; //DATA
            dgv_livrosDevolvidos.Columns[7].Width = 70; //STATUS

        }
    }
}
