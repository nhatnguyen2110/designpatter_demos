using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class RealImage : IImage
    {
        private string url;
        public RealImage(string url)
        {
            this.url = url;
        }
        public void ShowImage()
        {
            Console.WriteLine("Image showed: " + this.url);
        }
    }
}
