using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class DetailPage : PageTemplate
    {
        protected override void ShowBody()
        {
            Console.WriteLine("<body>Content of detail page</body>");
        }
        
    }
}
