using Octokit;
using System;
using System.IO;

namespace GithubController
{
    public class GitCredentials
    {
        protected string ProductHeaderValue = string.Empty;
        protected string AccessToken = string.Empty;
        protected string Owner = string.Empty;
        protected string Repos = string.Empty;
    }

    public class GitOperations : GitCredentials
    {
        private readonly GitHubClient GitClient;

        public GitOperations(string ProductHeaderValue, string AccessToken, string Owner, string Repos)
        {
            this.ProductHeaderValue = ProductHeaderValue;
            this.AccessToken = AccessToken;
            this.Owner = Owner;
            this.Repos = Repos;

            GitClient = new GitHubClient(new ProductHeaderValue(ProductHeaderValue))
            {
                Credentials = new Credentials(AccessToken)
            };
        }

        public async void DownloadFile(string SavePath, string GithubFilePath)
        {
            try
            {
                var RESTUL = await GitClient.Repository.Content.GetRawContent(Owner, Repos, GithubFilePath);
                var Base64 = System.Text.Encoding.UTF8.GetString(RESTUL);
                var FileBytes = Convert.FromBase64String(Base64);

                if (!Directory.Exists(Path.GetDirectoryName(SavePath)))
                    Directory.CreateDirectory(Path.GetDirectoryName(SavePath));

                File.WriteAllBytes(SavePath, FileBytes);
            }
            catch (FileNotFoundException)
            {
                //Tratar erro...
            }
        }

        public async void UploadFile(string FilePath, string GithubFilePath, string SHA, string CommitMessage = "")
        {
            if (!File.Exists(FilePath))
                throw new FileNotFoundException("O arquivo informado não foi localizado");
            else
            {
                try
                {
                    var Bytes = File.ReadAllBytes(FilePath);
                    var Base64 = Convert.ToBase64String(Bytes);

                    var FileRequest = new UpdateFileRequest((CommitMessage != "" ? CommitMessage : $"commit: {DateTime.Today.ToShortDateString()}"), Base64, SHA);
                    _ = await GitClient.Repository.Content.UpdateFile(Owner, Repos, GithubFilePath, FileRequest);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public async void FileDelete(string GithubFilePath, string SHA)
        {
            try
            {
                await GitClient.Repository.Content.DeleteFile(Owner, Repos, GithubFilePath, new DeleteFileRequest("File delet request", SHA));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async void CreateRepos(string ReposName)
        {
            try
            {
                _ = await GitClient.Repository.Create(new NewRepository(ReposName));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}