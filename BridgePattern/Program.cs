using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dauBepViet = new DauBepViet();
            var dauBepTay = new DauBepTay();

            var nhaHangViet = new NhaHang(dauBepViet);
            var nhaHangTay = new NhaHang(dauBepTay);

            nhaHangViet.ChuanBiMon();
            nhaHangTay.ChuanBiMon();

            Console.ReadLine();
        }
    }
}
