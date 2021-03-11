using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface IVietnameseTarget
    {
        void Send(string word);
    }
}
