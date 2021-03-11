using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public interface IVisitor
    {
        int visit(Pen pen);
        int visit(Notebook notebook);
    }
}
