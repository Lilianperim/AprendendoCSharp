using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10  - Calcula Poupanca");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036; //0.36% = 0.0036 pode ser utilizado atrubuição composta: valorInvestido += valorInvestido*0.0036
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);

                //contadorMes = contadorMes + 1;
                //contadorMes += 1; //serve para qualquer operador aritmético de qualquer maneira funciona dos 3
                contadorMes++; 
            }

            /*valorInvestido = valorInvestido + valorInvestido * 0.0036; //0.36% = 0.0036
            Console.WriteLine("Após um mês você terá R$" + valorInvestido);

            valorInvestido = valorInvestido + valorInvestido * 0.0036; //0.36% = 0.0036
            Console.WriteLine("Após dois meses   você terá R$" + valorInvestido);*/


            Console.ReadLine();
        }
    }
}
