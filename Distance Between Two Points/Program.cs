using System;
using System.Globalization;

namespace Distance_Between_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2;
            double distancia;

            string[] pontos1 = Console.ReadLine().Split(' ');
            string[] pontos2 = Console.ReadLine().Split(' ');

            x1 = double.Parse(pontos1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(pontos1[1], CultureInfo.InvariantCulture);

            x2 = double.Parse(pontos2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(pontos2[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
