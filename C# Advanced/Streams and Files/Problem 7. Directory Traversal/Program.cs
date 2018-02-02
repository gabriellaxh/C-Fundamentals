using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_7._Directory_Traversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = Console.ReadLine();
            string destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filesDict = new Dictionary<string, Dictionary<string, long>>();

            var files = Directory.GetFiles(sourcePath, "*.*", SearchOption.TopDirectoryOnly);

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                var name = fileInfo.Name;
                var extension = fileInfo.Extension;
                var length = fileInfo.Length;

                if (!filesDict.ContainsKey(extension))
                {
                    filesDict[extension] = new Dictionary<string, long>();
                }

                if (!filesDict[extension].ContainsKey(name))
                {
                    filesDict[extension][name] = length;
                }
            }

            using (var writer = new StreamWriter($"{destinationPath}/report.txt"))
            {
                foreach (var file in filesDict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    var extension = file.Key;
                    var filesDictionary = filesDict[extension].OrderByDescending(x => x.Value);

                    writer.WriteLine(extension);

                    foreach (var f in filesDictionary)
                    {
                        writer.WriteLine($"--{f.Key} - {(double)f.Value / 1024:f3} kb");
                    }
                }
            }
        }
    }
}
