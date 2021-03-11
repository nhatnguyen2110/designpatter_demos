using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Product
{
    public class PlasticTable : ITable
    {
        public void Create()
        {
            Console.WriteLine("Create Plastic Table");
        }
    }
}
