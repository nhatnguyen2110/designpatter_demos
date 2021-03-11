using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    public class Context
    {
        
        public string Input { get; set; }
        public int Output { get; set; }
        public Context(string input)
        {
            this.Input = input;
        }
    }
}
