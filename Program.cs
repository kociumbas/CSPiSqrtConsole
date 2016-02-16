using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3PierwiastekZPi
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            double root = Math.Sqrt(pi);
            Console.WriteLine("Pierwiastek kwadratowy z liczby Pi = {0:#.##}", root);
            Console.ReadLine();
        }
    }
}
