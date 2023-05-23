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
            dgv_dadosCorrecao.Columns[1].Width = 300;
            dgv_dadosCorrecao.Columns[2].Width = 300;
        }

        private void ControleLivro(string tombo)
        {
            if (tombo != tomboOriginal)
            {
                DataTable dt = Banco.DQL(String.Format("select * from tb_livros where id = '{0}'", tomboOriginal));
                if (dt.Rows.Count > 0)
                {
                    Banco.DQL(String.Format("updata tb_livros set id = '{0}', t_titulo = '{1}' where id = '{2}'", tombo, MGlobais.ValidarString(tb_livro.Text), tomboOriginal));
                }
            }
            else
            {
                return;
            }
        }

        private void F_CorrecaoDados_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro' FROM tb_dadosaluno ORDER BY N_IDLIVROALUNO DESC LIMIT 1200";

            dgv_dadosCorrecao.DataSource = Banco.DQL(vquery);
            FormatarDGV();

            string vqueryTurmas = @"SELECT * FROM tb_turmas ORDER BY N_TURMA";
            cb_turma.Items.Clear();
            cb_turma.DataSource = Banco.ObterTurmas(vqueryTurmas);
            cb_turma.DisplayMember = "N_TURMA";
            cb_turma.ValueMember = "N_IDTURMA";
            cb_turma.Text = tb_turma.Text;

            this.KeyPreview = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_dadosCorrecao_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string valor = dgv_dadosCorrecao.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(valor);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDLIVROALUNO").ToString();
                tb_aluno.Text = dt.Rows[0].Field<string>("T_ALUNO").ToString();
                tb_matricula.Text = dt.Rows[0].Field<string>("T_MATRICULA").ToString();
                MatriculaAluno = dt.Rows[0].Field<string>("T_MATRICULA").ToString();
                tb_turma.Text = dt.Rows[0].Field<string>("T_TURMA").ToString();
                cb_turma.Text = tb_turma.Text;
                cb_altearEstado.Refresh();
                msk_data.Text = dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString();
                string data = dt.Rows[0].Field<DateTime>("T_DATAP").ToString();
                if (string.IsNullOrWhiteSpace(data) == false)
                {
                    mask_dataDev.Text = dt.Rows[0].Field<DateTime>("T_DATAP").ToShortDateString();
                    if (msk_data.Text == mask_dataDev.Text)
                    {
                        mask_dataDev.ForeColor = System.Drawing.Color.DarkRed;
                    }
                    else
                    {
                        mask_dataDev.ForeColor = System.Drawing.Color.DarkGreen;
                    }
                }
                else
                {
                    mask_dataDev.Text = string.Empty;
                }
                tb_livro.Text = dt.Rows[0].Field<string>("T_LIVRO").ToString();
                tb_tombo.Text = dt.Rows[0].Field<string>("T_TOMBO").ToString();
                tomboOriginal = dt.Rows[0].Field<string>("T_TOMBO").ToString();
                tb_estado.Text = dt.Rows[0].Field<string>("T_STATUS").ToString();
                cb_altearEstado.Text = tb_estado.Text;
                cb_altearEstado.Refresh();
                tb_email.Text = dt.Rows[0].Field<string>("T_EMAIL").ToString();
                tb_notas.Text = dt.Rows[0].Field<string>("T_NOTAS");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_dadosCorrecao.SelectedRows.Count < 1)
            {
                return;
            }

            string aluno = MGlobais.ValidarString(tb_aluno.Text);
            string livro = MGlobais.ValidarString(tb_livro.Text);

            string tipo = tb_estado.Text;
            if (tipo.ToUpper().Equals(MGlobais.GetDescription(Global.BookStatus.Bloqueado)))
            {
                if (tb_estado.Text != cb_altearEstado.Text)
                {
                    DialogResult res = MessageBox.Show("Este registro está bloqueado. Deseja alterar seu estado?\n\nIsso permitirá o usuário a efeturar novos empréstimos.", "Bloqueado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == res)
                    {
                        string query = "update tb_matriculas set T_ESTADO = 'ATIVO' where T_MATRICULA = '" + MatriculaAluno + "'";
                        Banco.DML(query);
                        query = "update tb_dadosaluno set T_STATUS = '" + Global.BookStatus.Devolvido + "', T_DATAP = '" + MGlobais.FormatarDataSQL(DateTime.Today.ToShortDateString()) + "' where ID_LIVROALUNO = '" + tb_id.Text + "'";
                        Banco.DML(query);
                    }
                    else
                    {
                        MessageBox.Show("O registro será alterado, mas a matrícula continuará bloqueada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            if (!tb_estado.Text.ToUpper().Equals(MGlobais.GetDescription(Global.BookStatus.Bloqueado)) && cb_altearEstado.Text.ToUpper().Equals(MGlobais.GetDescription(Global.BookStatus.Bloqueado)))
            {
                DialogResult res = MessageBox.Show("Você deseja realmente bloquear essa matrícula?", "Bloqueio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                {
                    DataTable dt = new DataTable();
                    string comando = "";
                    dt = Banco.DQL("select * from tb_matriculas where T_MATRICULA = '" + MatriculaAluno + "'");
                    if (dt.Rows.Count == 0)
                    {
                        comando = "insert into tb_matriculas (T_MATRICULA, T_ESTADO, T_ALUNO) values ('" + MatriculaAluno + "', '" + Global.BookStatus.Bloqueado + "', '" + tb_aluno.Text + "')";
                        Banco.DML(comando);
                    }
                    else
                    {
                        comando = "update tb_matriculas set T_ESTADO = '" + Global.BookStatus.Bloqueado + "' where T_MATRICULA = '" + MatriculaAluno + "'";
                        Banco.DML(comando);
                    }

                    comando = "update tb_dadosaluno set T_DATAP = '' where ID_LIVROALUNO = '" + tb_id.Text + "'";
                    Banco.DML(comando);
                }
                else
                {
                    MessageBox.Show("Nenhum dado foi alterado", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (tb_estado.Text.ToUpper().Equals(MGlobais.GetDescription(Global.BookStatus.Devolvido)) && cb_altearEstado.Text.ToUpper().Equals(MGlobais.GetDescription(Global.BookStatus.Emprestado)))
                mask_dataDev.Text = msk_data.Text;
            

            string vquery = "UPDATE tb_dadosaluno SET T_ALUNO='" + aluno + "', T_LIVRO='" + livro + "', T_STATUS='" + cb_altearEstado.Text + "', T_DATA='" + MGlobais.FormatarDataSQL(msk_data.Text) + "', T_DATAP = '" + MGlobais.FormatarDataSQL(mask_dataDev.Text) + "', T_TURMA='" + cb_turma.Text + "', T_MATRICULA='" + tb_matricula.Text + "', T_TOMBO='" + tb_tombo.Text + "', T_EMAIL='" + tb_email.Text + "', T_NOTAS='" + tb_notas.Text + "' WHERE N_IDLIVROALUNO=" + tb_id.Text;
            Banco.DML(vquery);
            ControleLivro(tb_tombo.Text);
            MessageBox.Show("Dados alterados. Atualize a lista para ver mudanças.", "Alterações Salvas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_tomboF.Text == "")
            {
                if (tb_matriculaF.Text == "")
                {
                    MessageBox.Show("Não há filtros definidos");
                }
                else
                {
                    string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro' FROM tb_dadosaluno WHERE T_MATRICULA='" + tb_matriculaF.Text + "' ORDER BY N_IDLIVROALUNO DESC";
                    DataTable dt = new DataTable();
                    dt = Banco.DQL(vquery);
                    if (dt.Rows.Count > 0)
                    {
                        dgv_dadosCorrecao.DataSource = dt;
                        FormatarDGV();
                    }
                    else
                    {
                        MessageBox.Show("Não houve correspondência da matrícula", "Retorno vazil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            else
            {
                string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_LIVRO AS 'Livro' FROM tb_dadosaluno WHERE T_TOMBO='" + tb_tomboF.Text + "' ORDER BY N_IDLIVROALUNO DESC";
                DataTable dt = new DataTable();
                dt = Banco.DQL(vquery);
                if (dt.Rows.Count > 0)
                {
                    dgv_dadosCorrecao.DataSource = dt;
                    FormatarDGV();
                }
                else
                {
                    MessageBox.Show("Não houve correspondência do tombo", "Retorno vazil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void tb_notas_TextChanged(object sender, EventArgs e)
        {
            if (tb_notas.Text.Contains("\'"))
            {
                tb_notas.Text.Replace("\'", "*");
                tb_notas.Refresh();
            }
            int tamanhoChar = 0;
            tamanhoChar = tb_notas.Text.Length;
            lb_caracteres.Text = tamanhoChar.ToString() + "/100";
        }

        private void F_CorrecaoDados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
