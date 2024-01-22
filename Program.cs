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
                      
                Console.Write("Informe a cotação do dólar: ");
                float cotacaoDolar = float.Parse(Console.ReadLine());

                
                Console.Write("Informe o valor em dólares: ");
                float valorDolar = float.Parse(Console.ReadLine());

                
                float valorReal = ConverterDolarParaReal(valorDolar, cotacaoDolar);

                
                Console.WriteLine($"O valor em reais é: {valorReal:C}");
            }

            static float ConverterDolarParaReal(float valorDolar, float cotacaoDolar)
            {
                float valorReal = valorDolar * cotacaoDolar;
                return valorReal;
            }
        }

    }













