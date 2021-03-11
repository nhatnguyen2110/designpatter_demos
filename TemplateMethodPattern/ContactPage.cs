using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class ContactPage : PageTemplate
    {
        protected override void ShowBody()
        {
            Console.WriteLine("<body>Content of contact page</body>");
        }
        protected override void ShowNavigation()
        {
            //just nothing
        }
    }
}
