using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Notebook : IItem
    {
        public int Price;
        public int NumberOfPages;

        public int Accept(IVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
