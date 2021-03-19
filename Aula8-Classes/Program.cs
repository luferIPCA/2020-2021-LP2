/**
 * lufer
 * LP2
 * Estruturação de Classes
 * Overrides
 * Operadores
 */

using System;

namespace Aula8_Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            #region Pessoas
            Pessoa p1 = new Pessoa();
            p1.Nome = "Ola";
            Pessoa p2 = new Pessoa();
            p2.Nome = "Ole";
            Console.WriteLine(p1.ToString());

            Pessoas.InserePessoa(p1);
            Pessoas.InserePessoa(p2);
            Console.WriteLine("Existe: {0}",Pessoas.ExistePessoa(p1));
            #endregion

            #region ContaBancaria

            Conta c1 = new Conta(12, 123);
            Banco.InsereConta(c1);

            #endregion

            Console.ReadKey();
        }
    }
}
