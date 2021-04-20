using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11  - Calcula Poupanca 2 com for");

            double valorInvestido = 1000;

            for (int contadorMes = 1;  contadorMes <= 12; contadorMes++)
            {
                valorInvestido += valorInvestido * 0.0036;//+= é igual a essa expressão: valor investido + valor investido *0.0036
                Console.WriteLine("Após " + contadorMes +
                    " meses você terá R$" + valorInvestido);
            }




            Console.ReadLine();
        }
    }
}
