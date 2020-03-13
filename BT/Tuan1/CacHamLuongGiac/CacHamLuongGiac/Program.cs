using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacHamLuongGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double a, cogTan =0;
            Console.Write("{0}","Nhap vao 1 goc: ");
            x = Convert.ToInt32(Console.ReadLine());
            a = x * Math.PI / 180;
            Math.Sin(a);
            Console.WriteLine("Sin("+x+")= "+Math.Sin(a));
            Math.Cos(a);
            Console.WriteLine("Cos(" + x + ")= " + Math.Cos(a));
            Math.Tan(a);
            Console.WriteLine("Tan(" + x + ")= " + Math.Tan(a));;
            cogTan = Math.Cos(a) / Math.Sin(a);
            Console.WriteLine("CogTan(" + x + ")= " + cogTan);
            Console.ReadLine();
        }
    }
}
