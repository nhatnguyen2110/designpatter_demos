using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.Product;

namespace AbstractFactoryPattern.Factory
{
    public class PlasticFactory : FurnitureAbstractFactory
    {
        public override IChair CreateChair()
        {
            return new PlasticChair();
        }

        public override ITable CreateTable()
        {
            return new PlasticTable();
        }
    }
}
