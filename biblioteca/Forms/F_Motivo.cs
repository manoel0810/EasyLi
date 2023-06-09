﻿using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class F_Motivo : Form
    {

        public int ExitFlag { get; private set; }

        public F_Motivo(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            ExitFlag = 0;
        }

        string matricula = string.Empty;
        string email = string.Empty;
        private readonly int ID = -1;

        int TamanhoChar = 0;

        private void F_Motivo_Load(object sender, EventArgs e)
        {

            DataTable dt = DatabaseController.DQL($"SELECT * FROM registry WHERE N_REGISTRYCODE='{ID}'");
            matricula = dt.Rows[0].Field<string>("T_MATRICULA");

            lb_matricula.Text = matricula;
            lb_matricula.ForeColor = Color.DarkBlue;

            lb_aluno.Text = dt.Rows[0].Field<string>("T_USER");
            lb_turma.Text = dt.Rows[0].Field<string>("T_TURMA");
            lb_livro.Text = dt.Rows[0].Field<string>("T_LIVRO");
            lb_data.Text = dt.Rows[0].Field<DateTime>("T_DATA").ToShortDateString();

            email = dt.Rows[0].Field<string>("T_EMAIL");

            rb_DCP.Enabled = true;
            tb_outro.Enabled = false;
            lb_caracteres.Visible = false;

            KeyPreview = true;
        }

        private void Outros(object sender, EventArgs e)
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

        private void OutroTextChenged(object sender, EventArgs e)
        {
            TamanhoChar = tb_outro.Text.Length;
            lb_caracteres.Text = TamanhoChar.ToString() + "/100";
        }

        private void RegClick(object sender, EventArgs e)
        {
            string[] motivo = new string[3];
            motivo[0] = "Declara como perdido";
            motivo[1] = "Declara já ter devolvido, todavia não está na biblioteca";
            motivo[2] = "Transferido e não efetuada a devolução";

            string motivoEscolhido = "";

            if (rb_DCP.Checked)
                motivoEscolhido = motivo[0];
            else if (rb_DJD.Checked)
                motivoEscolhido = motivo[1];
            else if (rb_TRANS.Checked)
                motivoEscolhido = motivo[2];
            if (rb_OUT.Checked)
            {
                if (String.IsNullOrEmpty(tb_outro.Text))
                {
                    MessageBox.Show("Defina o motivo para registr", "Motivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (MGlobais.AntiSQLInjection(tb_outro.Text))
                {
                    MessageBox.Show("Sequências/caracteres inválidos no campo de texto do motivo. Remova todas as ocorrências inválidas", "Motivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                motivoEscolhido = tb_outro.Text;
            }

            bool EnviarEmail = false;
            if (!String.IsNullOrEmpty(email))
            {
                DialogResult res = MessageBox.Show("Este aluno possue uma E-Mail vinculada ao cadastro. Deseja notificar o usuário desta ação?", "Motivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == res)
                    EnviarEmail = true;
            }

            DatabaseController.DQL($"UPDATE users SET user_status = '{(int)Global.UserState.Blocked}' WHERE code = '{matricula}'");
            string query = "UPDATE registry SET T_NOTAS = @param1 WHERE N_REGISTRYCODE = @param2";
            object[] values = new object[]
            {
                motivoEscolhido,
                ID
            };

            DatabaseController.InsertData(query, values);
            if (EnviarEmail)
            {
                TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
                string Livro = $"{textInfo.ToTitleCase(lb_livro.Text.ToLower())}";

                string MSG = string.Format("Estamos notificando você, para informa-lhe que seu cadastro no sistema do EasyLi está bloqueado. Esta ação foi baseada na falta da devolução de um título: {0}, em {1}. Para regularizar sua situação, entre em contato com a sua instituição.", Livro, lb_data.Text);
                string Body = EmailFormatProvider.FormartString(EmailFormatProvider.EmailFormat.BlockRequest, new string[] { MSG });
                Email.EnviarEmail(Body, "EasyLi", email);
            }

            MessageBox.Show("O usuário foi bloquado no sistema com êxito", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ExitFlag = 1;
            Close();
        }

        private void F_Motivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
