using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_Motivo : Form
    {
        private int ID = -1;
        public int ExitFlag { get; private set; }

        public F_Motivo(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            ExitFlag = 0;
        }

        string matricula = string.Empty;
        string email = string.Empty;
        int modo = -1;

        int TamanhoChar = 0;
        int idU = 0;

        private void F_Motivo_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string vquery = "SELECT * FROM tb_dadosaluno WHERE N_IDLIVROALUNO=" + ID;
            dt = Banco.DQL(vquery);

            idU = ID;

            matricula = dt.Rows[0].Field<string>("T_MATRICULA");
            if (matricula != "")
            {
                lb_matricula.Text = matricula;
                lb_matricula.ForeColor = Color.DarkBlue;
            }
            else
            {
                lb_matricula.Text = "S/ Matrícula";
                lb_matricula.ForeColor = Color.DarkRed;
                ExitFlag =  1;
            }

            lb_aluno.Text = dt.Rows[0].Field<string>("T_ALUNO");
            lb_turma.Text = dt.Rows[0].Field<string>("T_TURMA");
            lb_livro.Text = dt.Rows[0].Field<string>("T_LIVRO");
            lb_data.Text = dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString();

            email = dt.Rows[0].Field<string>("T_EMAIL");

            rb_DCP.Enabled = true;
            tb_outro.Enabled = false;
            lb_caracteres.Visible = false;

            this.KeyPreview = true;
        }

        private void rb_OUT_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_OUT.Checked)
            {
                tb_outro.Enabled = true;
                lb_caracteres.Visible = true;
            }
            else
            {
                tb_outro.Enabled = false;
                lb_caracteres.Visible = false;

            }
        }

        private void tb_outro_TextChanged(object sender, EventArgs e)
        {
            if (tb_outro.Text.Contains("\'"))
            {
                tb_outro.Text.Replace("\'", "*");
            }
            TamanhoChar = tb_outro.Text.Length;
            lb_caracteres.Text = TamanhoChar.ToString() + "/100";
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            string[] motivo = new string[3];
            motivo[0] = "Declara como perdido";
            motivo[1] = "Declara já ter devolvido, todavia não está na biblioteca";
            motivo[2] = "Transferido e não efetuada a devolução";

            string motivoEscolhido = "";

            if (rb_DCP.Checked)
            {
                motivoEscolhido = motivo[0];
            }
            if (rb_DJD.Checked)
            {
                motivoEscolhido = motivo[1];
            }
            if (rb_TRANS.Checked)
            {
                motivoEscolhido = motivo[2];
            }
            if (rb_OUT.Checked)
            {
                if (String.IsNullOrEmpty(tb_outro.Text))
                {
                    MessageBox.Show("Defina um motivo", "Motivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                motivoEscolhido = tb_outro.Text;
            }

            if (matricula != "")
            {
                if (DialogResult.Yes == MessageBox.Show("Este aluno possue uma matrícula vinculada ao cadastro.\nDeseja bloquear esta matrícula?", "Motivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    modo = (int)Global.BookStatus.Bloqueado;
                else
                    modo = (int)Global.BookStatus.Perdido;
                
            }

            int RespostaEmail = 0;
            if (String.IsNullOrEmpty(email) == false)
            {
                DialogResult res = MessageBox.Show("Este aluno possue uma E-Mail vinculada ao cadastro.\nDeseja notificar o usuário desta ação?", "Motivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                {
                    RespostaEmail = 1;
                }
            }

            string vquery = "UPDATE tb_dadosaluno SET T_STATUS = '" + modo + "', T_NOTAS = '" + motivoEscolhido + "' WHERE N_IDLIVROALUNO=" + idU;
            Banco.DQL(vquery);
            if (RespostaEmail == 1)
            {
                string estadoM = "";
                if (modo == (int)Global.BookStatus.Bloqueado)
                    estadoM = "Suspenço";           
                else
                    estadoM = "Ativo";
                
                string subject = "Notificação - BF Fácil";
                string body = String.Format("Olá {0}, estamos notificando você a respeito do livro {1} que foi pego em {2}.\n\nO livro não foi registrado como devolvido e com isto, este registro ficou como pendência ativa.\n\nO motivo relatado foi: ({3}). Seu cadastro está {4}.\n\nEmitido por: {5}\n\nEquipe EREMOL", lb_aluno.Text, lb_livro.Text, lb_data.Text, motivoEscolhido, estadoM, Globais.user);
                Email.EnviarEmail(body, subject, email);
            }

            if (matricula != "")
            {
                int estadoM;
                if (modo == (int)Global.BookStatus.Bloqueado)
                    estadoM = (int)Global.BookStatus.Bloqueado;
                else
                    estadoM = (int)Global.BookStatus.Perdido;

                if (DatabaseController.DQL("SELECT * FROM tb_matriculas WHERE T_MATRICULA = '" + lb_matricula.Text + "'").Rows.Count == 0)
                {
                    string query = "INSERT INTO tb_matriculas (T_MATRICULA, T_ALUNO, T_ESTADO) VALUES ('" + matricula + "', '" + MGlobais.ValidarString(lb_aluno.Text) + "', '" + estadoM + "')";
                    Banco.DML(query);
                }
                else
                {
                    string query = "UPDATE tb_matriculas SET T_ESTADO = '" + estadoM + "' WHERe T_MATRICULA = '" + lb_matricula.Text + "'";
                    Banco.DML(query);
                }
            }


            MessageBox.Show("Alterado Com êxito", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ExitFlag =  1;
            Close();
        }

        private void F_Motivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
