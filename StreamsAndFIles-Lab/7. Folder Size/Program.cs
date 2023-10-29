using System;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main(string[] args)
        {
            RecurseDirectory("../../../");
        }

        private static void RecurseDirectory(string path)
        {
            Console.WriteLine(path);
            string[] dirs = Directory.GetDirectories(path);
            foreach (var dir in dirs)
            {
                RecurseDirectory(dir);
            }
        }
    }
}
