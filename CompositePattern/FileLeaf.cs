using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class FileLeaf : IFileComponent
    {
        private string name;
        private int size;
        public FileLeaf(string name, int size)
        {
            this.name = name;
            this.size = size;
        }
        public void ShowProperty()
        {
            Console.WriteLine("FileLeaf [name=" + name + ", size=" + size + "]");
        }

        public int totalSize()
        {
            return size;
        }
    }
}
