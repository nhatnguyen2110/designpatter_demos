using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public class OneExpression : Expression
    {
        public override string five()
        {
            return "V";
        }

        public override string four()
        {
            return "IV";
        }

        public override int multiplier()
        {
            return 1;
        }

        public override string nine()
        {
            return "IX";
        }

        public override string one()
        {
            return "I";
        }
    }
}
