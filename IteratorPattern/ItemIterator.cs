using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public interface IItemIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
