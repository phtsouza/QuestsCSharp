using System;
using System.Globalization;

namespace Salary_with_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            vendas *= 0.15;
            salario += vendas;

            Console.WriteLine("TOTAL = R$ " + salario.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
