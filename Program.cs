using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.ReadLine();
            int idadejose = 10;
            int idadetasha = 25;
            int idadevanessa = 30;
            // Calcule a média das idades.
            double mediaIdades = (idadejose + idadetasha + idadevanessa) / 3.0;
            // Exiba o resultado em um MessageBox.
            MessageBox.Show("A média das idades é: " + mediaIdades);
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
