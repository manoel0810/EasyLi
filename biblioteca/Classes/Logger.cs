using System;
using System.IO;
using System.Windows.Forms;

public class Logger
{
    private readonly string logFilePath;
    private string logBuffer = "";

    public Logger(string filePath)
    {
        if (!Directory.Exists($"{Application.StartupPath}\\logs"))
            Directory.CreateDirectory($"{Application.StartupPath}\\logs");

        logFilePath = filePath;
        AppDomain.CurrentDomain.ProcessExit += SaveLogToFile;

        DeleteOldLogFiles($"{Application.StartupPath}\\logs");
    }

    public void Log(string message)
    {
        string formattedMessage = $"[{DateTime.Now}] {message}";
        logBuffer += formattedMessage + Environment.NewLine;
    }

    private void SaveLogToFile(object sender, EventArgs e)
    {
        File.WriteAllText(logFilePath, logBuffer);
    }

    private void DeleteOldLogFiles(string folderPath)
    {
        DirectoryInfo directory = new DirectoryInfo(folderPath);
        FileInfo[] files = directory.GetFiles();

        foreach (FileInfo file in files)
        {
            if (file.LastWriteTime < DateTime.Now.AddDays(-30))
            {
                file.Delete();
                Log($"[Logger] Arquivo log: {file.Name}, apagado");
            }
        }
    }
}
