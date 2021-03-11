using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount newAccount = new BankAccount
                  .BankAccountBuilder("GP Coder", "0123456789")
                  .withEmail("contact@gpcoder.com")
                  .wantNewsletter(true)
                  .build();
            Console.WriteLine(newAccount.ToString());
            Console.ReadLine();

        }
    }
}
