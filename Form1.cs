using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada_comum
{
    public partial class Form1 : Form
    {
       

class Program
    {
        static void Main()
        {
            Console.Write("Digite um número para ver a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTabuada do {numero}:");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

            Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de fechar
        }
    }

}
}
