using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Product
{
    public class WoodTable : ITable
    {
        public void Create()
        {
            Console.WriteLine("Create Wood Table");
        }
    }
}
