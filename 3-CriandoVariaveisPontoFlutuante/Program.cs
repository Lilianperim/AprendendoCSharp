using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 Criando variáveis ponto flutuante");

            double salario;
            salario = 1270.70;
            Console.WriteLine(salario);

            double idade;
            idade = 15.0 / 2; //um dos numeros precisa ser double para que o resultado apareça como double
            Console.WriteLine(idade);

            Console.WriteLine("A execução acabou, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
