using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double d, x1, x2;
            Console.Clear();
            Console.WriteLine("{0}","*****Tinh phuong trinh bac 2*****")
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());
            d = b * b - 4 * a * c;
            if (d == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("Phuong trinh co nghiem kep x1=x2= "+x1);
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Phuong trinh có 2 nghiem phan biet:");
                Console.WriteLine("x1 = "+x1);
                Console.WriteLine("x2 = " + x2);
            }
            else
            {
                Console.Write("Phuong trinh vo nghiem");
            }
            Console.ReadLine();
        }
    }
}
