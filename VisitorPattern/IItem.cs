using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public interface IItem
    {
        int Accept(IVisitor visitor);
    }
}
