using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public interface IFileComponent
    {
        void ShowProperty();
        int totalSize();
    }
}
