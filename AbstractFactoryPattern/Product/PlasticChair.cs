using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Product
{
    public class PlasticChair : IChair
    {
        public void Create()
        {
            Console.WriteLine("Create Plastic Chair");
        }
        
    }
}
