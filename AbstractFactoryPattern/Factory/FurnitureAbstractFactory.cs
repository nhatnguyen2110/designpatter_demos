using AbstractFactoryPattern.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Factory
{
    public abstract class FurnitureAbstractFactory
    {
        public abstract IChair CreateChair();
        public abstract ITable CreateTable();
    }
}
