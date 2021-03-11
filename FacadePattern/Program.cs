using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopFacade.GetInstanse().BuyProductByCashWithFreeShipping("abc@xyz.com");
            ShopFacade.GetInstanse().BuyProductByPaypalWithStandardShipping("abc@xyz.com", "1231213");
            Console.ReadLine();
        }
    }
}
