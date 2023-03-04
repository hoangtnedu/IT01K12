using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHCN
{
    class HCN
    {
        //thuoc tinh
        public int chieuDai;
        public int chieuRong;
        //method
        public int tinhChuVi()
        {
            return (chieuDai +chieuRong)*2;
        }
        public int tinhDienTich()
        {
            return chieuRong * chieuDai;
        }
    }
}
