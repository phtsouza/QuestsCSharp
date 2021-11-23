using System;

namespace Age_in_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;

            dia = int.Parse(Console.ReadLine());

            ano = dia / 365;
            dia = dia - (ano * 365);

            mes = dia / 30;
            dia = dia - (mes * 30);

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
        }
    }
}
