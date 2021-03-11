using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class Item
    {
        private string title;
        private string url;
        public Item(string title, string url)
        {
            this.title = title;
            this.url = url;
        }
        public override string ToString()
        {
            return $"Item [title={title}, url = {url}]";
        }
    }
}
