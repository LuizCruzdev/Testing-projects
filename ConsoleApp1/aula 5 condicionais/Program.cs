using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_5_condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando condicionais");

            int idadeJoao = 16;
            bool acompanhado = true;

            if (idadeJoao > 18)
            {
                Console.WriteLine("João pode entrar");
            }
            else
            {
                if (acompanhado)
                {
                    Console.WriteLine("Apesar de ser menor, está acompanhado e pode entrar");
                }
                else 
                {
                    Console.WriteLine("João é de menor!");
                }
            }

            Console.ReadLine();
        }
    }
}
