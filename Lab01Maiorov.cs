using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Maiorov
{
    class Program
    {
        static void Main(string[] args)
        {
            // общее задание
            sbyte a = -100;
            sbyte b = Math.Abs(a);
            sbyte c = Math.Max(a, b);
            double d = Math.Sqrt(b);
            double e = Math.Truncate(d);
            // индивидуальное задание 14 вариант
            double individual = Math.Acos(1 / 2);
            double otvet = (individual * 180) / Math.PI;
            Console.WriteLine(otvet);
        }
    }
}
