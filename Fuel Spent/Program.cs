using System;
using System.Globalization;

namespace Fuel_Spent
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, velocidadeMedia;
            int distancia;
            double combustivelGasto;

            horas = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            distancia = horas * velocidadeMedia;

            combustivelGasto = distancia / 12.0;

            Console.WriteLine(combustivelGasto.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
