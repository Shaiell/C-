using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe A sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            switch (idade)
            {
                case int n when(n > 0 && n<= 13):
                    Console.WriteLine("Criança");
                    break;
                case int n when (n > 0 && n <= 18):
                    Console.WriteLine("Adolescente");
                    break;
                case int n when (n > 0 && n <= 60):
                    Console.WriteLine("Adulto");
                    break;
                case int n when (n > 0 && n > 60):
                    Console.WriteLine("Idoso");
                    break;
                default:
                    Console.WriteLine("Idade informeda incorreta");
                    break;
            }

            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey();

        }
    }
}
