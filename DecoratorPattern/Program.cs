using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IComponent orgComponent = new Component();
            DecoratorA aComponent = new DecoratorA(orgComponent);
            DecoratorB bComponent = new DecoratorB(orgComponent);
            DecoratorA abComponent = new DecoratorA(bComponent);

            Console.WriteLine($"Original object: {orgComponent.Operation()}");
            
            Console.WriteLine($"A Decorator object: {aComponent.Operation()}. {aComponent.AddedBehavior()}");
            
            Console.WriteLine($"B Decorator object: {bComponent.Operation()}");
            
            Console.WriteLine($"AB Decorator object: {abComponent.Operation()}");

            Console.ReadKey();
        }
    }
}
