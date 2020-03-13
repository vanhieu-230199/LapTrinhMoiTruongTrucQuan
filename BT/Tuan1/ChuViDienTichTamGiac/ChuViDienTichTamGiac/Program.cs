using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuViDienTichTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, p, cv, dt;
            Console.Clear();
            Console.WriteLine("{0}","*****Tinh chu vi & dien tich*****");
            Console.Write("Nhap canh a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            c = Convert.ToInt32(Console.ReadLine());
            if(a > 0 && b > 0 && c > 0)
            {
                cv = a + b + c;
                p = cv / 2;
                dt = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
                Console.WriteLine("Chu vi la: " + cv);
                Console.WriteLine("p = " + p);
                Console.WriteLine("Dien tich la: "+dt);
            }
            else
            {
                Console.WriteLine("Khong tao thanh tam giac");
            }
            Console.ReadLine();
        }
    }
}
