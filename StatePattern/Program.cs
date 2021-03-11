using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DocumentContext();
            context.SetState(new NewState());
            context.ApplyState();

            context.SetState(new SubmittedState());
            context.ApplyState();

            context.SetState(new ApprovedState());
            context.ApplyState();

            Console.ReadLine();
        }
    }
}
