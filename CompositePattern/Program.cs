using System;
using System.Collections.Generic;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var file1 = new FileLeaf("file 1", 10);
            var file2 = new FileLeaf("file 2", 5);
            var file3 = new FileLeaf("file 3", 12);

            var files = new List<IFileComponent>();
            files.Add(file1);
            files.Add(file2);
            files.Add(file3);

            var folder = new FolderComposite(files);
            folder.ShowProperty();
            Console.WriteLine("Total Size: " + folder.totalSize());
            Console.ReadLine();

        }
    }
}
