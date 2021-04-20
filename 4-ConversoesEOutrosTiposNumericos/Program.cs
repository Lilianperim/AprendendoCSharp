using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;

            //int ocupa 32bits 
            int salarioEmInteiro = (int)salario;//casting = conversão de variavel (neste caso double para int)
            Console.WriteLine(salarioEmInteiro);

            long idade = 13000000000; //int ocupa 32bits valores muito grandes não cabem ex: 13000000000 neste caso usamos long de 64bits
            Console.WriteLine(idade);

            short quantidadeProdutos = 15000; //short é utilizado para números menores ocupa 16bits
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f; //float suporta uma precisão menor em comparação com o double, o f no final para o compilador aceitar, pois não é muito usual números com vírgula com float
            Console.WriteLine(altura);

            Console.WriteLine("A execução terminou, tecle entre enter para continuar...");
            Console.ReadLine();


        }
    }
}
