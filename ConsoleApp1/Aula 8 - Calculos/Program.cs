using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_8___Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula Poupança");

            double valorInvestido = 1000;
            double rend = 1.005;

            valorInvestido = valorInvestido * Math.Pow(rend, 60);
            //for (int ano = 1; ano <= 5; ano++)
            //{
            //    for (int mes = 1; mes <= 12; mes++)
            //    {
            //        valorInvestido = valorInvestido * rend;
            //        Console.WriteLine(valorInvestido);

            //    }
            //    rend += 0.001;

            //}

            Console.WriteLine("Após o período de 5 anos, o valor será " + valorInvestido);

            Console.ReadLine();
        }
    }
}
