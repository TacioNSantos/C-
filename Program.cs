using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Imforme o valor do fatorial");
            int valor = int.Parse(Console.ReadLine());
            int n = valor;

            while (valor >= 1)
            {
            valor = valor * (n-1);
                n --;
            Console.WriteLine(valor);
            }
        }
    }
}
