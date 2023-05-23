using System;
using System.Media;
using System.Windows.Forms;

namespace GestaoBanco
{
    public partial class F_LBanco : Form
    {
        public F_LBanco()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_mov_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_mov.Checked)
            {
                cb_dev.Enabled = true;
                cb_emp.Enabled = true;
                cb_todos.Enabled = true;
            }
            else
            {
                cb_dev.Enabled = false;
                cb_dev.Checked = false;
                cb_emp.Enabled = false;
                cb_emp.Checked = false;
                cb_todos.Enabled = false;
                cb_todos.Checked = false;
            }
        }

        private void F_LBanco_Load(object sender, EventArgs e)
        {
            if (Globais.con == 1)
            {
                btn_limpar.Enabled = true;
                btn_limpar.Cursor = Cursors.Hand;
            }
            else
            {
                btn_limpar.Enabled = false;
                btn_limpar.Cursor = Cursors.No;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            SystemSound son = SystemSounds.Question;
            son.Play();
            DialogResult res = MessageBox.Show("Deseja realmente continuar? Estas alterações serão irreversíveis", "Banco de Dados", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == res)
            {
                Cursor = Cursors.WaitCursor;
                string vquery = "";
                if (rb_mov.Checked)
                {
                    if (cb_dev.Checked == false && cb_emp.Checked == false)
                    {
                        cb_todos.Checked = true;
                    }
                    if (cb_dev.Checked)
                    {
                        cb_emp.Checked = false;
                        cb_todos.Checked = false;
                        //Comandos
                        vquery = "DELETE FROM tb_dadosaluno WHERE T_ESTADO=Devolvido";
                    }
                    if (cb_emp.Checked)
                    {
                        cb_dev.Checked = false;
                        cb_todos.Checked = false;
                        //Comandos
                        vquery = "DELETE FROM tb_dadosaluno WHERE T_STATUS=Emprestado";
                    }
                    if (cb_todos.Checked)
                    {
                        cb_dev.Checked = false;
                        cb_emp.Checked = false;
                        //Comandos
                        vquery = "DELETE FROM tb_dadosaluno";
                    }

                }
                if (rb_age.Checked)
                {
                    vquery = "DELETE FROM tb_agendamento";
                }
                if (rb_liv.Checked)
                {
                    vquery = "DELETE FROM tb_eventos";
                }
                if (rb_log.Checked)
                {
                    vquery = "DELETE FROM tb_dadosaluno";
                }
                if (rb_tur.Checked)
                {
                    vquery = "DELETE FROM tb_turmas";
                }
                if (rb_todos.Checked)
                {
                    string query = "";

                    query = "DELETE FROM tb_dadosaluno";
                    Banco.Manipular(query);
                    query = "DELETE FROM tb_agendamento";
                    Banco.Manipular(query);
                    query = "DELETE FROM tb_eventos";
                    Banco.Manipular(query);
                    query = "DELETE FROM tb_turmas";
                    Banco.Manipular(query);
                }
                Banco.Manipular(vquery);
                SystemSound sond = SystemSounds.Asterisk;
                sond.Play();
                Cursor = Cursors.Default;               
            }
            else
            {
                return;
            }
        }
    }
}
