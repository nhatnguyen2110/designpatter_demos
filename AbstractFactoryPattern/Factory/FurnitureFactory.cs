using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Factory
{
    public class FurnitureFactory
    {
        public static FurnitureAbstractFactory GetFactory(MaterialType materialType)
        {
            switch (materialType)
            {
                case MaterialType.PLASTIC:
                    return new PlasticFactory();
                case MaterialType.WOOD:
                    return new WoodFactory();
                default:
                    throw new Exception("This furniture is unsupported");
            }
        }
    }
}
