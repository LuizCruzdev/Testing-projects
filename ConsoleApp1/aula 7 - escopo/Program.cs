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
            string mensagem;

            if (acompanhado)
            {
                mensagem = "João Está acompanhado";
            }
            else
            {
                mensagem = "João Está sozinho";
            }

            if (idadeJoao > 18 || acompanhado)
            {
                Console.WriteLine("João pode entrar");
                Console.WriteLine(mensagem);
            }
            else
            {
                Console.WriteLine("João não pode entrar");
                Console.WriteLine(mensagem);
            }

            Console.ReadLine();
        }
    }
}
