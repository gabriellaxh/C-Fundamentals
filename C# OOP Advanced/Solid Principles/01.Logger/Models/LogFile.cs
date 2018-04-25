using Logger.App.Models.Contracts;
using System;
using System.IO;
using System.Text;

namespace Logger.App.Models
{
    public class LogFile : ILogFile
    {
        const string DefaultPath = "./data/";
        
        public string Path { get; }

        public int Size { get; private set; }

        public LogFile(string fileName)
        {
            this.Path = DefaultPath + fileName;
            InitializeFile();
            this.Size = 0;
        }

        private void InitializeFile()
        {
            Directory.CreateDirectory(DefaultPath);
            File.AppendAllText(this.Path, "");
        }

        public void Write(string messageLog)
        {
            File.AppendAllText(this.Path, messageLog + Environment.NewLine);

            int addedSize = 0;
            for (int i = 0; i < messageLog.Length; i++)
            {
                addedSize += messageLog[i]; 
            }
            this.Size += addedSize;
        }
    }
}
