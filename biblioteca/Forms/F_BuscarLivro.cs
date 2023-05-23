using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_BuscarLivro : Form
    {
        public F_BuscarLivro()
        {
            InitializeComponent();
        }

        private static string matricula = string.Empty;

        private void FormatarDGV()
        {
            dgv_buscaLivros.Columns[0].Width = 60;   //id
            dgv_buscaLivros.Columns[1].Width = 230;  //aluno
            dgv_buscaLivros.Columns[2].Width = 80;  //turma
            dgv_buscaLivros.Columns[3].Width = 280;  //livro
            dgv_buscaLivros.Columns[4].Width = 80;  //tombo
        }

        private void F_BuscarLivro_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno',T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_TOMBO AS 'Tombo' FROM tb_dadosaluno WHERE T_STATUS='" + Globais.filtroe + "' ORDER BY T_TURMA, T_ALUNO";
            dgv_buscaLivros.DataSource = Banco.DQL(vquery);
            FormatarDGV();

            this.KeyPreview = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_buscaLivros_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string valor = dgv_buscaLivros.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(valor);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDLIVROALUNO").ToString();
                tb_estado.Text = dt.Rows[0].Field<string>("T_STATUS").ToString();
                string em = dt.Rows[0].Field<string>("T_EMAIL");
                matricula = dt.Rows[0].Field<string>("T_MATRICULA");
                if (em == "")
                {
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
            }
        }

        private void btn_naoDevolvido_Click(object sender, EventArgs e)
        {
            Globais.id = int.Parse(tb_id.Text);
            F_Motivo f_Motivo = new F_Motivo();
            f_Motivo.ShowDialog();

            if (Globais.controleSaida == 1)
            {
                dgv_buscaLivros.Rows.Remove(dgv_buscaLivros.CurrentRow);
                Globais.controleSaida = 0;
            }
        }

        private void tb_nomeLivro_TextChanged(object sender, EventArgs e)
        {
            if (tb_nomeLivro.Text.Contains("\'"))
            {
                tb_nomeLivro.Clear();
                return;
            }

            if (cb_neae.Checked)
            {
                if (tb_nomeLivro.Text == "" && tb_tombo.Text == "")
                {
                    string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_TOMBO AS 'Tombo' FROM tb_dadosaluno WHERE T_STATUS='" + Globais.filtroe + "' ORDER BY T_TURMA, T_ALUNO";
                    dgv_buscaLivros.DataSource = Banco.DQL(vquery);
                    FormatarDGV();
                }
                else
                {
                    string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_TOMBO AS 'Tombo' FROM tb_dadosaluno WHERE T_LIVRO LIKE '" + tb_nomeLivro.Text + "%' AND T_DATA LIKE '" + Globais.data + "%' ORDER BY T_TURMA, T_ALUNO";
                    dgv_buscaLivros.DataSource = Banco.DQL(vquery);
                    FormatarDGV();
                }
            }
            else
            {
                if (tb_nomeLivro.Text == "" && tb_tombo.Text == "")
                {
                    string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_TOMBO AS 'Tombo' FROM tb_dadosaluno WHERE T_STATUS='" + Globais.filtroe + "' ORDER BY T_TURMA, T_ALUNO";
                    dgv_buscaLivros.DataSource = Banco.DQL(vquery);
                    FormatarDGV();
                }
                else
                {
                    string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_TOMBO AS 'Tombo' FROM tb_dadosaluno WHERE T_LIVRO LIKE '" + tb_nomeLivro.Text + "%' AND T_STATUS='" + Globais.filtroe + "' ORDER BY T_TURMA, T_ALUNO";
                    dgv_buscaLivros.DataSource = Banco.DQL(vquery);
                    FormatarDGV();
                }
            }
        }

        private void tb_tombo_TextChanged(object sender, EventArgs e)
        {
            if (cb_neae.Checked)
            {
                if (tb_nomeLivro.Text == "" && tb_tombo.Text == "")
                {
                    string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_TOMBO AS 'Tombo' FROM tb_dadosaluno WHERE T_STATUS='" + Globais.filtroe + "' ORDER BY T_TURMA, T_ALUNO";
                    dgv_buscaLivros.DataSource = Banco.DQL(vquery);
                    FormatarDGV();
                }
                else
                {
                    string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_TOMBO AS 'Tombo' FROM tb_dadosaluno WHERE T_TOMBO LIKE '" + tb_tombo.Text + "%' AND T_DATA LIKE '" + Globais.data + "%' ORDER BY T_TURMA, T_ALUNO";
                    dgv_buscaLivros.DataSource = Banco.DQL(vquery);
                    FormatarDGV();
                }
            }
            else
            {
                if (tb_nomeLivro.Text == "" && tb_tombo.Text == "")
                {
                    string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_TOMBO AS 'Tombo' FROM tb_dadosaluno WHERE T_STATUS='" + Globais.filtroe + "' ORDER BY T_TURMA, T_ALUNO";
                    dgv_buscaLivros.DataSource = Banco.DQL(vquery);
                    FormatarDGV();
                }
                else
                {
                    string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_TURMA AS 'Turma', T_LIVRO AS 'Livro', T_TOMBO AS 'Tombo' FROM tb_dadosaluno WHERE T_TOMBO LIKE '" + tb_tombo.Text + "%' AND T_STATUS='" + Globais.filtroe + "' ORDER BY T_TURMA, T_ALUNO";
                    dgv_buscaLivros.DataSource = Banco.DQL(vquery);
                    FormatarDGV();
                }
            }
        }

        private void btn_devolvido_Click(object sender, EventArgs e)
        {
            if (tb_estado.Text == "Devolvido")
            {
                MessageBox.Show("Este livro já está marcado como 'Devolvido.'", "Redundância", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                string vquery = string.Empty;
                dt = Banco.DQL("SELECT * FROM tb_matriculas WHERE T_MATRICULA = '" + matricula + "'");
                if (dt.Rows.Count > 0)
                {
                    if (tb_estado.Text == Globais.bloqueado)
                    {
                        MessageBox.Show("Atenção. Esse registro está bloqueada no sistema. Não é possivel alterar este registro por esta tela.\nAção cancelada automaticamente.", "Sistema de Segurança Integrado - SSI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                }

                string valor = dgv_buscaLivros.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(valor);
                string email = dt.Rows[0].Field<string>("T_EMAIL").ToString();
                if (email != "")
                {
                    this.Cursor = Cursors.WaitCursor;
                    Email.EnviarEmail(String.Format("Olá {0}\n\nVocê fez a devolução do livro {1} que foi pego em {2}.\n\nA sua devolução já foi registrada e sua pêndencia com o mesmo retirada. Agradecemos sua responsabilidade.\n\nEquipe EREMOL", dt.Rows[0].Field<string>("T_ALUNO"), dt.Rows[0].Field<string>("T_LIVRO"), dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString()), "BF Fácil - Devolução de Livro", email);
                    this.Cursor = Cursors.Default;
                }

                vquery = "UPDATE tb_dadosaluno SET T_STATUS='" + Globais.filtrod + "', T_DATAP = '" + MGlobais.FormatarDataSQL(DateTime.Today.ToShortDateString()) + "' WHERE N_IDLIVROALUNO='" + tb_id.Text + "'";
                Banco.DML(vquery);
                if (cb_neae.Checked)
                {
                    MessageBox.Show("O livro foi marcado como 'Devolvido'", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgv_buscaLivros.Rows.Remove(dgv_buscaLivros.CurrentRow);
                    MessageBox.Show("O livro foi marcado como 'Devolvido'", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cb_neae.Checked || tb_estado.Text != Globais.filtroe)
            {
                MessageBox.Show("Para utilizar esta opção, você deve desabilitar a função 'Não exibir apenas Emprestaos'.");
                return;
            }

            DataTable dt = new DataTable();
            string nun = dgv_buscaLivros.SelectedRows[0].Cells[0].Value.ToString();
            dt = Banco.ObterDadosUsuario(nun);
            string email = dt.Rows[0].Field<string>("T_EMAIL").ToString();
            if (email != "")
            {
                this.Cursor = Cursors.WaitCursor;
                string body = String.Format("Olá {0}.\n\nVinhemos por meio deste, notificar sua pendência com o livro '{1}' que foi pego na data: {2}.\n\nSolicitamos que efetue a devolução.\n\nEmitido por: {3}\n\nEquipe EREMOL", dt.Rows[0].Field<string>("T_ALUNO"), dt.Rows[0].Field<string>("T_LIVRO"), dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString(), Globais.user);
                Email.EnviarEmail(body, "BF Fácil - Notificação de Livro", email);
                this.Cursor = Cursors.Default;
                MessageBox.Show("O aluno será notificado", "Serviço SMTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void F_BuscarLivro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
