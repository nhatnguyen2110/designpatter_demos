using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class PageTemplate
    {
        protected void ShowHeader()
        {
            Console.WriteLine("<header></header>");
        }
        protected virtual void ShowNavigation()
        {
            Console.WriteLine("<nav></nav>");
        }
        protected void ShowFooter()
        {
            Console.WriteLine("<footer></footer>");
        }
        protected abstract void ShowBody();
        public void ShowPage()
        {
            ShowHeader();
            ShowNavigation();
            ShowBody();
            ShowFooter();
        }
    }
}
