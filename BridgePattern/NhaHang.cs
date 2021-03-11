using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class NhaHang
    {
        private IDauBep dauBep;
        public NhaHang(IDauBep dauBep)
        {
            this.dauBep = dauBep;
        }
        public void ChuanBiMon()
        {
            Console.WriteLine("Nha Hang Chuan Bi Mon");
            this.dauBep.NauAn();
        }
    }
}
