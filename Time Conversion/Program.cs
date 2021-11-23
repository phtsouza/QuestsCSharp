using System;

namespace Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec;
            int hors, min;

            sec = int.Parse(Console.ReadLine());

            hors = sec / 3600;
            sec = sec - (hors * 3600);

            min = sec / 60;
            sec = sec - (min * 60);

            Console.WriteLine(hors + ":" + min + ":" + sec);
        }
    }
}
