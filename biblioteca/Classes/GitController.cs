using biblioteca;
using Octokit;
using System;
using System.IO;
using System.Linq;
//using System.Security.Cryptography;
using System.Threading.Tasks;

namespace GithubController
{
    /// <summary>
    /// Guarda as credênciais de acesso à API do Github
    /// </summary>

    public class GitCredentials
    {
        /// <summary>
        /// Header de identificação do produto
        /// </summary>
        protected string ProductHeaderValue = string.Empty;
        /// <summary>
        /// Token de acesso ao Github
        /// </summary>
        protected string AccessToken = string.Empty;
        /// <summary>
        /// Proprietário
        /// </summary>
        protected string Owner = string.Empty;
        /// <summary>
        /// Nome do repositório
        /// </summary>
        protected string Repos = string.Empty;
    }

    /// <summary>
    /// Controla as operações do Github
    /// </summary>

    public class GitOperations : GitCredentials
    {
        private readonly GitHubClient GitClient;

        /// <summary>
        /// Inicial uma instância do <b>GitOperations</b> para controle assíncrono de download, upload, etc.
        /// </summary>
        /// <param name="ProductHeaderValue">Header de identificação do produto</param>
        /// <param name="AccessToken">Token de acesso ao Github</param>
        /// <param name="Owner">Proprietário</param>
        /// <param name="Repos">Nome do repositório</param>

        public GitOperations(string ProductHeaderValue, string AccessToken, string Owner, string Repos)
        {
            Global.Log.Log($"GITHUB_API: Client initialization");

            this.ProductHeaderValue = ProductHeaderValue;
            this.AccessToken = AccessToken;
            this.Owner = Owner;
            this.Repos = Repos;

            GitClient = new GitHubClient(new ProductHeaderValue(ProductHeaderValue))
            {
                Credentials = new Credentials(AccessToken)
            };
        }

        /// <summary>
        /// Faz o download de um arquivo hospedado no Github, usando as credênciais carregadas 
        /// </summary>
        /// <param name="SavePath">Local para salvar o arquivo baixado</param>
        /// <param name="GithubFilePath">Local do arquivo dentro do <b>repositório</b> do Github</param>
        /// <returns></returns>

        public async Task DownloadFile(string SavePath, string GithubFilePath)
        {
            Global.Log.Log($"GITHUB_API: File download request > $savepath: [{SavePath}] | $githubpath: [{GithubFilePath}]");

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
                Global.Log.Log($"GITHUB_API: FileNotFoundException");
            }
        }

        /// <summary>
        /// Faz o upload de um arquivo local para o Github e o atualiza no servidor
        /// </summary>
        /// <param name="FilePath">Local do arquivo de origem</param>
        /// <param name="GithubFilePath">Local do arquivo dentro do <b>repositório</b> do Github</param>
        /// <param name="CommitMessage">Mensagem para commit</param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>

        public async Task UploadFile(string FilePath, string GithubFilePath, string CommitMessage = "")
        {
            Global.Log.Log($"GITHUB_API: UploadFile request > $filepath: [{FilePath}] | $githubpath: [{GithubFilePath}]");

            if (!File.Exists(FilePath))
            {
                Global.Log.Log($"GITHUB_API: FileNotFoundException > [{FilePath}]");
                throw new FileNotFoundException("O arquivo informado não foi localizado");
            }
            else
            {
                try
                {
                    string SHA = await GetSHA(GithubFilePath);
                    var Bytes = File.ReadAllBytes(FilePath);
                    var Base64 = Convert.ToBase64String(Bytes);

                    /*
                    if(await IsSameFile(GithubFilePath, Base64, SHA, AccessToken))
                    {
                        return;
                    }
                    */

                    var FileRequest = new UpdateFileRequest((CommitMessage != "" ? CommitMessage : $"commit: {DateTime.Today.ToShortDateString()}"), Base64, SHA);
                    _ = await GitClient.Repository.Content.UpdateFile(Owner, Repos, GithubFilePath, FileRequest);
                }
                catch (Exception e)
                {
                    Global.Log.Log($"GITHUB_API: {e.Message}");
                    throw e;
                }
            }
        }

        /// <summary>
        /// Crie um arquivo no <b>repositório</b> do Github
        /// </summary>
        /// <param name="FilePath">Local do arquivo de origem</param>
        /// <param name="GithubFilePath">Local do arquivo dentro do <b>repositório</b> do Github</param>
        /// <param name="CommitMessage">Mensagem para commit</param>
        /// <returns></returns>

