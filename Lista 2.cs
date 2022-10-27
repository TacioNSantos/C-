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
                if (n % 17 == 0 || n % 31 == 0)
                {
                    Console.WriteLine(n);
                }

            }
        }

        static void Questao3()
        {
            for (int F = 50; F <= 65; F++)
            {
                double C = (5 / 9f * (F - 32));
                Console.WriteLine("{0}°F  |   {1}°C", F, C);
            }
        }

        static void Questao4()
        {
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, nulo = 0, branco = 0, total = 0;
            Boolean validacao = true;

            while (validacao)
            {
                Console.WriteLine("Informe o candidato");
                Console.WriteLine("===================");
                Console.WriteLine("1 - Candidato");
                Console.WriteLine("2 - Candidato");
                Console.WriteLine("3 - Candidato");
                Console.WriteLine("4 - Candidato");
                Console.WriteLine("5 - Nulo");
                Console.WriteLine("6 - Branco");
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
                    default:
                        Console.WriteLine("Informe corretamente!!!");
                        break;
                }
            }

            Console.WriteLine("O candidato 1 recebeu: {0}", c1);
            Console.WriteLine("O candidato 2 recebeu: {0}", c2);
            Console.WriteLine("O candidato 3 recebeu: {0}", c3);
            Console.WriteLine("O condidato 4 recebeu: {0}", c4);
            Console.WriteLine("O total de votos brancos: {0}", branco);
            Console.WriteLine("O total de votos brancos: {0}", nulo);
            float percBranco = branco * 100 / total;
            float percNulo = nulo * 100 / total;
            Console.WriteLine("O percentual de votos brancos: {0}%", percBranco);
            Console.WriteLine("O percentual de votos nulos: {0}%", percNulo);

        }

            
        static void Main(string[] args)
        {

            Questao4();
        }
    }
}
