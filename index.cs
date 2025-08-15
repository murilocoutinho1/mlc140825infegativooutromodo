using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            WriteLine("Digite um número");
            a = int.Parse(ReadLine());

            if (a < 0)
            {
                WriteLine($"O número {a} é negativo");
            }
            else
            {
                if (a == 0)
                {
                    WriteLine($"O número {a} é igual a zero!");
                }
                else
                {
                    WriteLine($"O número é positivo!");
                }
            }
            }
        }
    }
}
