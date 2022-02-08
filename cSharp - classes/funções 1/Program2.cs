using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
    class Program2
    {
        static void Main(string[] args)
        {

            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora C#";
            //gabriela.cpf = "434.434.654-30";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;
            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.cpf = "213412341234";
            conta.titular.profissao = "Desenvolvedora C#";


            conta.saldo = 500;
            conta.agencia = 363;
            conta.numero = 2323;

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.ReadLine();
        }
    }
}
