using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDienTich
{
    class Program
    {
        static void Main(string[] args)
        {
            int nChieuDai, nChieuRong, nChuVi = 0, nDienTich = 0;
            Console.Clear();
            Console.WriteLine("{0}", "*********Tinh chu vi & dien tich*********");
            Console.WriteLine("Nhap chieu dai:");
            nChieuDai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong:");
            nChieuRong = Convert.ToInt32(Console.ReadLine());
            nChuVi = (nChieuDai + nChieuRong) * 2;
            Console.WriteLine("Chu vi = "+nChuVi);
            nDienTich = nChieuDai * nChieuRong;
            Console.WriteLine("Dien tich = "+nDienTich);
            Console.ReadLine();
        }
    }
}
