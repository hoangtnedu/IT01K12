using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHCN
{
    class Program
    {
        static void Main(string[] args)
        {
            HCN doiTuongHCN = new HCN();
            doiTuongHCN.chieuDai = 5;
            doiTuongHCN.chieuRong = 6;
            int dt = doiTuongHCN.tinhDienTich();
            int cv = doiTuongHCN.tinhChuVi();
            Console.Write("Dien tich HCN co chieu dai la {0} rong {1} la {2}, chu vi: {3}",
                doiTuongHCN.chieuDai,doiTuongHCN.chieuRong,dt,cv);
            Console.ReadKey();
        }
    }
}
