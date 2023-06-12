using System;
using System.Threading;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Login : Form
    {
        private int TryCount = 0;
        private readonly string MessageHeader = "EasyLi";

        public Login()
        {
            InitializeComponent();
        }

        private void MenuThread()
        {
            Application.Run(new Menu());
        }

        private void NewUser(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var obj = new F_NovoUsuario();
            obj.ShowDialog();
            obj?.Dispose();
        }

        private void EasyLiKeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EnterButton.PerformClick();
        }

        private void EnterClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_usuario.Text) || string.IsNullOrWhiteSpace(tb_senha.Text))
            {
                MessageBox.Show("Informe todos os dados corretamente", MessageHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MGlobais.AntiSQLInjection(tb_usuario.Text) || MGlobais.AntiSQLInjection(tb_senha.Text))
            {
                MessageBox.Show("Erro ao validar os dados de entrada. Verifique e tente novamente", MessageHeader, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_usuario.Clear(); tb_senha.Clear();
                tb_usuario.Focus();
                return;
            }

            if (MGlobais.Login(tb_usuario.Text, tb_senha.Text))
            {
                Close();
                Thread Menus = new Thread(MenuThread);
                Menus.SetApartmentState(ApartmentState.STA);
                Menus.Start();
                Close();
            }
            else
            {
                if (TryCount < 2)
                {
                    MessageBox.Show("Usuário e/ou senha errado(s). Verifique seus dados.", MessageHeader, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TryCount += 1;

                    tb_senha.Clear();
                    tb_senha.Focus();
                    return;
                }
                else if (TryCount == 2)
                {
                    if (DialogResult.Yes == MessageBox.Show("Parece que você esqueceu sua senha de login. Deseja tentar recuperar o seu acesso?", MessageHeader, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        TryCount = 0;

                        F_EsqueciSenha PassRecovery = new F_EsqueciSenha();
                        PassRecovery.ShowDialog();
                        PassRecovery?.Dispose();
                        return;
                    }
                    else
                    {
                        TryCount = 0;
                        return;
                    }
                }
            }
        }

        private void ExitClick(object sender, EventArgs e)
        {
            //Exit without erros
            Environment.Exit(0x0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Global.DatabaseUpdateController != null)
                if (Global.DatabaseUpdateController.AlreadyChecked)
                    return;
                else
                {
                    if (Global.DatabaseUpdateController.IsUpdated() == false)
                        Global.DatabaseUpdateController.InstallUpdates();
                }
        }
    }
}
