﻿using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double xa, xb, xc, ya, yb, yc;

            Console.WriteLine("Entre com as medidas do triangulo X");

            xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y");

            ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xa + xb + xc) / 2.0;
            double areaX = Math.Sqrt(p * (p - xa) * (p - xb) * (p - xc));

             p = (ya + yb + yc) / 2.0;
            double areaY = Math.Sqrt(p * (p - ya) * (p - yb) * (p - yc));

            Console.WriteLine("area de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}
