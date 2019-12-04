using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe06
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            double numTotal = 0;
            Console.WriteLine("Informe um numero para media Aritimetica: ");
            int num = Convert.ToInt32(Console.ReadLine());
            do
            {
                numTotal = numTotal + num;
                cont++;
                Console.WriteLine("Informe um numero para media Aritimetica: ");
                num = Convert.ToInt32(Console.ReadLine());

            } while (num >=0);

            numTotal = numTotal / cont;
            Console.WriteLine($"A media aritimetica é {numTotal.ToString("F2")}");

            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
