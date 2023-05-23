using System;
using System.Collections.Generic;
using System.Linq;

namespace biblioteca
{
    class Google_Drive
    {
        private static Google.Apis.Auth.OAuth2.UserCredential Autenticar()
        {
            Google.Apis.Auth.OAuth2.UserCredential credenciais;

            using (var stream = new System.IO.FileStream("client_id.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                var diretorioAtual = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                var diretorioCredenciais = System.IO.Path.Combine(diretorioAtual, "credential");

                credenciais = Google.Apis.Auth.OAuth2.GoogleWebAuthorizationBroker.AuthorizeAsync(
                    Google.Apis.Auth.OAuth2.GoogleClientSecrets.Load(stream).Secrets,
                    new[] { Google.Apis.Drive.v3.DriveService.Scope.Drive },
                    "user",
                    System.Threading.CancellationToken.None,
                    new Google.Apis.Util.Store.FileDataStore(diretorioCredenciais, true)).Result;
            }

            return credenciais;
        }

        private static Google.Apis.Drive.v3.DriveService AbrirServico(Google.Apis.Auth.OAuth2.UserCredential credenciais)
        {
            return new Google.Apis.Drive.v3.DriveService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credenciais
            });
        }

        public static void IniciarProtocolos(bool createDirectory = false, bool listFiles = false, bool downloadFile = false, bool uploadFile = false, bool deleteFile = false, bool movToTrash = false, string directoryName = "", string fileDeleteName = "", string path = "", string fileDonwloadedDestiny = "", string fileToDonwloadName = "", string filenameTrash = "")
        {
            var credenciais = Autenticar();
            using (var servico = AbrirServico(credenciais))
            {
                if (listFiles == true)
                {
                    ListarArquivos(servico);
                }
                if (createDirectory == true)
                {
                    CriarDiretorio(servico, directoryName);
                }
                if (deleteFile == true)
                {
                    ProcurarArquivoId(servico, fileDeleteName);
                    DeletarItem(servico, fileDeleteName);
                }
                if (uploadFile == true)
                {
                    Upload(servico, path);
                }
                if (downloadFile == true)
                {
                    Download(servico, fileToDonwloadName, fileDonwloadedDestiny);
                }
                if (movToTrash == true)
                {
                    MoverParaLixeira(servico, filenameTrash);
                }
            }
        }

        private static Array ListarArquivos(Google.Apis.Drive.v3.DriveService servico)
        {
            var request = servico.Files.List();
            request.Q = "trashed=false";
            request.Fields = "files(id, name)";
            var resultado = request.Execute();
            var arquivos = resultado.Files;
            string collection = string.Empty;
            if (arquivos != null && arquivos.Any())
            {
                foreach (var arquivo in arquivos)
                {
                    collection += arquivo.Name.ToString() + "\n";
                }
            }
            return collection.ToArray();
        }

        private static void CriarDiretorio(Google.Apis.Drive.v3.DriveService servico, string nomeDiretorio)
        {
            var diretorio = new Google.Apis.Drive.v3.Data.File();
            diretorio.Name = nomeDiretorio;
            diretorio.MimeType = "application/vnd.google-apps.folder";
            var request = servico.Files.Create(diretorio);
            request.Execute();
        }

        private static string[] ProcurarArquivoId(Google.Apis.Drive.v3.DriveService servico, string nome, bool procurarNaLixeira = false)
        {
            var retorno = new List<string>();

            var request = servico.Files.List();
            request.Q = string.Format("name = '{0}'", nome);
            if (!procurarNaLixeira)
            {
                request.Q += " and trashed = false";
            }
            request.Fields = "files(id)";
            var resultado = request.Execute();
            var arquivos = resultado.Files;

            if (arquivos != null && arquivos.Any())
            {
                foreach (var arquivo in arquivos)
                {
                    retorno.Add(arquivo.Id);
                }
            }

            return retorno.ToArray();
        }

        private static void DeletarItem(Google.Apis.Drive.v3.DriveService servico, string nome)
        {
            var ids = ProcurarArquivoId(servico, nome);
            if (ids != null && ids.Any())
            {
                foreach (var id in ids)
                {
                    var request = servico.Files.Delete(id);
                    request.Execute();
                }
            }
        }

        private static void Upload(Google.Apis.Drive.v3.DriveService servico, string caminhoArquivo)
        {
            var arquivo = new Google.Apis.Drive.v3.Data.File();
            arquivo.Name = System.IO.Path.GetFileName(caminhoArquivo);
            arquivo.MimeType = MimeTypes.MimeTypeMap.GetMimeType(System.IO.Path.GetExtension(caminhoArquivo));

            using (var stream = new System.IO.FileStream(caminhoArquivo, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                var ids = ProcurarArquivoId(servico, arquivo.Name);
                Google.Apis.Upload.ResumableUpload<Google.Apis.Drive.v3.Data.File, Google.Apis.Drive.v3.Data.File> request;

                if (ids == null || !ids.Any())
                {
                    request = servico.Files.Create(arquivo, stream, arquivo.MimeType);
                }
                else
                {
                    request = servico.Files.Update(arquivo, ids.First(), stream, arquivo.MimeType);
                }

                request.Upload();
            }
        }

        private static void Download(Google.Apis.Drive.v3.DriveService servico, string nome, string destino)
        {
            var ids = ProcurarArquivoId(servico, nome);
            if (ids != null && ids.Any())
            {
                var request = servico.Files.Get(ids.First());
                using (var stream = new System.IO.FileStream(destino, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    request.Download(stream);
                }
            }
        }

        private static void MoverParaLixeira(Google.Apis.Drive.v3.DriveService servico, string nome)
        {
            var ids = ProcurarArquivoId(servico, nome);
            if (ids != null && ids.Any())
            {
                foreach (var id in ids)
                {
                    var arquivo = new Google.Apis.Drive.v3.Data.File();
                    arquivo.Trashed = true;
                    var request = servico.Files.Update(arquivo, id);
                    request.Execute();
                }
            }
        }
    }
}
