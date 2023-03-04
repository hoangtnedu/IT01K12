using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Bai2
{
    public class HANG
    {
        string _maHang, _tenHang, _nhaCC;
        public string MaHang
        {
            get { return _maHang; }
            set { _maHang = value; }
        }
        public string TenHang
        {
            get { return _tenHang; }
            set { _tenHang = value; }
        }
        public string NhaCC
        {
            get { return _nhaCC; }
            set { _nhaCC = value; }
        }
        public HANG(string maHang, string tenHang, string nhaCC) {
            _maHang = maHang;
            _tenHang = tenHang;
            _nhaCC = nhaCC;
        }
    }
}
