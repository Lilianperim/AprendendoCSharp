using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaLilian = new ContaCorrente(); //referência/instância (contaDaLilian) para a criação do objeto Contacorrente
            contaDaLilian.titular = "Lilian";
            contaDaLilian.agencia = 863;
            contaDaLilian.numero = 123456;

            ContaCorrente contaDoCleber = new ContaCorrente(); 
            contaDoCleber.titular = "Cleber";
            contaDoCleber.agencia = 863;
            contaDoCleber.numero = 123456;

            Console.WriteLine("Igualdade de tipo de referência:" + (contaDaLilian == contaDoCleber));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo valor:" + (idade == idadeMaisUmaVez));

            contaDaLilian = contaDoCleber;
            Console.WriteLine(contaDaLilian == contaDoCleber);

            contaDaLilian.saldo = 300;
            Console.WriteLine(contaDaLilian.saldo); 
            Console.WriteLine(contaDoCleber.saldo);

            Console.ReadLine();


        }
    }
}
