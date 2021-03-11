using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var homepage = new HomePage();
            homepage.ShowPage();

            var detailpage = new DetailPage();
            detailpage.ShowPage();

            var contactpage = new ContactPage();
            contactpage.ShowPage();

            Console.ReadLine();
        }
    }
}
