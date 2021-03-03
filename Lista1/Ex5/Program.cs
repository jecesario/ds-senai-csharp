using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            string a = Console.ReadLine();

            byte[] ascii = Encoding.ASCII.GetBytes(a);

            foreach (byte item in ascii)
            {
                Console.WriteLine("Valor ASCII: " + item);
            }
            Console.ReadLine();
        }
    }
}
