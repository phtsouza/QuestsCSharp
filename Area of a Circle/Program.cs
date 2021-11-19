using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;
            double A, R;

            R = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            A = (R * R) * n;

            Console.WriteLine("A=" + A.ToString("F4",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
