/*
 * lufer
 * LP2
 * Mnipulação de Classes:
 * Atributos
 * Construtores
 * Propriedades
 * Resolução de Exercício
 * */

using System;
using Banco.Model;      //Folder onde se encontra a class ContaBancaria

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Um
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

            Console.WriteLine("Pessoas: " + p.TotPessoas);
            Console.WriteLine("Pessoas: " + Pessoa.TotalPessoas);

            #endregion


            #region ExercicioContaBancaria I
            Console.WriteLine("Banco I");
            ContaBancariaI b3 = new ContaBancariaI(123, 234.6);
            bool aux = b3.LevantarDinheiro(100);
            if (aux)
            {
                Console.WriteLine($"Saldo Disponivel: {b3.Saldo}");
            }
            #endregion

            #region ExercicioContaBancaria II

            Console.WriteLine("\nBanco II");
            //Declaração de variaveis
            ContaBancariaII b1, b2;

            //Instanciação das váriaveis
            b1 = new ContaBancariaII(1000);
            b2 = new ContaBancariaII(500);


            //Manipulação e apresentação de dados
            Console.WriteLine("Saldo do Banco 1: {0}", b1.Saldo);
            Console.WriteLine("Saldo do Banco 2: {0}", b2.Saldo);

            b1.DepositarDinheiro(200);
            Console.WriteLine("Saldo do Banco 1: {0}", b1.Saldo);

            Console.WriteLine("{0}", b1.LevantarDinheiro(1500) ? "Operação com sucesso!" : "Erro a operar");

            Console.WriteLine("Saldo do Banco 1: {0}", b1.Saldo);

            Console.WriteLine("O b1 tem id: {0}", b1.Conta);
            Console.WriteLine("O b2 tem id: {0}", b2.Conta);
            #endregion

            Console.ReadKey();

        }
    }
}
