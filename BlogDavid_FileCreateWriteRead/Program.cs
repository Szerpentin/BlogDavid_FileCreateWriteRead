using System;
using System.IO;

namespace BlogDavid_FileCreateWriteRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Keep info of file in memory
            var fileInfo = new FileInfo("./a.txt");
            // Create the file, then create a stream writer, which is easily used to add text
            using (var fileStream = fileInfo.Create())
            using (var streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.WriteLine("Test data!");
            }
            // StreamReader is a great tool to read text from file
            using (var streamReader = new StreamReader(fileInfo.FullName))
            {
                Console.WriteLine(streamReader.ReadToEnd());
            }

            // Don't let console to close, wait for one char
            Console.ReadKey();
        }
    }
}