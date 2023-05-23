using System;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_TabelaTodos : Form
    {
        public F_TabelaTodos()
        {
            InitializeComponent();
        }

        private void F_TabelaTodos_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matrícula', T_TURMA AS 'Turma', T_LIVRO AS 'livro', T_TOMBO AS 'Tombo', T_DATA AS 'Data', T_STATUS AS 'Status' FROM tb_dadosaluno ORDER BY N_IDLIVROALUNO DESC";
            dgv_todos.DataSource = Banco.DQL(vquery);
            dgv_todos.DataSource = Banco.DQL(vquery);
            dgv_todos.Columns[0].Width = 50; //ID
            dgv_todos.Columns[1].Width = 280; //ALUNO
            dgv_todos.Columns[2].Width = 60; //MATRICULA
            dgv_todos.Columns[3].Width = 100; //TURMA
            dgv_todos.Columns[4].Width = 280; //LIVRO
            dgv_todos.Columns[5].Width = 60; //TOMBO
            dgv_todos.Columns[6].Width = 75; //DATA
            dgv_todos.Columns[7].Width = 70; //STATUS
        }
    }
}
