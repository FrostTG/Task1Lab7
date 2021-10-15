using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину стороны треугольника №1 х1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны треугольника №1 y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны треугольника №1 z1=");
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны треугольника №2 х2=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны треугольника №2 y2=");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину стороны треугольника №2 z2=");
            double z2 = Convert.ToDouble(Console.ReadLine());
            double S1 = CalcSqr(x1, y1, z1);
            double S2 = CalcSqr2(x2, y2, z2);
            string S = S1 > S2 ? "Площадь 1-ого треугольника больше" : S1 < S2 ? "Площадь 2-ого треугольника" : "Площади равны";
            Console.WriteLine("Площадь 1-ого треугольника равна {0:f2}",S1);
            Console.WriteLine("Площадь 2-ого треугольника равна {0:f2}", S2);
            Console.WriteLine(S);
            Console.ReadKey();
        }
        static double CalcSqr(double x1, double y1, double z1)
        {
            double P = x1 + y1 + z1;
            double p = P / 2;
            double S1 = Math.Sqrt(p * (p - x1) * (p - y1) * (p - z1));
            return S1;
        }
        static double CalcSqr2(double x2, double y2, double z2)
        {
            double P = x2 + y2 + z2;
            double p = P / 2;
            double S1 = Math.Sqrt(p * (p - x2) * (p - y2) * (p - z2));
            return S1;
        }
    }
}