        public async Task FileCreate(string FilePath, string GithubFilePath, string CommitMessage = "")
        {
            if (await FileExists(GithubFilePath))
            {
                Global.Log.Log($"GITHUB_API: FileCreate request > $filepath: [{FilePath}] | $githubpath: [{GithubFilePath}] :: alredy exists. call returned");
                return;
            }

            var Bytes = File.ReadAllBytes(FilePath);
            var Base64 = Convert.ToBase64String(Bytes);
            var CreateFileRequeste = new CreateFileRequest(CommitMessage, Base64, false);

            _ = await GitClient.Repository.Content.CreateFile(Owner, Repos, GithubFilePath, CreateFileRequeste);
        }

        /// <summary>
        /// Apaga um arquivo do <b>repositório</b> do Github
        /// </summary>
        /// <param name="GithubFilePath">Local do arquivo dentro do <b>repositório</b> do Github</param>
        /// <param name="SHA">SHA do arquivo que será apagado retornado pela API do <b>Github</b></param>
        /// <returns></returns>

        public async Task FileDelete(string GithubFilePath, string SHA)
        {
            try
            {
                Global.Log.Log($"GITHUB_API: FileDelete request > $githubpath: [{GithubFilePath}] | $sha: [{SHA}]");
                await GitClient.Repository.Content.DeleteFile(Owner, Repos, GithubFilePath, new DeleteFileRequest("File delet request", SHA));
            }
            catch (Exception e)
            {
                Global.Log.Log($"GITHUB_API: {e.Message}");
                throw e;
            }
        }

        /// <summary>
        /// Obtém o <b>SHA</b> associado a um arquivo no repositório do Github
        /// </summary>
        /// <param name="GithubFilePath">Local do arquivo dentro do <b>repositório</b> do Github</param>
        /// <returns></returns>

        public async Task<string> GetSHA(string GithubFilePath)
        {
            try
            {
                var ExistingContents = await GitClient.Repository.Content.GetAllContents(Owner, Repos, GithubFilePath);
                var ExistingFile = ExistingContents[0];
                Global.Log.Log($"GITHUB_API: GetSHA request > $githubpath: [{GithubFilePath}] :: SHA = {ExistingFile.Sha}");

                return ExistingFile.Sha;
            }
            catch (Exception e)
            {
                Global.Log.Log($"GITHUB_API: {e.Message}");
                throw e;
            }
        }

        /// <summary>
        /// Verifica se um arquivo já existe no caminho especificado dentro do <b>repositório</b> do Github
        /// </summary>
        /// <param name="GithubFilePath">Local do arquivo dentro do <b>repositório</b> do Github</param>
        /// <returns></returns>

        public async Task<bool> FileExists(string GithubFilePath)
        {
            try
            {
                var contents = await GitClient.Repository.Content.GetAllContents(Owner, Repos);
                var L = contents.ToList();
                bool Result = L.Exists(c => c.Path == GithubFilePath);
                Global.Log.Log($"GITHUB_API: FileExists request > $githubpath: [{GithubFilePath}] :: Exists? = {Result}");

                return Result;
            }
            catch (NotFoundException)
            {
                Global.Log.Log($"GITHUB_API: NotFoundException");
                return false;
            }
            catch (ApiException ex)
            {
                Global.Log.Log($"GITHUB_API: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Cria um novo repositório no Github
        /// </summary>
        /// <param name="ReposName">Nome do novo repositório</param>

        public async void CreateRepos(string ReposName)
        {
            try
            {
                Global.Log.Log($"GITHUB_API: CreateRepos request > $reposName: [{ReposName}]");
                _ = await GitClient.Repository.Create(new NewRepository(ReposName));
            }
            catch (Exception e)
            {
                Global.Log.Log($"GITHUB_API: {e.Message}");
                throw e;
            }
        }

        /*
         * TODO: Modificar o método a baixo para que o mesmo seja capaz de verificar se o arquivo no Github foi alterado
         * Se foi: Permitir no método Update que a atualização seja feita
         * Se não: Retornar na chamada do método Update sem modificar o arquivo no Github
         */

        /*
        public async Task<bool> IsSameFile(string GithubFilePath, string FileBase64, string SHA, string Token)
        {
            string accessToken = Token;
            string fileContent = FileBase64;
            string githubFileHash = SHA;

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                httpClient.DefaultRequestHeaders.Add("If-None-Match", $"\"{githubFileHash}\"");

                var content = new StringContent(fileContent);
                var response = await httpClient.PutAsync($"https://api.github.com/repos/{Owner}/{Repos}/contents/{GithubFilePath}", content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    return false;
                }
                else
                {
                    // O arquivo é diferente do que está no GitHub
                    return false;
                }
            }
        }*/
    }
}