using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class JapaneseAdaptee
    {
        public void Receive(string words)
        {
            Console.WriteLine("Retrieving words from Adapter ...");
            Console.WriteLine(words);
        }
    }
}
