using FactoryMethodPattern.SupperClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.SubClass
{
    public class TPBank : IBank
    {
        public string GetBankName()
        {
            return "TPBank";
        }
    }
}
