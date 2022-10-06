using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int soma = 0;
            for (int i = 0; i < 10; i++) //inicializador da condição
            {
                soma += 1; // soma = soma + 1;
                Console.WriteLine(soma);
            }
            */
            int valor = 1, soma = 0;
            Console.WriteLine("Imfome os valores, digite 0 para sair!");
            while (valor != 0)
            {
                valor = int.Parse(Console.ReadLine());
                soma += valor;
            }       
            Console.WriteLine(soma);
        }
    }
}
