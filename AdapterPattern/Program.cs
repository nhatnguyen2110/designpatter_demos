using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var client = new TranslatorAdapter(new JapaneseAdaptee());
            client.Send("Xin Chào");
            Console.ReadLine();
        }
    }
}
