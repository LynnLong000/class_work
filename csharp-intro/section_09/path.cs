using System;
using System.IO;
namespace path
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "path to file";

            var doIndex = path.IndexOf('.');
            var extension = path.Substring(doIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
