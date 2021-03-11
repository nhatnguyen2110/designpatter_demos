using FactoryMethodPattern.SubClass;
using FactoryMethodPattern.SupperClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.FactoryClass
{
    public class BankFactory
    {
        public static IBank GetBank(BankType bankType)
        {
            switch (bankType)
            {
                case BankType.VIETCOMBANK:
                    return new VietcomBank();
                case BankType.TPBANK:
                    return new TPBank();
                default:
                    throw new Exception("This bank type is unsupported");
            }
        }
    }
}
