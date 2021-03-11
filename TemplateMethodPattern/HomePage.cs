using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class HomePage : PageTemplate
    {
        protected override void ShowBody()
        {
            Console.WriteLine("<body>Content of home page</body>");
        }
    }
}
