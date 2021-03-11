using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern.Factory
{
    public class WoodFactory : FurnitureAbstractFactory
    {
        public override IChair CreateChair()
        {
            return new WoodChair();
        }

        public override ITable CreateTable()
        {
            return new WoodTable();
        }
    }
}
