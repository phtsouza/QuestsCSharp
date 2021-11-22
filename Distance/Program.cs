using System;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int dist;
            int tempo;

            dist = int.Parse(Console.ReadLine());
            tempo = dist * 2;

            Console.WriteLine(tempo + " minutos");
        }
    }
}
