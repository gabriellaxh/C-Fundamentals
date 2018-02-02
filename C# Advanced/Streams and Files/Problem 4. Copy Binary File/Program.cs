using System;
using System.IO;
using System.Text;

namespace Problem_4._Copy_Binary_File
{
    public class Program
    {
        static void Main(string[] args)
        {
            var originalFilePath = "copyMe.png";
            var copyImageFilePath = "imageCopy.png";
            using (var originalFile = new FileStream(originalFilePath, FileMode.Open))
            {
                using(var copyFile = new FileStream(copyImageFilePath, FileMode.Create))
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(originalFilePath);

                    while (true)
                    {
                        int readBytes = originalFile.Read(buffer,0, buffer.Length);
                        if(readBytes == 0)
                        {
                            break;
                        }

                        copyFile.Write(buffer, 0, readBytes);
                        copyFile.Flush();
                    }
                }
            }
        }
    }
}
