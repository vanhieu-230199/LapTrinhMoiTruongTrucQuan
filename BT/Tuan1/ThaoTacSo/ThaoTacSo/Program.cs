using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThaoTacSo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSo1, nSo2, nTong, chon;
            do
            {
                Console.WriteLine("{0}", "*********Cac phep tinh don gian*********");
                Console.WriteLine("1. Phep cong");
                Console.WriteLine("2. Phep tru");
                Console.WriteLine("3. Phep nhan");
                Console.WriteLine("4. Phep chia");
                Console.WriteLine("5. Thoat");
                Console.Write("Lua chon cua ban la: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap So thu nhat: ");
                        nSo1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("{0}", "Nhap So thu hai: ");
                        nSo2 = Convert.ToInt32(Console.ReadLine());
                        nTong = nSo1 + nSo2;
                        Console.WriteLine("Tong la: " + nTong);
                        break;

                    case 2:
                        Console.Write("Nhap So thu nhat: ");
                        nSo1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("{0}", "Nhap So thu hai: ");
                        nSo2 = Convert.ToInt32(Console.ReadLine());
                        nTong = nSo1 - nSo2;
                        Console.WriteLine("Hieu la: " + nTong);
                        break;

                    case 3:
                        Console.Write("Nhap So thu nhat: ");
                        nSo1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("{0}", "Nhap So thu hai: ");
                        nSo2 = Convert.ToInt32(Console.ReadLine());
                        nTong = nSo1 * nSo2;
                        Console.WriteLine("Tich la: " + nTong);
                        break;

                    case 4:
                        Console.Write("Nhap So thu nhat: ");
                        nSo1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("{0}", "Nhap So thu hai: ");
                        nSo2 = Convert.ToInt32(Console.ReadLine());
                        nTong = nSo1 / nSo2;
                        Console.WriteLine("Thuong la: "+nTong);
                        break;

                    case 5:
                        break;
                    default:
                        Console.WriteLine("Vui long nhap lai");
                        break;
                }
            } while (chon != 5);
            Console.ReadLine();
        }
    }
}
