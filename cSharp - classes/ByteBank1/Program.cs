using ByteBank1.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            

            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "534.534.345-34";
            carlos.Salario = 3420;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "432.234.443-22";
            roberta.Salario = 6000;


            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine(carlos.Nome);

            Console.WriteLine(roberta.GetBonificacao());
            Console.WriteLine(roberta.Nome);

            Console.ReadLine();
        }
    }
}
