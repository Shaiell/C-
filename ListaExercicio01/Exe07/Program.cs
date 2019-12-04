using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe07
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe um valor para sequencia de fibonacci");
            int num = Convert.ToInt32(Console.ReadLine());
            int cont = 0;
            int aux = 1;
            int aux1 = 1;
            int aux2 = 0;
            List<int> fibo = new List<int>();

            fibo.Add(0);
            fibo.Add(1);
            fibo.Add(1);

            for (cont = 0; aux2 < num; cont++){
                aux2 = aux + aux1;
                aux = aux1;
                aux1 = aux2;
                fibo.Add(aux2);
            }

            foreach (var fibi in fibo){
                if(fibi < num) { 
                Console.WriteLine(fibi);
                }
            }

            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
