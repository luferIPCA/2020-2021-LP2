using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p = new Pessoa();        //criar um objeto do tipo Pessoa

            Pessoa p1 = new Pessoa("ola", 12);

            Pessoa p2 = new Pessoa(13, "ole");

            Console.WriteLine("Nome p = "+ p.GetNome());
            p.SetNome("oli");
            Console.WriteLine("Nome p = " + p.GetNome());

            p.Idade = 3;
            p.Nome = "lufer";       //set
            if (p.Nome == "lufer")  //get
            {
                Console.WriteLine("Nome p = " + p.Nome);
            }

            Console.WriteLine("Pessoas: " + p.TotalPessoas);
            Console.WriteLine("Pessoas: " + Pessoa.TotPessoas);
            Console.ReadKey();

        }
    }
}
