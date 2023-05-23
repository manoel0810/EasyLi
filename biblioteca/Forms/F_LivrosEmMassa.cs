using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_LivrosEmMassa : Form
    {
        public F_LivrosEmMassa()
        {
            InitializeComponent();
        }

        private void bnt_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_LivrosEmMassa_Load(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Today;
            mask_data.Text = hoje.ToString();

            //Popular ComboBox

            string vqueryTurmas = @"SELECT * FROM tb_turmas ORDER BY N_TURMA";
            cb_turma.Items.Clear();
            cb_turma.DataSource = Banco.ObterTurmas(vqueryTurmas);
            cb_turma.DisplayMember = "N_TURMA";
            cb_turma.ValueMember = "N_IDTURMA";

            this.KeyPreview = true;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string aluno = MGlobais.ValidarString(tb_aluno.Text);
            string livro = MGlobais.ValidarString(tb_livro.Text);

            if (String.IsNullOrEmpty(tb_email.Text) == false)
            {
                if (tb_email.Text.Contains("@gmail.com") || tb_email.Text.Contains("@hotmail.com") || tb_email.Text.Contains("@outlook.com"))
                {
                    string mensgem = String.Format("Olá {0}.\n\nNotamos que você realizou a retirada do livro '{1}'.\n\nVocê possue 8(oito) dias para efetuar a devolução.\n\nEquipe EREMOL", tb_aluno.Text, tb_livro.Text);
                    Email.EnviarEmail(mensgem, "BF Fácil - Retirada de Livro", tb_email.Text);
                }
                else
                {
                    MessageBox.Show("O E-Mail Fornecido (" + tb_email.Text + ") É Inválido.", "Avisos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (tb_aluno.Text == "")
            {
                MessageBox.Show("Informe os campos corretamente", "Informação Requisitada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string vazil = "";
                string status = Globais.filtroe;
                string vquery = @"INSERT INTO tb_dadosaluno (T_ALUNO, T_LIVRO, T_STATUS, T_DATA, T_DATAP,  T_TURMA, T_MATRICULA, T_TOMBO, T_EMAIL, T_NOTAS) VALUES ('" + aluno + "', '" + livro + "', '" + status + "', '" + MGlobais.FormatarDataSQL(mask_data.Text) + "', '" + MGlobais.FormatarDataSQL(mask_data.Text) + "', '" + cb_turma.Text + "', '" + tb_matricula.Text + "', '" + tb_tombo.Text + "', '" + tb_email.Text + "', '" + vazil + "')";
                Banco.DML(vquery);
                MessageBox.Show("Salvo.", "Registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegistrarLivro();
                tb_aluno.Clear();
                tb_matricula.Clear();
                tb_email.Clear();
                tb_aluno.Focus();
            }
        }
        private void RegistrarLivro()
        {
            DataTable dt = new DataTable();
            dt = Banco.DQL("select * from tb_livros where id = '" + tb_tombo.Text + "'");
            if (dt.Rows.Count == 0)
            {
                Banco.DML(String.Format("insert into tb_livros values ('{0}', '{1}', '{2}')", tb_tombo.Text, MGlobais.ValidarString(tb_livro.Text), MGlobais.FormatarDataSQL(DateTime.Today.ToShortDateString())));
            }
        }

        private void F_LivrosEmMassa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar.PerformClick();
            }
        }

        private void tb_matricula_Leave(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Biblioteca Fácil\Didáticos\Didaticos.db"))
            {
                DataTable dt = new DataTable();
                dt = Banco.dqlDidaticos(String.Format("select * from tb_alunos where matricula_id = '{0}'", tb_matricula.Text));
                if (dt.Rows.Count > 0)
                {
                    tb_aluno.Text = dt.Rows[0].Field<string>("t_nome");
                    cb_turma.Text = dt.Rows[0].Field<string>("t_turma");
                }
                else
                {
                    return;
                }
            }
        }
    }
}
