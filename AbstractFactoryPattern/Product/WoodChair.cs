using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Product
{
    public class WoodChair : IChair
    {
        public void Create()
        {
            Console.WriteLine("Create Wood Chair");
        }
    }
}
