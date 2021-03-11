using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Pen : IItem
    {
        public int Price;
        public string Model;

        public int Accept(IVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
