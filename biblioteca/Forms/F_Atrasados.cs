using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_Atrasados : Form
    {
        public F_Atrasados()
        {
            InitializeComponent();
        }

        DateTime Hoje = DateTime.Today;
        private static string id = string.Empty;

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormatarDGV()
        {
            dgv_atrasados.Columns[0].Width = 60;    //ID
            dgv_atrasados.Columns[1].Width = 280;   //Aluno
            dgv_atrasados.Columns[2].Width = 80;    //Matrícula
            dgv_atrasados.Columns[3].Width = 100;   //Turma
            dgv_atrasados.Columns[4].Width = 280;   //Livro
            dgv_atrasados.Columns[5].Width = 80;    //Data
        }

        private void F_Atrasados_Load(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Today;
            DateTime dataS8 = hoje.AddDays(-8);
            string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matricula', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_DATA AS 'Data' FROM tb_dadosaluno WHERE T_DATA < '" + MGlobais.FormatarDataSQL(dataS8.ToShortDateString()) + "' AND T_STATUS = 'Emprestado' ORDER BY T_DATA";
            dgv_atrasados.DataSource = Banco.DQL(vquery);
            FormatarDGV();

            lb_modo.Text = "Modo: Mais de 8(oito) dias";
            lb_modo.ForeColor = Color.DarkGreen;
            lb_modo.Refresh();

            this.KeyPreview = true;
        }

        private void dgv_atrasados_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                lb_nome.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                DateTime registro = DateTime.Parse(dgv.CurrentRow.Cells[5].Value.ToString());
                TimeSpan ts = Hoje.Subtract(registro);
                lb_dias.Text = ts.TotalDays.ToString();
                id = dgv_atrasados.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void cb_tempo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tempo.SelectedIndex == 0)
            {
                DateTime hoje = DateTime.Today;
                DateTime dataS8 = hoje.AddDays(-8);

                string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matricula', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_DATA AS 'Data' FROM tb_dadosaluno WHERE T_DATA < '" + MGlobais.FormatarDataSQL(dataS8.ToShortDateString()) + "' AND T_STATUS = 'Emprestado' ORDER BY T_DATA";
                dgv_atrasados.DataSource = Banco.DQL(vquery);
                FormatarDGV();

                lb_modo.Text = "Modo: Mais de 8(oito) dias";
                lb_modo.ForeColor = Color.DarkGreen;
                lb_modo.Refresh();
            }

            if (cb_tempo.SelectedIndex == 1)
            {
                DateTime hoje = DateTime.Today;
                DateTime dataS15 = hoje.AddDays(-15);

                string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matricula', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_DATA AS 'Data' FROM tb_dadosaluno WHERE T_DATA < '" + MGlobais.FormatarDataSQL(dataS15.ToShortDateString()) + "' AND T_STATUS = 'Emprestado' ORDER BY T_DATA";
                dgv_atrasados.DataSource = Banco.DQL(vquery);
                FormatarDGV();

                lb_modo.Text = "Modo: Mais de 15(quinze) dias";
                lb_modo.ForeColor = Color.DarkGreen;
                lb_modo.Refresh();
            }

            if (cb_tempo.SelectedIndex == -1)
            {
                return;
            }
        }

        private void btn_GLista_Click(object sender, EventArgs e)
        {
            string vquery = string.Empty;
            DataTable Resultado = new DataTable();

            if (dgv_atrasados.Rows.Count <= 0)
            {
                return;
            }

            if (cb_tempo.SelectedIndex == -1) //Nenhum item selecionado
            {
                MessageBox.Show("Informe o intervalo de tempo para gerar o PDF", "Informação Requisitada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cb_tempo.SelectedIndex == 0) // Intervalo maior que oito dias
            {
                DateTime hoje = DateTime.Today;
                DateTime dataS8 = hoje.AddDays(-8);
                vquery = "SELECT T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro', T_TURMA AS 'Turma', T_DATA AS 'Data' FROM tb_dadosaluno WHERE T_DATA < '" + MGlobais.FormatarDataSQL(dataS8.ToShortDateString()) + "' AND T_STATUS = 'Emprestado' ORDER BY T_ALUNO, T_TURMA";
                Resultado = Banco.DQL(vquery);
                GerarPDF.CriarPDF(Resultado, "Livros Atrasados (8 dias).pdf", "Atrasados (8 >= Dias)");
                return;
            }

            if (cb_tempo.SelectedIndex == 1) // Intervalo maior que quinze dias
            {
                DateTime hoje = DateTime.Today;
                DateTime dataS15 = hoje.AddDays(-15);
                vquery = "SELECT T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro', T_TURMA AS 'Turma', T_DATA AS 'Data' FROM tb_dadosaluno WHERE T_DATA < '" + MGlobais.FormatarDataSQL(dataS15.ToShortDateString()) + "' AND T_STATUS = 'Emprestado' ORDER BY T_ALUNO, T_TURMA";
                Resultado = Banco.DQL(vquery);
                GerarPDF.CriarPDF(Resultado, "Livros Atrasados (15 dias).pdf", "Atrasados (15 >= Dias)");
                return;
            }
        }

        private void F_Atrasados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn_renovar_Click(object sender, EventArgs e)
        {
            if (dgv_atrasados.SelectedRows.Count == 0)
            {
                return;
            }
            string mensagem = string.Empty;
            DateTime hoje = DateTime.Today.AddDays(8);
            DateTime hojeOrig = DateTime.Today;
            mensagem = String.Format("Deseja realmente renovar o registro?\n\nO Livro {0} vinculado à matrícula {1} será renovado.\n\nA nova data de entrega será: {2}", dgv_atrasados.SelectedRows[0].Cells[4].Value.ToString(), dgv_atrasados.SelectedRows[0].Cells[2].Value.ToString(), hoje.ToShortDateString());
            if (DialogResult.Yes == MessageBox.Show(mensagem, "Renovação de Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string vquery = "update tb_dadosaluno set T_DATA = '" + MGlobais.FormatarDataSQL(hojeOrig.ToShortDateString()) + "' where N_IDLIVROALUNO = '" + id + "'";
                Banco.DML(vquery);
                dgv_atrasados.Rows.Remove(dgv_atrasados.CurrentRow);
                MessageBox.Show("O livro foi renovado até a data fornecida pelo Back-End", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
