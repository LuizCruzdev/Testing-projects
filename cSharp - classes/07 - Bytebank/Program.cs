using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867,8928922);
            //conta.Numero = 829202222;
            //conta.Agencia = 876;

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.ReadLine();


        }
    }
}
