using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathString = @"c:\test";
            string fileName = "MyNewFile.txt";
            string targetPath = @"C:\test\test2";
            string sourcePath = @"c:\test";
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            pathString = System.IO.Path.Combine(pathString, fileName);
            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString)) { }
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);
                return;
            }
            System.IO.File.Copy(sourceFile, destFile, true);
            System.IO.File.Delete(@"C:\test\MyNewFile.txt");
        }
    }
}
