using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public class HundredExpression: Expression
    {
        public override string five()
        {
            return "D";
        }

        public override string four()
        {
            return "CD";
        }

        public override int multiplier()
        {
            return 100;
        }

        public override string nine()
        {
            return "CM";
        }

        public override string one()
        {
            return "C";
        }
    }
}
