using System;

namespace Subsequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntdCasos;
            int qntdString;
            string principal, subString;
            int i, j;

            qntdCasos = int.Parse(Console.ReadLine());

            for(i = 0; i < qntdCasos; i++)
            {
                principal = Console.ReadLine();
                qntdString = int.Parse(Console.ReadLine());

                for(j = 0; j< qntdString; j++)
                {
                    subString = Console.ReadLine();

                    if (principal.Contains(subString))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }    
            }
        }
    }
}
