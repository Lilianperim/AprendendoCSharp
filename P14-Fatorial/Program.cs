using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
            Console.ReadLine();
            /*O fatorial é sempre o produto de números consecutivos inteiros de 1 até o próprio número. 
             * Ex: Fatorial de 4 = 4 x 3 x 2 x 1 = 24 ou fatorial de 4 = 4 x 3! = 24. 
             * Com essa última lógica é que essa questão é feita. 
             * Pegando sempre o número que a gente quer e multiplicando pelo fatorial do número anterior.*/
        }
    }
}
