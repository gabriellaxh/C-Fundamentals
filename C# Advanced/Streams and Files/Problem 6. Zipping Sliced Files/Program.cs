using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Problem_5._Slicing_File
{
    public class Program
    {
        private static List<string> fileParts = new List<string>();

        public static void Main()
        {
            var originalFilePath = "copyMe.png";
            var sliceFilePath = "slicedImage.png";

            Slice(originalFilePath, sliceFilePath);
            //Assemble(fileParts, sliceFilePath);
            Compress(originalFilePath);
            Decompress(originalFilePath);

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
                    var partName = $"{i}.gz";
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
                        }
                    }
                }
            }
        }

        private static void Compress(string originalFilePath)
        {
            int parts = int.Parse(Console.ReadLine());

            string zipFilePath = "zippedFile.zip";

            using (var zipFile = new FileStream(zipFilePath, FileMode.Create, FileAccess.Write))
            {
                using (var compressed = new GZipStream(zipFile, CompressionMode.Compress))
                {
                    byte[] buffer = File.ReadAllBytes(originalFilePath);

                    compressed.Write(buffer, 0, buffer.Length);
                    compressed.Flush();
                    compressed.Close();
                }
            }
        }

        private static void Decompress(string originalFilePath)
        {
            string compressedFile = "zippedFile.zip";
            using (var zipFile = new FileStream(compressedFile, FileMode.Open, FileAccess.Read))
            {
                using (var decompressed = new FileStream(originalFilePath, FileMode.Create, FileAccess.Write))
                {
                    using (var alg = new GZipStream(zipFile, CompressionMode.Decompress))
                    {
                        while (true)
                        {
                            byte[] buffer = new byte[4096];

                            int readBytes = alg.Read(buffer, 0, buffer.Length);

                            if (readBytes == 0)
                            {
                                break;
                            }
                            decompressed.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }
    }
}
