using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12 - laços com FOR encadeado");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;

            for(int contadorAno = 1; contadorAno <= 5; contadorAno++)//segundo bloco é a condição q vai manter o laço(5anos); o último é o bloco de incremento
            {
                for(int contadorMes = 1; contadorMes <=12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;//*= pra nao ter q repetir valorInvestido = valorInvestido *fator...
                                    }
                fatorRendimento += 0.0010;//vai aumentar o fator rendimento
            }

            Console.WriteLine("Ao término do investimento você terá R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
