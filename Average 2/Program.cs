using System;
using System.Globalization;

namespace Average_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, AVERAGE;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A *= 2.0;
            B *= 3.0;
            C *= 5.0;

            AVERAGE = (A + B + C) / 10;

            Console.WriteLine("MEDIA = " + AVERAGE.ToString("F1", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
