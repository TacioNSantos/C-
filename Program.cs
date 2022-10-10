using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Questao1()
        {
            Console.WriteLine("Imforme o valor do fatorial");
            int valor = int.Parse(Console.ReadLine());
            int n = valor - 1;

            while (n != 0)
            {
                valor = valor * (n);
                n--;
            }
            Console.WriteLine("O fatorial é {0}", valor);
        }

        static void Questao2()
        {
           for (int n = 500; n <= 1000; n++)
           {
               if (n %17 == 0 || n %31 == 0)
               {
                   Console.WriteLine(n);
               }
               
           }
        }

        static void Questao3()
        {
            for (int F = 50; F <= 65; F++)
            {
                double C = (5/9f *(F-32));
                Console.WriteLine("{0}°F  |   {1}°C", F, C);
            }
        }

        static void Questao4()
        {
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, nulo = 0, branco = 0, total = 0;
            Boolean validacao = true;

            while (validacao)
            {
                Console.WriteLine("Candidato 1");
                Console.WriteLine("Candidato 2");
                Console.WriteLine("Candidato 3");
                Console.WriteLine("Candidato 4");
                Console.WriteLine("Nulo 5");
                Console.WriteLine("Branco 6");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Fim da votação");
                        validacao = false;
                        break;
                    case 1:
                        c1++;
                        total++;
                        break;
                    case 2:
                        c2++;
                        total++;
                        break;
                    case 3:
                        c3++;
                        total++;
                        break;
                    case 4:
                        c4++;
                        total++;
                        break;
                    case 5:
                        nulo++;
                        total++;
                        break;
                    case 6:
                        branco++;
                        total++;
                        break;

                }
            }

            Console.WriteLine("Candidato 1 recebeu: {0}", c1);
        }

        static void Main(string[] args)
        {
            Questao4();
            
        }
    }
}
