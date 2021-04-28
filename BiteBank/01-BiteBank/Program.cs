using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BiteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaLilian = new ContaCorrente();

            contaDaLilian.titular = "Lilian";
            contaDaLilian.agencia = 863;
            contaDaLilian.numero = 563142;
            contaDaLilian.saldo = 100;


            Console.WriteLine("Nome: " + contaDaLilian.titular);
            Console.WriteLine("Agência: " + contaDaLilian.agencia);
            Console.WriteLine("Nº Conta: " + contaDaLilian.numero);
            Console.WriteLine("Saldo: R$" + contaDaLilian.saldo);

            //contaDaLilian.saldo += 200; *atualizando saldo* 
            // Console.WriteLine("Saldo: R$" + contaDaLilian.saldo);

      

            Console.ReadLine();


        }
    }
}
