using System;
using System.Globalization;

namespace Sphere
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double R;
            double volumeEsfera;

            R = double.Parse(Console.ReadLine());

            volumeEsfera = (4 / 3.0) * pi * (R * R * R);

            Console.WriteLine("VOLUME = " + volumeEsfera.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
