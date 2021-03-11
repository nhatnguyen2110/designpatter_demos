using FactoryMethodPattern.FactoryClass;
using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank1 = BankFactory.GetBank(BankType.TPBANK);
            var bank2 = BankFactory.GetBank(BankType.VIETCOMBANK);
            Console.WriteLine("Bank 1: " + bank1.GetBankName());
            Console.WriteLine("Bank 2: " + bank2.GetBankName());
            Console.ReadLine();
        }
    }
}
