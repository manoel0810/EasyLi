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
}
