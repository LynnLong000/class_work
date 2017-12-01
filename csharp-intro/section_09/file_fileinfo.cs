using System;
using System.IO;

namespace file_info
{
    class Program
    {
        static void Main(string[] args)
        {
            //  static methods   small amount
            File.Copy("file being copy","destinnation of this file",if file exist it can be overwritten);

            File.Delete("path of the file being delete");

            File.Exists(" file to see if ti exist");

            var content = File.ReadAllText("path to file");

            // instance method  large amount
            var fileInfo = new FileInfo("path");
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {

            }
        }
    }
}
