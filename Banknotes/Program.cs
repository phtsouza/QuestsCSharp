using System;

namespace Banknotes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int nota100, nota50, nota20, nota10, nota5, nota2;
            int resto;

            n = int.Parse(Console.ReadLine());

            resto = n;

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

            Console.WriteLine(n);
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
            Console.WriteLine(resto + " nota(s) de R$ 1,00");
        }
    }
}
