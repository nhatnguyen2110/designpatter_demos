using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResposibilityPattern
{
    public class Handler : IHandler
    {
        public IHandler Successor { get; set; }
        public int Denomination { get; set; }
        public int AvailableBill { get; set; }
        
        public void RequestWithdraw(int amount)
        {
            int restOfAmount = amount;
            if (amount >= this.Denomination && AvailableBill > 0)
            {
                int numOfBill = amount / this.Denomination;
                if (numOfBill <= this.AvailableBill) //May con du tien
                {
                    Console.WriteLine($"So luong tien menh gia {Denomination} la {numOfBill} to");
                    this.AvailableBill -= numOfBill;
                    restOfAmount = amount % this.Denomination;
                }
                else // khong du tien
                {
                    Console.WriteLine($"So luong tien menh gia {Denomination} la {AvailableBill} to");
                    restOfAmount = amount - (this.Denomination * this.AvailableBill);
                    this.AvailableBill = 0;
                }
            }
            if(restOfAmount > 0)
            {
                if (Successor != null)
                    Successor.RequestWithdraw(restOfAmount);
                else
                    throw new Exception("May khong co du tien de rut");
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine($"So luong tien menh gia {this.Denomination} con trong khay la {this.AvailableBill} to");
        }
    }
}
