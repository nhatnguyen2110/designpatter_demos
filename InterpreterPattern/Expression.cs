using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public abstract class Expression
    {
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
            {
                return;
            }
            if (context.Input.StartsWith(nine()))
            {
                context.Output += 9 * multiplier();
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(four()))
            {
                context.Output += 4 * multiplier();
                context.Input = context.Input.Substring(2);
            }
            else if (context.Input.StartsWith(five()))
            {
                context.Output += 5 * multiplier();
                context.Input = context.Input.Substring(1);
            }
            while (context.Input.StartsWith(one()))
            {
                context.Output += 1 * multiplier();
                context.Input = context.Input.Substring(1);
            }
        }
        public abstract string one();
        public abstract string four();
        public abstract string five();
        public abstract string nine();
        public abstract int multiplier();
    }
}
