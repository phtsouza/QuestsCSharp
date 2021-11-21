using System;
using System.Globalization;

namespace Salary_with_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioHora, salario;
            int number, horas;

            number = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            salarioHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * salarioHora;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
