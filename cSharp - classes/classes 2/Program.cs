using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            conta.agencia = 12;
            conta.numero = 133;
            conta.saldo = 1000;

            Console.WriteLine(conta.saldo);
            Console.ReadLine();
        }
    }
}
