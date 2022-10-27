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
            /*int IdadeJoao = 15;
int IdadeMaria = 30;
int IdadeMarcelo = 20;
float resultado;

resultado = ((IdadeJoao + IdadeMarcelo + IdadeMaria) / 3);
Console.WriteLine(resultado);
*/

//////////////////////////////////////////////////////////////////

int a = 3;
int b = 6;
int c = 7;

double delta = (b * b - 4 * a * c);
double raiz = Math.Sqrt(delta);

double x1 = ((-b) + raiz) / (2 * a);
double x2 = ((-b) - raiz) / (2 * a);

Console.WriteLine(x1);
Console.WriteLine(x2);
Console.ReadKey();

///////////////////////////////////////////////

/* float p, a, IMC;

Console.WriteLine("Imforme seu peso");
p = float.Parse(Console.ReadLine());
Console.WriteLine("Imforme sua altura");
a = float.Parse(Console.ReadLine());

IMC = (p / (a*a));
Console.WriteLine(IMC);
*/
        }
    }
}
