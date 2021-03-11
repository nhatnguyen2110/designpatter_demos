using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] romans = { "IV", "XI", "CLIX", "MMXVIII", "MMMDLIV" };
            foreach (var item in romans)
            {
                ConvertRomanToNumber(item);
            }
            Console.ReadLine();
        }
        private static void ConvertRomanToNumber(string roman)
        {
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());
            var context = new Context(roman);
            foreach (var item in tree)
            {
                item.Interpret(context);
            }
            Console.WriteLine(roman + " = " + context.Output);
        }
    }
}
