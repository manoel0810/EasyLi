using System;
using System.Data;
using System.Windows.Forms;
namespace biblioteca
{
    public partial class F_DevolucaoLivro : Form
    {
        public F_DevolucaoLivro()
        {
            InitializeComponent();
        }

        private void FormatarDGV()
        {
            dgv_livrosPdevol.Columns[0].Width = 40;
            dgv_livrosPdevol.Columns[1].Width = 265;
            dgv_livrosPdevol.Columns[2].Width = 265;
        }

        private void F_DevolucaoLivro_Load(object sender, EventArgs e)
        {
            string vquery = @"SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro' FROM tb_dadosaluno WHERE T_STATUS = '" + MGlobais.GetDescription(Global.BookStatus.Emprestado) + "' ORDER BY T_ALUNO";
            dgv_livrosPdevol.DataSource = DatabaseController.DQL(vquery);
            FormatarDGV();

            KeyPreview = true;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_livrosPdevol_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string valor = dgv_livrosPdevol.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(valor);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDLIVROALUNO").ToString();
                tb_nomeAluno.Text = dt.Rows[0].Field<string>("T_ALUNO").ToString();
                tb_nomeLivro.Text = dt.Rows[0].Field<string>("T_LIVRO").ToString();
                tb_data.Text = dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString();
                tb_status.Text = dt.Rows[0].Field<string>("T_STATUS").ToString();
                tb_turma.Text = dt.Rows[0].Field<string>("T_TURMA").ToString();
                tb_matricula.Text = dt.Rows[0].Field<string>("T_MATRICULA").ToString();
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (dgv_livrosPdevol.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                if (cb_devolvido.Checked)
                {
                    DataTable dt = new DataTable();
                    string valor = dgv_livrosPdevol.SelectedRows[0].Cells[0].Value.ToString();
                    dt = Banco.ObterDadosUsuario(valor);
                    string email = dt.Rows[0].Field<string>("T_EMAIL").ToString();
                    if (email != "")
                    {
                        this.Cursor = Cursors.WaitCursor;
                        Email.EnviarEmail(String.Format("Olá {0}.\n\nVocê fez a devolução do livro {1} que foi pego em {2}.\n\nA sua devolução já foi registrada e sua pêndencia com o mesmo retirada. Agradecemos sua responsabilidade.\n\nEquipe EREMOL", dt.Rows[0].Field<string>("T_ALUNO"), dt.Rows[0].Field<string>("T_LIVRO"), dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString()), "BF Fácil - Devolução de Livro", email);
                        this.Cursor = Cursors.Default;
                    }
                    string vquery = "UPDATE	tb_dadosaluno SET T_STATUS='" + Global.BookStatus.Devolvido + "', T_DATAP = '" + MGlobais.FormatarDataSQL(DateTime.Today.ToShortDateString()) + "' WHERE N_IDLIVROALUNO=" + tb_id.Text;
                    Banco.DML(vquery);
                    dgv_livrosPdevol.Rows.Remove(dgv_livrosPdevol.CurrentRow);
                    MessageBox.Show("Alterado com êxito.", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("VOCÊ NÃO CONFIRMOU A CHECKBOX(Devolvido).", "Confirmações", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void tb_Fnome_TextChanged(object sender, EventArgs e)
        {
            if (tb_Fnome.Text == "" && tb_Fmatricula.Text == "")
            {
                string vquery = @"SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro' FROM tb_dadosaluno WHERE T_STATUS = '" + Global.BookStatus.Emprestado + "' ORDER BY T_ALUNO";

                dgv_livrosPdevol.DataSource = Banco.DQL(vquery);
                FormatarDGV();
            }

            //Validação
            if (tb_Fnome.Text.Contains("\'"))
            {
                MessageBox.Show("A pesquisa não admite ( ' )", "Invalidação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Fnome.Clear();
                return;
            }
            else
            {
                string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro' FROM tb_dadosaluno WHERE T_ALUNO LIKE '" + tb_Fnome.Text + "%' AND T_STATUS = '" + Global.BookStatus.Emprestado + "'";
                dgv_livrosPdevol.DataSource = DatabaseController.DQL(vquery);
                FormatarDGV();
            }
        }

        private void tb_Fmatricula_TextChanged(object sender, EventArgs e)
        {
            if (tb_Fnome.Text == "" && tb_Fmatricula.Text == "")
            {
                string vquery = @"SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro' FROM tb_dadosaluno WHERE T_STATUS = '" + Global.BookStatus.Emprestado + "' ORDER BY T_ALUNO";

                dgv_livrosPdevol.DataSource = DatabaseController.DQL(vquery);
                FormatarDGV();
            }

            //Validação
            if (tb_Fmatricula.Text.Contains("\'"))
            {
                tb_Fmatricula.Clear();
                return;
            }
            else
            {
                string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro' FROM tb_dadosaluno WHERE T_MATRICULA LIKE '" + tb_Fmatricula.Text + "%' AND T_STATUS = '" + Global.BookStatus.Emprestado + "'";
                dgv_livrosPdevol.DataSource = DatabaseController.DQL(vquery);
                FormatarDGV();
            }
        }

        private void F_DevolucaoLivro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
