using System;
using System.Globalization;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            double area;
            double pi = 3.14159;
            string[] vetUm = Console.ReadLine().Split(' ');

            A = double.Parse(vetUm[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetUm[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetUm[2], CultureInfo.InvariantCulture);

            area = (A * C) / 2;
            Console.WriteLine("TRIANGULO: " + area.ToString("F3", CultureInfo.InvariantCulture));

            area = pi * (C * C);
            Console.WriteLine("CIRCULO: " + area.ToString("F3", CultureInfo.InvariantCulture));

            area = ((A + B) * C) / 2;
            Console.WriteLine("TRAPEZIO: " + area.ToString("F3", CultureInfo.InvariantCulture));

            area = B * B;
            Console.WriteLine("QUADRADO: " + area.ToString("F3", CultureInfo.InvariantCulture));

            area = A * B;
            Console.WriteLine("RETANGULO: " + area.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
