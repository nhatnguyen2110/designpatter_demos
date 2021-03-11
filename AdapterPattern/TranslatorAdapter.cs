using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class TranslatorAdapter : IVietnameseTarget
    {
        private JapaneseAdaptee adaptee;
        public TranslatorAdapter(JapaneseAdaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public void Send(string word)
        {
            Console.WriteLine("Reading words...");
            Console.WriteLine(word);
            var vietnameseWords = this.Translate(word);
            Console.WriteLine("Sending Words...");
            adaptee.Receive(vietnameseWords);
        }
        private string Translate(string vietnamWords)
        {
            Console.WriteLine("Translated");
            return "こんにちは";
        }
    }
}
