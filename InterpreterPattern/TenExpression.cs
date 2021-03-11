using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public class TenExpression : Expression
    {
        public override string five()
        {
            return "L";
        }

        public override string four()
        {
            return "XL";
        }

        public override int multiplier()
        {
            return 10;
        }

        public override string nine()
        {
            return "XC";
        }

        public override string one()
        {
            return "X";
        }
    }
}
