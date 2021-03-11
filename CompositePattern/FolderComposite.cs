using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class FolderComposite : IFileComponent
    {
        private List<IFileComponent> files;
        public FolderComposite(List<IFileComponent> files)
        {
            this.files = files;
        }
        public void ShowProperty()
        {
            foreach (var file in files)
            {
                file.ShowProperty();
            }
        }

        public int totalSize()
        {
            int total = 0;
            foreach (var file in files)
            {
                total += file.totalSize();
            }
            return total;
        }
    }
}
