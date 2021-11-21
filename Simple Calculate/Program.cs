using System;
using System.Globalization;

namespace Simple_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int code1, unit1, code2, unit2;
            double preco1, preco2;
            double totalCompra;

            string[] vetUm = Console.ReadLine().Split(' ');
            string[] vetDois = Console.ReadLine().Split(' ');

            code1 = int.Parse(vetUm[0]);
            unit1 = int.Parse(vetUm[1]);
            preco1 = double.Parse(vetUm[2], CultureInfo.InvariantCulture);

            code2 = int.Parse(vetDois[0]);
            unit2 = int.Parse(vetDois[1]);
            preco2 = double.Parse(vetDois[2], CultureInfo.InvariantCulture);

            totalCompra = (unit1 * preco1) + (unit2 * preco2);

            Console.WriteLine("VALOR A PAGAR: R$ " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
