using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class ProxyImage : IImage
    {
        private IImage realImage;
        private string url;
        public ProxyImage(string url)
        {
            this.url = url;
            Console.WriteLine("Image unloaded: " + this.url);
        }
        public void ShowImage()
        {
            if (realImage == null)
            {
                realImage = new RealImage(url);
            }
            else
            {
                Console.WriteLine("Image already exited: " + this.url);
            }
            realImage.ShowImage();
        }
    }
}
