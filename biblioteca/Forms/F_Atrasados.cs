using System;
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

        private readonly DateTime Hoje = DateTime.Today;
        private string id = string.Empty;

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void FormatarDGV()
        {
            dgv_atrasados.Columns[0].Width = 40;    //ID
            dgv_atrasados.Columns[1].Width = 260;   //Aluno
            dgv_atrasados.Columns[2].Width = 60;    //Matrícula
            dgv_atrasados.Columns[3].Width = 80;    //Turma
            dgv_atrasados.Columns[4].Width = 260;   //Livro
            dgv_atrasados.Columns[5].Width = 80;    //Data
        }

        private void F_Atrasados_Load(object sender, EventArgs e)
        {

            DateTime dataS8 = Hoje.AddDays(-8);
            string vquery = $"SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Usuário', T_MATRICULA AS 'Matricula', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_DATA AS 'Data' FROM registry WHERE T_DATA < '{MGlobais.FormatarDataSQL(dataS8.ToShortDateString())}' AND T_STATUS = '{(int)Global.BookStatus.Emprestado}' ORDER BY T_DATA";
            dgv_atrasados.DataSource = DatabaseController.DQL(vquery);
            FormatarDGV();

            lb_modo.Text = "Modo: Mais de 8(oito) dias";
            lb_modo.ForeColor = Color.DarkGreen;
            lb_modo.Refresh();

            KeyPreview = true;

            if (dgv_atrasados.Rows.Count == 0)
            {
                ReportList.Enabled = false;
                RenewRegistry.Enabled = false;
            }
        }

        private void DGVSelectionChenged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                Nome.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                DateTime registro = DateTime.Parse(dgv.CurrentRow.Cells[5].Value.ToString());
                TimeSpan ts = Hoje.Subtract(registro);

                OutdataDays.Text = ts.TotalDays.ToString();
                id = dgv_atrasados.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void TimeSpace(object sender, EventArgs e)
        {
            if (OperationMode.SelectedIndex != -1)
            {
                int Index = OperationMode.SelectedIndex;
                DateTime TempoPassado = Index == 0 ? Hoje.AddDays(-8) : Hoje.AddDays(-15);

                string vquery = $"SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Usuário', T_MATRICULA AS 'Matricula', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_DATA AS 'Data' FROM registry WHERE T_DATA < '{MGlobais.FormatarDataSQL(TempoPassado.ToShortDateString())}' AND T_STATUS = '{(int)Global.BookStatus.Emprestado}' ORDER BY T_DATA";
                dgv_atrasados.DataSource = DatabaseController.DQL(vquery);
                FormatarDGV();

                lb_modo.Text = Index == 0 ? "Modo: Mais de 8(oito) dias" : "Modo: Mais de 15(quinze) dias";
                lb_modo.ForeColor = Color.DarkGreen;
                lb_modo.Refresh();
            }
        }

        private void Report(object sender, EventArgs e)
        {
            if (dgv_atrasados.Rows.Count <= 0)
                return;
            else if (OperationMode.SelectedIndex == -1)
            {
                MessageBox.Show("Informe o intervalo de tempo para gerar o PDF", "Informação Requisitada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int Index = OperationMode.SelectedIndex;
            DateTime TempoPassado = Index == 0 ? Hoje.AddDays(-8) : Hoje.AddDays(-15);

            string Query = $"SELECT T_USER AS 'Usuário', T_LIVRO AS 'Livro', T_TURMA AS 'Turma', T_DATA AS 'Data' FROM registry WHERE T_DATA < '{MGlobais.FormatarDataSQL(TempoPassado.ToShortDateString())}' AND T_STATUS = '{(int)Global.BookStatus.Emprestado}' ORDER BY T_USER, T_TURMA";
            GerarPDF.CriarPDF(DatabaseController.DQL(Query), Index == 0 ? "Atrasados (8 >= Dias)" : "Atrasados (15 >= Dias)");
            return;

        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void RenewBook(object sender, EventArgs e)
        {
            if (dgv_atrasados.SelectedRows.Count == 0)
                return;

            string mensagem = String.Format("Deseja realmente renovar o registro?\n\nO Livro {0} vinculado à matrícula {1} será renovado. A nova data de entrega será: {2}", dgv_atrasados.SelectedRows[0].Cells[4].Value.ToString(), dgv_atrasados.SelectedRows[0].Cells[2].Value.ToString(), Hoje.AddDays(8).ToShortDateString());
            if (DialogResult.Yes == MessageBox.Show(mensagem, "Renovação de Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string Query = $"update registry set T_DATA = '{MGlobais.FormatarDataSQL(Hoje.ToShortDateString())}' where N_REGISTRYCODE = '" + id + "'";
                DatabaseController.DML(Query);

                dgv_atrasados.Rows.Remove(dgv_atrasados.CurrentRow);
                MessageBox.Show("O livro foi renovado até a data fornecida pelo Back-End", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
