using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoGaSoCho
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=0, x1, y, y1=0 ,y2 , z1, z2;
            Console.Clear();
            Console.WriteLine("{0}","*********Tinh phuong trinh bac nhat 2 an*********");
            Console.WriteLine("X + y = ?");
            Console.WriteLine("2X + 4y = ?");
            Console.Write("Nhap so z1: ");
            z1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so z2: ");
            z2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x + y = " + z1);
            Console.WriteLine("2x + 4y = " + z2);
            Console.WriteLine("Ket qua:");
            x1 = z1 - y1;
            y2 = (z2 - 2*z1 + 2*y1)/4;
            y1 = y2;
            y = y1 * 2;
            x = z1 - y;
            Console.WriteLine("x = " + x);
            Console.Write("y = " + y);
            Console.ReadLine();
        }
    }
}
