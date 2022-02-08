using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Bytebank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Saldo = -10;
            Cliente rogerio = new Cliente();

            rogerio.Nome = "Rogério Almeida";
            rogerio.CPF = "123232341234";
            rogerio.Profissao = "Agricultor";

            conta.Titular = rogerio;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Titular.CPF);
            Console.WriteLine(conta.Titular.Profissao);
            Console.ReadLine();
        }
    }
}
