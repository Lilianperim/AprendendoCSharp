using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            char primeiraLetra = ' '; //um caractere é apenas aspas simples, se for um texto é "" cabe até 16bits de número - pode ser vazia mas com espaço
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1); //ascii table tabela de texto em representação numerica ex:= % >
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia " + 2020; //string vazia = "";
            string cursosProgramacao =
 @" - .NET
 - Java
 - JavaScript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
            

            Console.ReadLine();
        }
    }
}
