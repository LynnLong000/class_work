using System;
using System.IO;

namespace dir_info
{
    class Program
    {
        static void Main(string[] args)
        {
            // files
            Directory.CreateDirectory("path to file ");
            var files = Directory.GetFiles("path to file","all files // *.* or .sln files ", " SearchOption.AllDirectories");
            foreach(var file in files)
                Console.WriteLine(file);

            // directory++
            Directory.CreateDirectory("path to file ");
            var directories = Directory.GetDirectories("path to file", "all files // *.* or .sln files ", " SearchOption.AllDirectories");
            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("path");

            var directoryInfo = new DirectoryInfo("..");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}