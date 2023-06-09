using System;
using System.Windows.Forms;

namespace biblioteca.Forms
{
    public partial class GitProperties : Form
    {
        public GitProperties()
        {
            InitializeComponent();
        }

        private void RemoverAcesso_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.GithubOwner = "";
            Properties.Settings.Default.GithubRepos = "";
            Properties.Settings.Default.GithubToken = "";
            Properties.Settings.Default.Save();

            MessageBox.Show("As configurações de acesso ao serviço do Github para backup foram apagadas", "Configurações - Github", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void Calcelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aplicar_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
                if (c is TextBox)
                    if (string.IsNullOrWhiteSpace(c.Text))
                    {
                        MessageBox.Show("Informe todos os campos corretamente", "Configurações - Githu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

            var Resposta = MessageBox.Show("Atenção\nNós, assim como o serviço do Github não nos reponsabilizamos por eventuais perdas de dados. Tenha certeza que todas as informações estão corretas e o seu serviço do Github foi configurado corretamente na plataforma online. Deseja continuar?", "Configurações - Githu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resposta != DialogResult.Yes)
                return;

            Properties.Settings.Default.GithubOwner = Proprietario.Text;
            Properties.Settings.Default.GithubRepos = Repositorio.Text;
            Properties.Settings.Default.GithubToken = Token.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("As configurações de acesso ao serviço do Github para backup foram registradas com êxito", "Configurações - Github", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void GitProperties_Load(object sender, EventArgs e)
        {
            Proprietario.Text = Properties.Settings.Default.GithubOwner;
            Repositorio.Text = Properties.Settings.Default.GithubRepos;
            Token.Text = Properties.Settings.Default.GithubToken;
        }
    }
}
