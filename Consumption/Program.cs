using System;
using System.Globalization;

namespace Consumption
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y;
            double consumo;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumo = X / Y;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
