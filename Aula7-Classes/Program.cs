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
using Aula20210316_banco;

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

            #region ExercicioContaBancaria III
            // definir arrays diferentes para testar o total de contas criadas
            BancoJC[] contas1 = new BancoJC[10];
            BancoJC[] contas2 = new BancoJC[5];
            BancoJC[] contas3 = new BancoJC[15];
            Random r = new Random();

            Console.WriteLine("Criar um conjunto de contas com saldos aleatórios:");
            // criar contas com saldo aleatório
            for (int i = 0; i < contas1.Length; i++) { contas1[i] = new BancoJC(r.Next(0, 500)); }
            for (int i = 0; i < contas2.Length; i++) { contas2[i] = new BancoJC(r.Next(0, 100), (bool)(i % 2 == 0)); }
            for (int i = 0; i < contas3.Length; i++) { contas3[i] = new BancoJC(r.Next(0, 200)); }

            // varificar o contador total de objetos...
            Console.WriteLine("Total de contas criadas = {0}", contas1[0].TotContas);
            // imprimir todos os saldos das contas de todos os arrays...
            FrontEnd.MostrarSaldos(contas1, "[contas1] inicial");
            FrontEnd.MostrarSaldos(contas2, "[contas2] inicial");
            FrontEnd.MostrarSaldos(contas3, "[contas3] inicial");

            Console.WriteLine("Fazer alguns depósitos:");
            // fazer alguns depósitos aleatórios no array pequeno
            foreach (BancoJC c in contas2)
            {
                int v = r.Next(1, 500);
                float sld = c.Saldo;
                bool sucesso = c.Depositar(v);
                Console.WriteLine("Depositar na conta nº {0} o valor {1}, saldo anterior={2}, novo saldo={3}, resultado={4}", c.NumeroConta.ToString(), v.ToString(), sld.ToString(), c.Saldo.ToString(), sucesso ? "sucesso" : "não permitido");
            }
            Console.WriteLine("Mostrar novos saldos:");
            FrontEnd.MostrarSaldos(contas2, "[contas2] inicial");

            Console.WriteLine("Fazer alguns levantamentos:");
            // fazer alguns levantamentos aleatórios no array pequeno
            foreach (BancoJC c in contas2)
            {
                int v = r.Next(1, 500);
                float sld = c.Saldo;
                bool sucesso = c.Levantar(v);
                Console.WriteLine("Fazer um levantamento da conta nº {0}, valor={1}, saldo anterior={2}, novo saldo={3}, resultado={4}", c.NumeroConta.ToString(), v.ToString(), sld.ToString(), c.Saldo.ToString(), sucesso ? "sucesso" : "não permitido");
            }
            Console.WriteLine("Mostrar novos saldos:");
            FrontEnd.MostrarSaldos(contas2, "[contas2] inicial");

            // parar até uma tecla...
            Console.ReadKey();
            #endregion
            Console.ReadKey();

        }
    }

    class FrontEnd
    {
        static public void MostrarSaldos(BancoJC[] ct, string texto)
        {
            Console.WriteLine("{0}", texto);
            foreach (BancoJC c in ct)
            {
                string aux = c.PermiteSaldoNegativo ? "tem plafond de crédito" : "sem autorização descoberto";
                Console.WriteLine("Conta nº {0} tem o saldo {1} [{2}]", c.NumeroConta.ToString(), c.Saldo.ToString(), aux);
            }
        }
    }
}
