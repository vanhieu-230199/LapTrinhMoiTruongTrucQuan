using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            float nSoA, nSoB, x=0;
            Console.Clear();
            Console.WriteLine("*****Tinh phuong trinh bac 1*****")
            Console.Write("{0}","Nhap a: ");
            nSoA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            nSoB = Convert.ToInt32(Console.ReadLine());
            if (nSoA == 0 && nSoB !=0)
            {
                Console.Write("Phuong trinh vo nghiem");
            }
            else if(nSoA == 0 && nSoB == 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem");
            }
            else
            {
                x = -nSoB / nSoA;
                Console.Write("Phuong trinh co 1 nghiem: "+x);
            }
            Console.ReadLine();
        }
    }
}
