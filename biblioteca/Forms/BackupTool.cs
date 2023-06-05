using System;
using System.Windows.Forms;

namespace biblioteca.Forms
{
    public partial class BackupTool : Form
    {
        /// <summary>
        /// Define se o usuário atual será desconectado após a conclusão das ações desse formulário
        /// </summary>

        public bool Logout { get; private set; }

        public BackupTool()
        {
            InitializeComponent();
            Logout = false;
        }

        private void Denifirconfiguracoes_Click(object sender, EventArgs e)
        {
            GitProperties Props = new GitProperties();
            Props.ShowDialog();
            Props.Dispose();
        }

        private async void Upload_Click(object sender, EventArgs e)
        {
            if (!VerificarGitController())
            {
                MessageBox.Show("Não foi possível verificar as credenciais de acesso ao serviço", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!MGlobais.Internet())
            {
                MessageBox.Show("Não foi possível se conectar com a internet", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                StartAnimation();
                DatabaseController.KillConnection();

                bool Exists = await Global.GitController.FileExists(Global.DATABASE_NAME);
                if (Exists)
                    await Global.GitController.UploadFile($"{Application.StartupPath}\\{Global.DATABASE_NAME}", $"{Global.DATABASE_NAME}");
                else
                    await Global.GitController.FileCreate($"{Application.StartupPath}\\{Global.DATABASE_NAME}", $"{Global.DATABASE_NAME}");

                AnimationStop();
                MessageBox.Show("Upload concluído com êxito", "Backups", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado ao executar esta ação.\nErro > {ex.Message}", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /*
         * TODO: Antes de fazer o download do backup, verificar se o arquivo local não é mais recente!
         */

        private async void Download_Click(object sender, EventArgs e)
        {
            if (!VerificarGitController())
            {
                MessageBox.Show("Não foi possível verificar as credenciais de acesso ao serviço", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!MGlobais.Internet())
            {
                MessageBox.Show("Não foi possível se conectar com a internet", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var Seguir = MessageBox.Show("Ao efetuar a atualização da base de dados, o usuário atual será desconectado. Deseja prosseguir?", "Backups", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Seguir != DialogResult.Yes)
                return;

            try
            {
                StartAnimation();
                if (await Global.GitController.FileExists(Global.DATABASE_NAME))
                {
                    DatabaseController.KillConnection();
                    await Global.GitController.DownloadFile($"{Application.StartupPath}\\{Global.DATABASE_NAME}", Global.DATABASE_NAME);

                    Logout = true;
                    AnimationStop();
                    MessageBox.Show("O banco de dados local foi atualizado para o mesmo na núvem", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    AnimationStop();
                    MessageBox.Show("Não foi possível encontrar o arquivo de backup na núvem", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado ao executar esta ação.\nErro > {ex.Message}", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool VerificarGitController()
        {
            if (Global.GitController == null)
            {
                if (string.IsNullOrWhiteSpace(Properties.Settings.Default.GithubToken) ||
                    string.IsNullOrWhiteSpace(Properties.Settings.Default.GithubOwner) ||
                    string.IsNullOrWhiteSpace(Properties.Settings.Default.GithubRepos))
                {
                    return false;
                }
                else
                {
                    Global.GitController = new GithubController.GitOperations("writeanyvalueanything", Properties.Settings.Default.GithubToken, Properties.Settings.Default.GithubOwner, Properties.Settings.Default.GithubRepos);
                    return true;
                }
            }
            else
                return true;
        }

        private void StartAnimation()
        {
            Upload.Enabled = false;
            Download.Enabled = false;

            WaitLabel.Visible = true;
            Progress.Visible = true;
            Progress.Style = ProgressBarStyle.Marquee;
            Progress.MarqueeAnimationSpeed = 25;
        }

        private void AnimationStop()
        {
            Upload.Enabled = true;
            Download.Enabled = true;

            WaitLabel.Visible = false;
            Progress.Visible = false;
            Progress.Style = ProgressBarStyle.Continuous;
            Progress.MarqueeAnimationSpeed = 0;
        }
    }
}
