using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro Numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo Numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >num2) {
                Console.WriteLine("numero "+num1+" é maior que "+num2);
            }else if(num2 >num1){
                Console.WriteLine("numero " + num2 + " é maior que " + num1);
            }
            else
            {
                Console.WriteLine("O numero " + num1 + " é igual ao numero " + num2);
            }

            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
