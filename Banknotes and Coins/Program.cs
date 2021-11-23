using System;
using System.Globalization;


namespace Banknotes_and_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, restoCentavos;
            int nota100, nota50, nota20, nota10, nota5, nota2;
            int moeda50, moeda25, moeda10, moeda05, moeda01;
            int resto;

            n = double.Parse(Console.ReadLine());

            resto = (int)n/100;
            restoCentavos = (n) % 100;

            nota100 = resto / 100;
            resto = resto - (nota100 * 100);

            nota50 = resto / 50;
            resto = resto - (nota50 * 50);

            nota20 = resto / 20;
            resto = resto - (nota20 * 20);

            nota10 = resto / 10;
            resto = resto - (nota10 * 10);

            nota5 = resto / 5;
            resto = resto - (nota5 * 5);

            nota2 = resto / 2;
            resto = resto - (nota2 * 2);

            moeda50 = (int)(restoCentavos / 50);
            restoCentavos = restoCentavos - (moeda50 * 50);

            moeda25 = (int)(restoCentavos / 25.0);
            restoCentavos = restoCentavos - (moeda25 * 25);

            moeda10 = (int)(restoCentavos / 10.0);
            restoCentavos = restoCentavos - (moeda10 * 10);

            moeda05 = (int)(restoCentavos / 5.0);
            restoCentavos = restoCentavos - (moeda05 * 5);

            moeda01 = (int)restoCentavos;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(nota100 + " nota(s) de R$ 100.00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50.00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20.00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10.00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5.00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine(resto + " moeda(s) de R$ 1.00");
            Console.WriteLine(moeda50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(moeda25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(moeda10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(moeda05 + " moeda(s) de R$ 0.05");
            Console.WriteLine(moeda01 + " moeda(s) de R$ 0.01");
        }
    }
}
