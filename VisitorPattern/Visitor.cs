using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    public class Visitor : IVisitor
    {
        public int visit(Pen pen)
        {
            Console.WriteLine(pen.Model + " with price " + pen.Price);
            return pen.Price;
        }

        public int visit(Notebook notebook)
        {
            int price = 0;
            if (notebook.NumberOfPages>250)
            {
                price = notebook.Price - 5;
            }
            else
            {
                price = notebook.Price;
            }
            Console.WriteLine("Price for Noteboook is " + price);
            return price;
        }
    }
}
