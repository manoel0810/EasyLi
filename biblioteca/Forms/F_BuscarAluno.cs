using System;
using System.Data;
using System.Media;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_BuscarAluno : Form
    {
        public F_BuscarAluno()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_BuscarAluno_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matrícula', T_TURMA AS 'Turma', T_LIVRO AS 'livro', T_TOMBO AS 'Tombo', T_DATA AS 'Data', T_STATUS AS 'Status' FROM tb_dadosaluno ORDER BY T_TURMA, T_ALUNO LIMIT 1200";
            dgv_buscaAlunos.DataSource = Banco.DQL(vquery);
            FormatarDGV();

            this.KeyPreview = true;
        }
        private void FormatarDGV()
        {
            dgv_buscaAlunos.Columns[0].Width = 50; //ID
            dgv_buscaAlunos.Columns[1].Width = 205; //ALUNO
            dgv_buscaAlunos.Columns[2].Width = 60; //MATRICULA
            dgv_buscaAlunos.Columns[3].Width = 100; //TURMA
            dgv_buscaAlunos.Columns[4].Width = 205; //LIVRO
            dgv_buscaAlunos.Columns[5].Width = 60; //TOMBO
            dgv_buscaAlunos.Columns[6].Width = 75; //DATA
            dgv_buscaAlunos.Columns[7].Width = 70; //STATUS
        }

        private void dgv_buscaAlunos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int numLinhas = dgv.SelectedRows.Count;
            if (numLinhas > 0)
            {
                DataTable dt = new DataTable();
                string valor = dgv_buscaAlunos.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(valor);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDLIVROALUNO").ToString();
            }
        }

        private void btn_devolvido_Click(object sender, EventArgs e)
        {
            if (dgv_buscaAlunos.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                string valor = dgv_buscaAlunos.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(valor);

                int Status = (int)dt.Rows[0].Field<Int64>("T_STATUS");
                if (Status.Equals((int)Global.BookStatus.Devolvido))
                {
                    MessageBox.Show("Este registro já está marcado como 'Devolvido'", "Redundância", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string email = dt.Rows[0].Field<string>("T_EMAIL").ToString();
                if (email != "")
                {
                    this.Cursor = Cursors.WaitCursor;
                    Email.EnviarEmail(String.Format("Olá {0}.\n\nVocê fez a devolução do livro {1} que foi pego em {2}.\n\nA sua devolução já foi registrada e sua pêndencia com o mesmo retirada. Agradecemos sua responsabilidade.\n\nEquipe EREMOL", dt.Rows[0].Field<string>("T_ALUNO"), dt.Rows[0].Field<string>("T_LIVRO"), dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString()), "BF Fácil - Devolução de Livro", email);
                    this.Cursor = Cursors.Default;
                }

                string vquery = "UPDATE tb_dadosaluno SET T_STATUS='" + Global.BookStatus.Devolvido + "', T_DATAP = '" + MGlobais.FormatarDataSQL(DateTime.Today.ToShortDateString()) + "' WHERE N_IDLIVROALUNO='" + tb_id.Text + "'";
                Banco.DML(vquery);
                string matricula = dt.Rows[0].Field<string>("T_MATRICULA");
                dt = Banco.DQL("SELECT * FROM tb_matriculas WHERE T_MATRICULA = '" + matricula + "'");
                if (dt.Rows.Count > 0)
                {
                    if (Status.Equals((int)Global.BookStatus.Bloqueado))
                    {
                        vquery = "UPDATE tb_matriculas SET T_ESTADO = 'ATIVO' WHERE T_MATRICULA = '" + matricula + "'";
                        Banco.DML(vquery);
                    }
                }

                dgv_buscaAlunos.Rows.Remove(dgv_buscaAlunos.CurrentRow);
                MessageBox.Show("Registro Alterado", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void tb_nomeAluno_TextChanged(object sender, EventArgs e)
        {
            if (tb_nomeAluno.Text.Contains("\'"))
            {
                SystemSound son = SystemSounds.Beep;
                son.Play();
                tb_nomeAluno.Clear();
                return;
            }
            if (cb_estado.Text == "")
            {
                MessageBox.Show("Informe um estado.", "Informação Requisitada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (cb_estado.Text == "Todos")
                {
                    string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matrícula', T_TURMA AS 'Turma', T_LIVRO AS 'livro', T_TOMBO AS 'Tombo', T_DATA AS 'Data', T_STATUS AS 'Status' FROM tb_dadosaluno WHERE T_ALUNO LIKE '" + tb_nomeAluno.Text + "%'";
                    dgv_buscaAlunos.DataSource = Banco.DQL(vquery);
                    FormatarDGV();
                }
                else
                {
                    string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matrícula', T_TURMA AS 'Turma', T_LIVRO AS 'livro', T_TOMBO AS 'Tombo', T_DATA AS 'Data', T_STATUS AS 'Status' FROM tb_dadosaluno WHERE T_ALUNO LIKE '" + tb_nomeAluno.Text + "%' AND T_STATUS='" + cb_estado.Text + "'";
                    dgv_buscaAlunos.DataSource = Banco.DQL(vquery);
                    FormatarDGV();
                }
            }
            if (tb_nomeAluno.Text == "" && tb_matricula.Text == "")
            {
                string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matrícula', T_TURMA AS 'Turma', T_LIVRO AS 'livro', T_TOMBO AS 'Tombo', T_DATA AS 'Data', T_STATUS AS 'Status' FROM tb_dadosaluno ORDER BY N_IDLIVROALUNO DESC LIMIT 1200";
                dgv_buscaAlunos.DataSource = Banco.DQL(vquery);
                FormatarDGV();
            }
        }
        private void tb_matricula_TextChanged(object sender, EventArgs e)
        {
            if (cb_estado.SelectedIndex == -1)
            {
                MessageBox.Show("Informe um estado.");
                return;
            }
            else
            {
                if (cb_estado.Text == "Todos")
                {
                    string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matrícula', T_TURMA AS 'Turma', T_LIVRO AS 'livro', T_TOMBO AS 'Tombo', T_DATA AS 'Data', T_STATUS AS 'Status' FROM tb_dadosaluno WHERE T_MATRICULA LIKE '" + tb_matricula.Text + "%'";
                    dgv_buscaAlunos.DataSource = Banco.DQL(vquery);
                    FormatarDGV();
                }
                else
                {
                    string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matrícula', T_TURMA AS 'Turma', T_LIVRO AS 'livro', T_TOMBO AS 'Tombo', T_DATA AS 'Data', T_STATUS AS 'Status' FROM tb_dadosaluno WHERE T_MATRICULA LIKE '" + tb_matricula.Text + "%' AND T_STATUS='" + cb_estado.Text + "'";
                    dgv_buscaAlunos.DataSource = Banco.DQL(vquery);
                    FormatarDGV();
                }
            }
            if (tb_nomeAluno.Text == "" && tb_matricula.Text == "")
            {
                string vquery = "SELECT N_IDLIVROALUNO AS 'ID', T_ALUNO AS 'Aluno', T_MATRICULA AS 'Matrícula', T_TURMA AS 'Turma', T_LIVRO AS 'livro', T_TOMBO AS 'Tombo', T_DATA AS 'Data', T_STATUS AS 'Status' FROM tb_dadosaluno ORDER BY N_IDLIVROALUNO DESC LIMIT 1200";
                dgv_buscaAlunos.DataSource = Banco.DQL(vquery);
                FormatarDGV();
            }
        }

        private void F_BuscarAluno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
