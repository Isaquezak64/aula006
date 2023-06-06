using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite de 1 a 10");
            int numero = int.Parse(Console.ReadLine());

            if (numero>10)
            {
                Console.WriteLine("digite um número válido"); Console.ReadKey();
                Main(null);
                return;
            }
            Console.WriteLine("FIM DO PROGRAMA");
            Console.ReadKey();

        }
    }
}
