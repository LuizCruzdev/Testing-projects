using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp___classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 823;
            contaDaGabriela.numero = 43834;
            contaDaGabriela.saldo = 100;

            //Console.WriteLine("{0}.{1].{2].{3]", contaDaGabriela.agencia, contaDaGabriela.numero, contaDaGabriela.saldo, contaDaGabriela.titular);
            Console.WriteLine(contaDaGabriela.agencia + "." + contaDaGabriela.numero + "." + contaDaGabriela.saldo + "." + contaDaGabriela.titular);
            Console.ReadLine();

        }
    }
}
