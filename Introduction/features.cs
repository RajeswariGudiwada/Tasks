using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Introduction1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\SAILS-DM150";
            showLargeFilesWithoutLinq(path);
            Console.WriteLine("***");
            showLargeFilesWithLinq(path);
        }

        private static void showLargeFilesWithLinq(string path)
        {
            var query = new DirectoryInfo(path).GetFiles()
                        .OrderByDescending(f => f.Length)
                        .Take(7);
            foreach (var file in query.Take(9))
            {
                Console.WriteLine($"{file.Name,-20}:{file.Length,10:N0}");
            }
        }

        private static void showLargeFilesWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer());
            for (int i = 0; i < 8; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name,-20}:{file.Length,10:N0}");
            }


        }
    }

}

public class FileInfoComparer : IComparer<FileInfo>
{
    public int Compare(FileInfo x, FileInfo y)
    {
        return y.Length.CompareTo(x.Length);
    }

}