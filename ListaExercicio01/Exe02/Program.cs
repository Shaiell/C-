using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor em reais para a conversão: ");
            double valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Reais: "+ valor.ToString("C2"));
            Console.WriteLine("Reais: "+ (valor/3.78).ToString("C2"));
            Console.WriteLine("Reais: "+ (valor/4.21).ToString("C2"));
            Console.WriteLine("Reais: "+ (valor/0.08).ToString("C2"));

            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
