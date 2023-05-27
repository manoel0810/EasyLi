using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_CorrecaoDados : Form
    {
        public F_CorrecaoDados()
        {
            InitializeComponent();
        }

        private string MatriculaAluno = string.Empty;
        private static string tomboOriginal = string.Empty;

        private void FormatarDGV()
        {
            dgv_dadosCorrecao.Columns[0].Width = 60;
            dgv_dadosCorrecao.Columns[1].Width = 260;
            dgv_dadosCorrecao.Columns[2].Width = 260;
        }

        private void ControleLivro(string tombo)
        {
            if (tombo != tomboOriginal)
                if (DatabaseController.DQL(String.Format("select * from tb_livros where id = '{0}'", tomboOriginal)).Rows.Count > 0)
                    DatabaseController.DQL(String.Format("updata tb_livros set id = '{0}', t_titulo = '{1}' where id = '{2}'", tombo, MGlobais.ValidarString(Livro.Text), tomboOriginal));
        }

        private void FormLoad(object sender, EventArgs e)
        {
            dgv_dadosCorrecao.DataSource = DatabaseController.DQL("SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Usuário', T_LIVRO AS 'Livro' FROM registry ORDER BY N_REGISTRYCODE DESC LIMIT 1200");
            FormatarDGV();

            Turmas.DataSource = DatabaseController.DQL(@"SELECT * FROM tb_turmas ORDER BY N_TURMA");
            Turmas.DisplayMember = "N_TURMA";
            Turmas.ValueMember = "N_IDTURMA";
            //cb_turma.Text = tb_turma.Text;

            KeyPreview = true;

            Matricula.KeyPress += (_, Args) =>
            {
                if (!(Args.KeyChar >= 48 && Args.KeyChar <= 57))
                    if (Args.KeyChar != '\b')
                        Args.KeyChar = '\0';

                Args.Handled = false;
            };

            FiltroMatricula.KeyPress += (_, Args) =>
            {
                if (!(Args.KeyChar >= 48 && Args.KeyChar <= 57))
                    if (Args.KeyChar != '\b')
                        Args.KeyChar = '\0';

                Args.Handled = false;
            };

            Tombo.KeyPress += (_, Args) =>
            {
                if (!(Args.KeyChar >= 48 && Args.KeyChar <= 57))
                    if (Args.KeyChar != '\b')
                        Args.KeyChar = '\0';

                Args.Handled = false;
            };
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void DGVSelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                string ID = dgv_dadosCorrecao.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dt = DatabaseController.DQL($"select * from registry where N_REGISTRYCODE = '{ID}'");

                Identificacao.Text = dt.Rows[0].Field<Int64>("N_REGISTRYCODE").ToString();
                NomeUsuario.Text = dt.Rows[0].Field<string>("T_USER").ToString();
                Matricula.Text = dt.Rows[0].Field<string>("T_MATRICULA").ToString();
                MatriculaAluno = dt.Rows[0].Field<string>("T_MATRICULA").ToString();
                TurmaAtual.Text = dt.Rows[0].Field<string>("T_TURMA").ToString();
                Turmas.Text = TurmaAtual.Text;
                EstadosDoLivro.Refresh();

                DataSaida.Text = dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString();
                string data = dt.Rows[0].Field<DateTime>("T_DATAP").ToString();
                if (string.IsNullOrWhiteSpace(data) == false)
                {
                    DataDevolucao.Text = dt.Rows[0].Field<DateTime>("T_DATAP").ToShortDateString();
                    if (DataSaida.Text == DataDevolucao.Text)
                        DataDevolucao.ForeColor = System.Drawing.Color.DarkRed;
                    else
                        DataDevolucao.ForeColor = System.Drawing.Color.DarkGreen;
                }
                else
                    DataDevolucao.Text = string.Empty;


                Livro.Text = dt.Rows[0].Field<string>("T_LIVRO").ToString();
                Tombo.Text = dt.Rows[0].Field<string>("T_TOMBO").ToString();
                tomboOriginal = dt.Rows[0].Field<string>("T_TOMBO").ToString();
                EstadoDoLivro.Text = MGlobais.GetDescription((Global.BookStatus)(int)dt.Rows[0].Field<Int64>("T_STATUS"));
                EstadosDoLivro.Text = EstadoDoLivro.Text;
                EstadosDoLivro.Refresh();

                Email.Text = dt.Rows[0].Field<string>("T_EMAIL").ToString();
                Notas.Text = dt.Rows[0].Field<string>("T_NOTAS");
            }
        }

        private void SaveClick(object sender, EventArgs e)
        {
            if (dgv_dadosCorrecao.SelectedRows.Count < 1)
                return;

            if (EstadoDoLivro.Text.ToUpper().Equals(MGlobais.GetDescription(Global.UserState.Blocked)))
            {
                if (EstadoDoLivro.Text != EstadosDoLivro.Text)
                {
                    DialogResult res = MessageBox.Show("Este registro está bloqueado. Deseja alterar seu estado?\n\nIsso permitirá o usuário a efeturar novos empréstimos.", "Bloqueado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == res)
                    {
                        DatabaseController.DML($"update users set user_status = '{(int)Global.UserState.Free}' where code = '{MatriculaAluno}'");
                        DatabaseController.DML($"update registry set T_STATUS = '{(int)Global.BookStatus.Devolvido}', T_DATAP = '{MGlobais.FormatarDataSQL(DateTime.Today.ToShortDateString())}' where N_REGISTRYCODE = '{Identificacao.Text}'");
                    }
                    else
                        MessageBox.Show("O registro será alterado, mas a matrícula continuará bloqueada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

            if (!EstadoDoLivro.Text.ToUpper().Equals(MGlobais.GetDescription(Global.UserState.Blocked)) && EstadosDoLivro.Text.ToUpper().Equals(MGlobais.GetDescription(Global.UserState.Blocked)))
            {
                DialogResult res = MessageBox.Show("Você deseja realmente bloquear essa matrícula?", "Bloqueio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                {
                    DataTable dt = DatabaseController.DQL($"select * from users where code = '{MatriculaAluno}'");
                    if (dt.Rows.Count == 0)
                        DatabaseController.DML($"insert into users (code, user_name, user_status) values ('{MatriculaAluno}', '{NomeUsuario.Text}', '{(int)Global.UserState.Blocked}')");
                    else
                        DatabaseController.DML($"update users set user_status = '{(int)Global.UserState.Blocked}' where code = '{MatriculaAluno}'");

                    DatabaseController.DML($"update registry set T_DATAP = '' where N_REGISTRYCODE = '{Identificacao.Text}'");
                }
                else
                {
                    MessageBox.Show("Nenhuma informação para correções.", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (EstadoDoLivro.Text.ToUpper().Equals(MGlobais.GetDescription(Global.BookStatus.Devolvido)) && EstadosDoLivro.Text.ToUpper().Equals(MGlobais.GetDescription(Global.BookStatus.Emprestado)))
                DataDevolucao.Text = DataSaida.Text;


            string vquery = $"UPDATE registry SET T_USER='{NomeUsuario.Text.Replace("'", "''")}', T_LIVRO='{Livro.Text.Replace("'", "''")}', T_STATUS='{(int)MGlobais.GetDescription(EstadosDoLivro.Text)}', T_DATA='{MGlobais.FormatarDataSQL(DataSaida.Text)}', T_DATAP = '{MGlobais.FormatarDataSQL(DataDevolucao.Text)}', T_TURMA='{Turmas.Text}', T_MATRICULA='{Matricula.Text}', T_TOMBO='{Tombo.Text}', T_EMAIL='{Email.Text}', T_NOTAS='{Notas.Text}' WHERE N_REGISTRYCODE='{Identificacao.Text}'";
            DatabaseController.DML(vquery);

            ControleLivro(Tombo.Text);
            MessageBox.Show("Dados alterados. Atualize a lista para ver mudanças.", "Alterações Salvas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NotasChenged(object sender, EventArgs e)
        {
            lb_caracteres.Text = Notas.Text.Length.ToString() + "/100";
        }

        private void F_CorrecaoDados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void FiltroNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void FiltroMatricula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
