using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResposibilityPattern
{
    public interface IHandler
    {
        IHandler Successor { get; set; }
        /// <summary>
        /// Mệnh giá
        /// </summary>
        int Denomination { get; set; }
        /// <summary>
        /// Số lượng tiền có sẵn
        /// </summary>
        int AvailableBill { get; set; }
      
        /// <summary>
        /// Rút tiền
        /// </summary>
        /// <param name="amount"></param>
        void RequestWithdraw(int amount);
        void ShowStatus();
    }
}
