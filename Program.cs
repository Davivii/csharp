using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ReadLine()
            int a = 1;
            int b = -3;
            int c = -4;
           
            double delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);
           
            MessageBox.Show("a1 = " + a1 + "\na2 = " + a2);
            Console.WriteLine();
            Console.ReadLine()

        }
    }
}
