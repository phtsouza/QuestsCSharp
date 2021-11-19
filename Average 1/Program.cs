using System;
using System.Globalization;

namespace Average_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, AVERAGE;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A *= 3.5;
            B *= 7.5;

            AVERAGE = (A + B) / 11;

            Console.WriteLine("MEDIA = " + AVERAGE.ToString("F5", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
