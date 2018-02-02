using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Problem_5._Slicing_File
{
    public class Program
    {
        private static List<string> fileParts = new List<string>();

        public static void Main()
        {
            var originalFilePath = "copyMe.png";
            var sliceFilePath = "copiedImage.png";

            Slice(originalFilePath, sliceFilePath);
            Assemble(fileParts, sliceFilePath);

        }

        private static void Slice(string originalFilePath, string sliceFilePath)
        {
            int parts = int.Parse(Console.ReadLine());
            using (var originalFile = new FileStream(originalFilePath, FileMode.Open))
            {
                var partSize = Math.Ceiling((double)originalFile.Length / parts);

                byte[] buffer = Encoding.UTF8.GetBytes(originalFilePath);

                for (int i = 0; i < parts; i++)
                {
                    var partName = $"{i}.jpg";
                    fileParts.Add(partName);

                    using (var sliceFile = new FileStream(partName, FileMode.Create))
                    {
                        int bytes = 0;
                        while (bytes < partSize)
                        {
                            int readBytes = originalFile.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            sliceFile.Write(buffer, 0, readBytes);
                            bytes += readBytes;
                            sliceFile.Flush();
                        }
                    }
                }
            }
        }

        private static void Assemble(List<string> fileParts, string slicePath)
        {
            using (var assembledImage = new FileStream("assembledImage.jpg", FileMode.Create))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(slicePath);
                for (int i = 0; i < fileParts.Count; i++)
                {
                    using (var reader = new FileStream(fileParts[i], FileMode.Open))
                    {
                        while (true)
                        {
                            int readBytes = reader.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            assembledImage.Write(buffer, 0, readBytes);
                            assembledImage.Flush();
                        }
                    }
                }
            }
        }
    }
}
