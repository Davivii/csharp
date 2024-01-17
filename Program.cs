﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_com_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        {
          
            {
                Console.Write("Digite o número para ver a tabuada: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write("Digite até qual número deseja calcular a tabuada: ");
                int limite = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nTabuada do {numero} até {limite}:");

                for (int i = 1; i <= limite; i++)
                {
                    int resultado = numero * i;
                    Console.WriteLine($"{numero} x {i} = {resultado}");
                }

                Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de fechar
            }
        }




    }
}
}
