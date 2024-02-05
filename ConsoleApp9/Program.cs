using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение параметра x:");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double z = 5 * Math.Sin(x) - 7 * Math.Cos(x);
            Console.WriteLine($"Значение z = {z}.");
            Console.ReadKey();
        }
    }
}
