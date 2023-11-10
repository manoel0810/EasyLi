using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace biblioteca.Forms
{
    public partial class UserControl : Form
    {
        private const int DGVMargin = 15;
        private Global.UserState CurrentUserState = Global.UserState.NotDefined;

        public UserControl()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (Usuarios.SelectedRows.Count == 0)
                return;

            if (StatusChenge.Checked)
            {
                string MSG;
                if (CurrentUserState == Global.UserState.Free)
                    MSG = "O usuário atual será bloqueado e não poderá fazer novos empréstimos no sistema. Deseja realmente bloquear o usuário e continiar com essa ação?";
                else if (CurrentUserState == Global.UserState.Blocked)
                    MSG = "O usuário atual será desbloqueado do sistema e poderá fazer novos empréstimos. Deseja continuar?";
                else
                    MSG = "O estado de cadastro do usuário atual está indefinido. Será automaticamente modificado para 'Desbloqueado'";

                if (CurrentUserState != Global.UserState.NotDefined)
                {
                    if (DialogResult.Yes == MessageBox.Show(MSG, "Controle de usuários", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        ChengeUserStatus(CurrentUserState == Global.UserState.Free ? Global.UserState.Blocked : Global.UserState.Free);
                    else
                        return;
                }
                else
                    ChengeUserStatus(Global.UserState.Free);
            }

            string query = "UPDATE users SET user_name = @param1, user_email = @param2 WHERE code = @param3";
            object[] values = new object[]
            {
                Nome.Text.Trim(),
                Email.Text.Trim(),
                Matricula.Text
            };

            DatabaseController.InsertData(query, values);
            Usuarios.CurrentRow.Cells[1].Value = Nome.Text.Trim();

            MessageBox.Show("Os dados do usuário foram atualizados com êxito", "Controle de usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (Usuarios.SelectedRows.Count == 0)
                return;

            if (DialogResult.Yes == MessageBox.Show("Ao apagar um usuário do sistema, todo e qualquer registro associado ao mesmo também será apagado. Deseja continuar?", "Apagar usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                DatabaseController.DataManipulationLanguage($"delete from registry where T_MATRICULA = '{Matricula.Text}'");
                DatabaseController.DataManipulationLanguage($"delete from users where code = '{Matricula.Text}'");

                Usuarios.Rows.Remove(Usuarios.CurrentRow);
                MessageBox.Show("Todos os dados do usuário foram apagados com êxito", "Controle de usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void UserControl_Load(object sender, EventArgs e)
        {
            Usuarios.DataSource = DatabaseController.DataQueryLanguage("select code as 'Matricula', user_name as 'Nome completo' from users");

            Usuarios.Columns[0].Width = 60;
            Usuarios.Columns[1].Width = Usuarios.Width - (Usuarios.Columns[0].Width + DGVMargin);

            MGlobais.SetNumericFieldOnly(ref FiltroMatricula);
            KeyPreview = true;
        }

        private void Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (Usuarios.SelectedRows.Count > 0)
            {
                DataTable UserInformation = DatabaseController.DataQueryLanguage($"select * from users where code = '{Usuarios.SelectedRows[0].Cells[0].Value}'");
                Nome.Text = UserInformation.Rows[0].Field<string>("user_name");
                Email.Text = UserInformation.Rows[0].Field<string>("user_email");
                Matricula.Text = UserInformation.Rows[0].Field<string>("code");

                if (Enum.IsDefined(typeof(Global.UserState), (int)UserInformation.Rows[0].Field<Int64>("user_status")))
                    CurrentUserState = (Global.UserState)(int)UserInformation.Rows[0].Field<Int64>("user_status");
                else
                    CurrentUserState = Global.UserState.NotDefined;

                StatusChenge.Checked = false;
                CheckUserState();
            }
        }

        private void ChengeUserStatus(Global.UserState Status)
        {
            DatabaseController.DataManipulationLanguage($"update users set user_status = '{(int)Status}' where code = '{Matricula.Text}'");
            CurrentUserState = Status;

            StatusChenge.Checked = false;
            CheckUserState();
        }

        private void CheckUserState()
        {
            switch (CurrentUserState)
            {
                case Global.UserState.Blocked:
                    Status.ForeColor = Color.DarkRed;
                    Status.Text = "BLOQUEADO";
                    StatusChenge.Text = "Desbloquear";
                    break;
                case Global.UserState.Free:
                    Status.ForeColor = Color.Green;
                    Status.Text = "DESBLOQUEADO";
                    StatusChenge.Text = "Bloquear";
                    break;
                case Global.UserState.NotDefined:
                    Status.ForeColor = Color.Magenta;
                    Status.Text = "Indefinido";
                    StatusChenge.Text = "Redefinir";
                    break;
            }
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Voltar.PerformClick();
            else if (e.KeyCode == Keys.Enter)
                Salvar.PerformClick();
        }

        private void FiltroNome_TextChanged(object sender, EventArgs e)
        {
            if (Usuarios.SelectedRows.Count == 0)
                return;

            if (FiltroNome.Text.Trim().Length == 0)
                Usuarios.DataSource = DatabaseController.DataQueryLanguage("select code as 'Matricula', user_name as 'Nome completo' from users");
            else if (FiltroNome.Text.Trim().Length >= 3)
                Usuarios.DataSource = DatabaseController.DataQueryLanguage($"select code as 'Matricula', user_name as 'Nome completo' from users where user_name like '%{FiltroNome.Text.Replace("'", "''")}%'");
        }

        private void FiltroMatricula_TextChanged(object sender, EventArgs e)
        {
            if (Usuarios.SelectedRows.Count == 0)
                return;

            if (FiltroMatricula.Text.Trim().Length == 0)
                Usuarios.DataSource = DatabaseController.DataQueryLanguage("select code as 'Matricula', user_name as 'Nome completo' from users");
            else if (FiltroMatricula.Text.Trim().Length >= 3)
                Usuarios.DataSource = DatabaseController.DataQueryLanguage($"select code as 'Matricula', user_name as 'Nome completo' from users where code like '%{FiltroMatricula.Text}%'");
        }
    }
}
