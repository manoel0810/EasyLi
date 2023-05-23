using System;
using System.Data;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_RegistroLivroSaindo : Form
    {
        private Global.BookStatus status = Global.BookStatus.Emprestado;

        public F_RegistroLivroSaindo()
        {
            InitializeComponent();
        }
        private void LimparForm()
        {
            tb_aluno.Clear();
            tb_livro.Clear();
            tb_tombo.Clear();
            tb_matricula.Clear();
            tb_email.Clear();
            cb_turma.Text = "1º ANO A";
            tb_livro.Focus();
            btn_confirmar.Enabled = true;
            btn_confirmar.Cursor = Cursors.Default;
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
        private void F_RegistroLivroSaindo_Load(object sender, EventArgs e)
        {
            //Popular ComboBox Turmas
            string vqueryTurmas = @"SELECT * FROM tb_turmas ORDER BY N_TURMA";
            cb_turma.Items.Clear();
            cb_turma.DataSource = Banco.ObterTurmas(vqueryTurmas);
            cb_turma.DisplayMember = "N_TURMA";
            cb_turma.ValueMember = "N_IDTURMA";

            DateTime hoje = DateTime.Today;
            string data = hoje.ToShortDateString();
            msk_data.Text = data;

            this.KeyPreview = true;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            //Validação 
            string tA = MGlobais.ValidarString(tb_aluno.Text);
            string tL = MGlobais.ValidarString(tb_livro.Text);

            if (tb_matricula.Text != "")
            {
                string vquery = "SELECT * FROM tb_matriculas WHERE T_MATRICULA = '" + tb_matricula.Text + "' AND T_ESTADO = '" + (int)Global.BookStatus.Bloqueado + "'";
                DataTable RES = new DataTable();
                RES = DatabaseController.DQL(vquery);
                int rest = RES.Rows.Count;
                if (rest > 0)
                {
                    MessageBox.Show("Esta matrícula está bloqueada no sistema por alguma pendência. Para novos cadastros, retire o bloqueio do aluno.", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimparForm();
                    return;
                }
            }

            if (tb_aluno.Text == "" || tb_livro.Text == "")
            {
                MessageBox.Show("Informe os campos corretamente", "Informações Requisitas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                RegistrarLivro();

                if (tb_matricula.Text == "")
                {
                    btn_confirmar.Enabled = false;
                    btn_confirmar.Cursor = Cursors.No;
                    if (tb_email.Text != "")
                    {
                        if (tb_email.Text.Contains("@gmail.com") || tb_email.Text.Contains("@hotmail.com") || tb_email.Text.Contains("@outlook.com"))
                        {
                            this.Cursor = Cursors.WaitCursor;
                            Email.EnviarEmail(String.Format("Olá {0}.\n\nNotamos que você realizou a retirada do livro '{1}'. Você possue 8(oito) dias para efetuar a devolução.\n\nEquipe EREMOL", tb_aluno.Text, tb_livro.Text), "BF Fácil - Retirada de Livro", tb_email.Text);
                            this.Cursor = Cursors.Default;
                        }
                        else
                        {
                            MessageBox.Show("E-Mail fornecido inválido", "SMTP Client", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            btn_confirmar.Enabled = true;
                            btn_confirmar.Cursor = Cursors.Hand;
                            return;
                        }
                    }

                    string vquery = @"INSERT INTO tb_dadosaluno (T_ALUNO, T_LIVRO, T_STATUS, T_DATA, T_DATAP, T_TURMA, T_MATRICULA, T_TOMBO, T_EMAIL) VALUES ('" + tA + "', '" + tL + "', '" + (int)status + "', '" + MGlobais.FormatarDataSQL(msk_data.Text) + "', '" + MGlobais.FormatarDataSQL(msk_data.Text) + "', '" + cb_turma.Text + "', '" + tb_matricula.Text + "', '" + tb_tombo.Text + "', '" + tb_email.Text + "')";
                    Banco.DML(vquery);
                    DialogResult res = MessageBox.Show("Salvo com êxito! Novo cadastro?", "Banco de Dados", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == res)
                    {
                        LimparForm();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    btn_confirmar.Enabled = false;
                    btn_confirmar.Cursor = Cursors.No;
                    DataTable dt = new DataTable();
                    string verificar = "SELECT T_LIVRO FROM tb_dadosaluno WHERE T_STATUS='" + (int)Global.BookStatus.Emprestado + "' AND T_MATRICULA='" + tb_matricula.Text + "'";
                    dt = Banco.DQL(verificar);
                    if (dt.Rows.Count > 0)
                    {
                        DialogResult ver = MessageBox.Show("Segundo o banco de dados, este aluno já está com algum(uns) livro(s). Deseja prosseguir com este cadastro? ", "Registro Encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == ver)
                        {
                            if (tb_email.Text != "")
                            {
                                if (tb_email.Text.Contains("@gmail.com") || tb_email.Text.Contains("@hotmail.com") || tb_email.Text.Contains("@outlook.com"))
                                {
                                    this.Cursor = Cursors.WaitCursor;
                                    Email.EnviarEmail(String.Format("Olá {0}.\n\nNotamos que você realizou a retirada do livro '{1}'. Você possue 8(oito) dias para efetuar a devolução.\n\nVale lembrar que você já está com pendência no sistema por outro(s) registro(s).\n\nEquipe EREMOL", tb_aluno.Text, tb_livro.Text), "BF Fácil - Retirada de Livro", tb_email.Text);
                                    this.Cursor = Cursors.Default;
                                }
                                else
                                {
                                    MessageBox.Show("E-Mail fornecido inválido", "SMTP Client", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    btn_confirmar.Enabled = true;
                                    btn_confirmar.Cursor = Cursors.Hand;
                                    return;
                                }
                            }

                            string vquery = @"INSERT INTO tb_dadosaluno (T_ALUNO, T_LIVRO, T_STATUS, T_DATA, T_DATAP, T_TURMA, T_MATRICULA, T_TOMBO, T_EMAIL) VALUES ('" + tA + "', '" + tL + "', '" + (int)status + "', '" + MGlobais.FormatarDataSQL(msk_data.Text) + "', '" + MGlobais.FormatarDataSQL(msk_data.Text) + "', '" + cb_turma.Text + "', '" + tb_matricula.Text + "', '" + tb_tombo.Text + "', '" + tb_email.Text + "')";
                            Banco.DML(vquery);
                            DialogResult res = MessageBox.Show("Salvo com Êxito! Novo Cadastro?", "Banco de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (DialogResult.Yes == res)
                            {
                                LimparForm();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        btn_confirmar.Enabled = false;
                        btn_confirmar.Cursor = Cursors.No;
                        if (tb_email.Text != "")
                        {
                            if (tb_email.Text.Contains("@gmail.com") || tb_email.Text.Contains("@hotmail.com") || tb_email.Text.Contains("@outlook.com"))
                            {
                                this.Cursor = Cursors.WaitCursor;
                                Email.EnviarEmail(String.Format("Olá {0}.\n\nNotamos que você realizou a retirada do livro '{1}'. Você possue 8(oito) dias para efetuar a devolução.\n\nEquipe EREMOL", tb_aluno.Text, tb_livro.Text), "BF Fácil - Retirada de Livro", tb_email.Text);
                                this.Cursor = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("E-Mail fornecido inválido", "SMTP Client", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                btn_confirmar.Enabled = true;
                                btn_confirmar.Cursor = Cursors.Hand;
                                return;

                            }
                        }

                        string vquery = @"INSERT INTO tb_dadosaluno (T_ALUNO, T_LIVRO, T_STATUS, T_DATA, T_DATAP, T_TURMA, T_MATRICULA, T_TOMBO, T_EMAIL) VALUES ('" + tA + "', '" + tL + "', '" + (int)status + "', '" + MGlobais.FormatarDataSQL(msk_data.Text) + "', '" + MGlobais.FormatarDataSQL(msk_data.Text) + "', '" + cb_turma.Text + "', '" + tb_matricula.Text + "', '" + tb_tombo.Text + "', '" + tb_email.Text + "')";
                        Banco.DML(vquery);
                        DialogResult res = MessageBox.Show("Salvo com êxito! Novo Cadastro?", "Banco de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == res)
                        {
                            LimparForm();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_RegistroLivroSaindo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                btn_confirmar.PerformClick();
            }
        }

        private void tb_matricula_Leave(object sender, EventArgs e)
        {
            /*
            if (File.Exists(@"C:\Biblioteca Fácil\Didáticos\Didaticos.db"))
            {
                DataTable dt = new DataTable();
                dt = Banco.dqlDidaticos(String.Format("select * from tb_alunos where matricula_id = '{0}'", tb_matricula.Text));
                if (dt.Rows.Count > 0)
                {
                    tb_aluno.Text = dt.Rows[0].Field<string>("t_nome");
                    cb_turma.Text = dt.Rows[0].Field<string>("t_turma");

                    dt = Banco.DQL("select T_EMAIL from tb_dadosaluno where T_ALUNO like '" + tb_aluno.Text + "%' and T_EMAIL != '' order by N_IDLIVROALUNO DESC LIMIT 1");
                    if (dt.Rows.Count > 0)
                    {
                        tb_email.Text = dt.Rows[0].Field<string>("T_EMAIL");
                    }
                }
                else
                {
                    return;
                }
            }
            */
        }

        private void tb_tombo_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Banco.DQL("select t_titulo from tb_livros where id = '" + tb_tombo.Text + "'");
            if (dt.Rows.Count > 0)
            {
                tb_livro.Text = dt.Rows[0].Field<string>("t_titulo");
                return;
            }
        }
    }
}
