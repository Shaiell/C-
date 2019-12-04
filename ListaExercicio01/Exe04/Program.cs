using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu codigo para calcular o seu novo salario: \nTécnicos:1\nGerente:2\nDemais Funcionarios:3");
            int codigo = Convert.ToInt32(Console.ReadLine());
            double sal = 0;
            switch (codigo){

                case 1:
                    Console.WriteLine("Informe o seu salario atual: ");
                    sal = Convert.ToDouble(Console.ReadLine());
                    sal = sal * 1.5;
                    break;
                case 2:
                    Console.WriteLine("Informe o seu salario atual: ");
                    sal = Convert.ToDouble(Console.ReadLine());
                    sal = sal * 1.3;
                    break;
                case 3:
                    Console.WriteLine("Informe o seu salario atual: ");
                    sal = Convert.ToDouble(Console.ReadLine());
                    sal = sal * 1.2;
                    break;
                default:
                    Console.WriteLine("informe um codigo correto.");
                    break;
            }

            if (sal!=0) { 
            Console.WriteLine("O seu salario atualizado será: "+ sal.ToString("C2"));
            }
            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
