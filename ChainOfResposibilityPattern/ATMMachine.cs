using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResposibilityPattern
{
    public class ATMMachine
    {
        private List<Handler> handlers;
        public ATMMachine(
            int availableBill_500k,
            int availableBill_200k,
            int availableBill_100k,
            int availableBill_50k
            )
        {
            var handler50k = new Handler()
            {
                AvailableBill = availableBill_50k,
                Denomination = 50000
            };
            var handler100k = new Handler()
            {
                AvailableBill = availableBill_100k,
                Successor = handler50k,
                Denomination = 100000
            };
            var handler200k = new Handler()
            {
                AvailableBill = availableBill_200k,
                Successor = handler100k,
                Denomination = 200000
            };
            var handler500k = new Handler()
            {
                AvailableBill = availableBill_500k,
                Successor = handler200k,
                Denomination = 500000
            };

            handlers = new List<Handler>() { handler500k, handler200k, handler100k, handler50k };
        }
        public void ShowStatus()
        {
            foreach (var item in this.handlers)
            {
                item.ShowStatus();
            }
        }
        public void WithDraw(int amount)
        {
            handlers.FirstOrDefault().RequestWithdraw(amount);
        }
    }
}
