using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_CorrecaoDados : Form
    {
        public F_CorrecaoDados()
        {
            InitializeComponent();
        }

        private ToolTip Tip;
        private bool BlockUser = false;
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
                if (DatabaseController.DataQueryLanguage(String.Format("select * from tb_livros where id = '{0}'", tomboOriginal)).Rows.Count > 0)
                    DatabaseController.DataQueryLanguage(String.Format("updata tb_livros set id = '{0}', t_titulo = '{1}' where id = '{2}'", tombo, MGlobais.SanitizeString(Livro.Text), tomboOriginal));
        }

        private void FormLoad(object sender, EventArgs e)
        {
            dgv_dadosCorrecao.DataSource = DatabaseController.DataQueryLanguage("SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Usuário', T_LIVRO AS 'Livro' FROM registry ORDER BY N_REGISTRYCODE DESC LIMIT 1200");
            FormatarDGV();

            Turmas.DataSource = DatabaseController.DataQueryLanguage(@"SELECT * FROM tb_turmas ORDER BY N_TURMA");
            Turmas.DisplayMember = "N_TURMA";
            Turmas.ValueMember = "N_IDTURMA";
            //cb_turma.Text = tb_turma.Text;

            KeyPreview = true;

            MGlobais.SetNumericFieldOnly(ref Tombo);
            MGlobais.SetNumericFieldOnly(ref Matricula);
            MGlobais.SetNumericFieldOnly(ref FiltroMatricula);

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
                DataTable dt = DatabaseController.DataQueryLanguage($"select * from registry where N_REGISTRYCODE = '{ID}'");

                Identificacao.Text = dt.Rows[0].Field<Int64>("N_REGISTRYCODE").ToString();
                NomeUsuario.Text = dt.Rows[0].Field<string>("T_USER").ToString();
                Matricula.Text = dt.Rows[0].Field<string>("T_MATRICULA").ToString();
                TurmaAtual.Text = dt.Rows[0].Field<string>("T_TURMA").ToString();
                Turmas.Text = TurmaAtual.Text;
                EstadosDoLivro.Refresh();

                DataSaida.Text = dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString();
                string data = dt.Rows[0].Field<DateTime>("T_DATAP").ToString();
                if (string.IsNullOrWhiteSpace(data) == false)
                {
                    DataDevolucao.Text = dt.Rows[0].Field<DateTime>("T_DATAP").ToShortDateString();
                    if (DataSaida.Text == DataDevolucao.Text)
                        DataDevolucao.ForeColor = Color.DarkRed;
                    else
                        DataDevolucao.ForeColor = Color.DarkGreen;
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

                //Verificar estado atual de cadastro do usuário associado à matrícula do registro selecionado
                DataTable UserInformations = DatabaseController.DataQueryLanguage($"select * from users where code = '{dt.Rows[0].Field<string>("T_MATRICULA")}'");
                if (UserInformations.Rows.Count == 0)
                {
                    MessageBox.Show("Ocorre um erro ao recuperar as informações do usuário associado à este registro. O usuário pode ter sido excluído e a referência ao registro não alterada", "Correção de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if ((int)UserInformations.Rows[0].Field<Int64>("user_status") == (int)Global.UserState.Blocked)
                    {
                        BlockUser = true;
                        UserState.Text = "Blocked";
                        UserState.ForeColor = Color.DarkRed;
                    }
                    else if ((int)UserInformations.Rows[0].Field<Int64>("user_status") == (int)Global.UserState.Free)
                    {
                        BlockUser = false;
                        UserState.Text = "Free";
                        UserState.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        BlockUser = true;
                        UserState.Text = "Undefined";
                        UserState.ForeColor = Color.DarkRed;
                    }
                }
            }
        }

        private void SaveClick(object sender, EventArgs e)
        {
            if (dgv_dadosCorrecao.SelectedRows.Count < 1)
                return;

            if (!String.IsNullOrWhiteSpace(Email.Text))
                if (!MGlobais.ValidateEmail(Email.Text))
                {
                    MessageBox.Show("O endereço de UserEmail informado é inválido. Modifique ou remova o UserEmail do registro", "Correção de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            if (EstadoDoLivro.Text.ToUpper().Equals(MGlobais.GetDescription(Global.BookStatus.Devolvido)) && EstadosDoLivro.Text.ToUpper().Equals(MGlobais.GetDescription(Global.BookStatus.Emprestado)))
                DataDevolucao.Text = DataSaida.Text;

            string query = "UPDATE registry SET T_USER = @param1, T_LIVRO = @param2, T_STATUS = @param3, T_DATA = @param4, T_DATAP = @param5, T_TURMA = @param6, T_MATRICULA = @param7, T_TOMBO = @param8, T_EMAIL = @param9, T_NOTAS = @param10 WHERE N_REGISTRYCODE = @param11";
            object[] values = new object[]
            {
                NomeUsuario.Text.Replace("'", "''"),
                Livro.Text.Replace("'", "''"),
                (int)MGlobais.GetDescription(EstadosDoLivro.Text),
                MGlobais.FormatarDataSQL(DataSaida.Text),
                MGlobais.FormatarDataSQL(DataDevolucao.Text),
                Turmas.Text,
                Matricula.Text,
                Tombo.Text,
                Email.Text.Replace("'", "''"),
                Notas.Text,
                Identificacao.Text
            };

            DatabaseController.InsertData(query, values);
            ControleLivro(Tombo.Text);

            Global.UserState State;
            DataTable UserInformation = DatabaseController.DataQueryLanguage($"select * from users where code = '{Matricula.Text}'");

            if (Enum.IsDefined(typeof(Global.UserState), (int)UserInformation.Rows[0].Field<Int64>("user_status")))
                State = (Global.UserState)(int)UserInformation.Rows[0].Field<Int64>("user_status");
            else
                State = Global.UserState.NotDefined;

            if (EstadoDoLivro.Text != "PERDIDO" && EstadosDoLivro.Text == "PERDIDO" && State != Global.UserState.Blocked)
            {
                DialogResult Block = MessageBox.Show("Você alterou o estado do livro para 'Perdido. Você deseja bloquar a matrícula vinculada a esse registro para impedir novos empréstimos do mesmo usuário? Essa ação só pode ser desfeita na gestão de usuários", "Bloqueio de usuários", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Block == DialogResult.Yes)
                {
                    F_Motivo Motivo = new F_Motivo(int.Parse(Identificacao.Text));
                    Motivo.ShowDialog();
                    Motivo.Dispose();
                }
            }

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
            else if (e.KeyCode == Keys.Delete)
                Delete.PerformClick();
        }

        private void FiltroNome_TextChanged(object sender, EventArgs e)
        {
            if (FiltroNome.Text.Trim().Length >= 2)
            {
                dgv_dadosCorrecao.DataSource = DatabaseController.DataQueryLanguage($"SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Usuário', T_LIVRO AS 'Livro' FROM registry where T_USER like '%{FiltroNome.Text.Replace("'", "''")}%' or T_LIVRO like '%{FiltroNome.Text.Replace("'", "''")}%' ORDER BY N_REGISTRYCODE DESC LIMIT 1200");
                FormatarDGV();
            }
            else if (FiltroNome.Text.Trim().Length == 0)
            {
                dgv_dadosCorrecao.DataSource = DatabaseController.DataQueryLanguage("SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Usuário', T_LIVRO AS 'Livro' FROM registry ORDER BY N_REGISTRYCODE DESC LIMIT 1200");
                FormatarDGV();
            }
        }

        private void FiltroMatricula_TextChanged(object sender, EventArgs e)
        {
            if (FiltroMatricula.Text.Length >= 2)
            {
                dgv_dadosCorrecao.DataSource = DatabaseController.DataQueryLanguage($"SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Usuário', T_LIVRO AS 'Livro' FROM registry where T_MATRICULA like '%{FiltroMatricula.Text}%' or T_TOMBO like '%{FiltroMatricula.Text}%' ORDER BY N_REGISTRYCODE DESC LIMIT 1200");
                FormatarDGV();
            }
            else if (FiltroMatricula.Text.Length == 0)
            {
                dgv_dadosCorrecao.DataSource = DatabaseController.DataQueryLanguage("SELECT N_REGISTRYCODE AS 'ID', T_USER AS 'Usuário', T_LIVRO AS 'Livro' FROM registry ORDER BY N_REGISTRYCODE DESC LIMIT 1200");
                FormatarDGV();
            }
        }

        private void UserState_MouseHover(object sender, EventArgs e)
        {
            if (BlockUser)
            {
                Tip?.Dispose();
                Tip = new ToolTip();
                Tip.SetToolTip((TextBox)sender, "Esta matrícula está bloqueada. Para alterar esse estado, use o gestor de usuários");
            }
            else
                Tip?.Dispose();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dgv_dadosCorrecao.SelectedRows.Count == 0)
                return;

            if (DialogResult.Yes == MessageBox.Show("Deseja realmente apagar esse registro de movimentação? Essa ação não é reversível", "Correção de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                DatabaseController.DataManipulationLanguage($"delete from registry where N_REGISTRYCODE = '{dgv_dadosCorrecao.SelectedRows[0x0].Cells[0x0].Value}'");
                dgv_dadosCorrecao.Rows.Remove(dgv_dadosCorrecao.SelectedRows[0]);
            }
        }
    }
}
