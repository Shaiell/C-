using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe01
{
    class Program
    {
        static void Main(string[] args)
        {

            double largura;
            double altura;

            Console.WriteLine("Informe a lagura: ");
            largura = Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("Informe a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            double area = largura * altura;

            Console.WriteLine("Área é " + area.ToString("F2"));

            Console.WriteLine("Aperte uma tecla para continuar...");
            Console.ReadKey();
        }
    }
}
