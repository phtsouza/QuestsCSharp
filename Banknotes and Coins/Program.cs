using System;
using System.Globalization;


namespace Banknotes_and_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            int nota100, nota50, nota20, nota10, nota5, nota2;
            int moeda1, moeda50, moeda25, moeda10, moeda05, moeda01;

            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n += 0.001;

            nota100 = (int)Math.Floor(n / 100.00);
            n = n % 100;

            nota50 = (int)Math.Floor(n / 50.00);
            n = n % 50;

            nota20 = (int)Math.Floor(n / 20.00);
            n = n % 20;

            nota10 = (int)Math.Floor(n / 10.00);
            n = n % 10;

            nota5 = (int)Math.Floor(n / 5.00);
            n = n % 5;

            nota2 = (int)Math.Floor(n / 2.00);
            n = n % 2;

            moeda1 = (int)Math.Floor(n / 1.00);
            n = n % 1.00;

            moeda50 = (int)Math.Floor(n / 0.50);
            n = n % 0.50;

            moeda25 = (int)Math.Floor(n / 0.25);
            n = n % 0.25;

            moeda10 = (int)Math.Floor(n / 0.10);
            n = n % 0.10;

            moeda05 = (int)Math.Floor(n / 0.05);
            n = n % 0.05;

            moeda01 = (int)Math.Floor(n / 0.01);
            n = n % 0.01;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(nota100 + " nota(s) de R$ 100.00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50.00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20.00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10.00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5.00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moeda1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(moeda50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(moeda25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(moeda10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(moeda05 + " moeda(s) de R$ 0.05");
            Console.WriteLine(moeda01 + " moeda(s) de R$ 0.01");
        }
    }
}
