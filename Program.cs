using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{   
    internal class Program
    {
       


    
        static void Main()
        {          
            Console.Write("Informe a quantidade mínima em estoque: ");
            float quantidadeMinima = float.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade máxima em estoque: ");
            float quantidadeMaxima = float.Parse(Console.ReadLine());

            
            float estoqueMedio = CalcularEstoqueMedio(quantidadeMinima, quantidadeMaxima);
          
            Console.WriteLine($"O estoque médio é: {estoqueMedio}");
        }

        static float CalcularEstoqueMedio(float quantidadeMinima, float quantidadeMaxima)
        {
            float estoqueMedio = (quantidadeMinima + quantidadeMaxima) / 2;
            return estoqueMedio;





        }
    }











}

