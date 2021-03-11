using FactoryMethodPattern.SupperClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.SubClass
{
    public class VietcomBank : IBank
    {
        public string GetBankName()
        {
            return "VietcomBank";
        }
    }
}
