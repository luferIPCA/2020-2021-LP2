using Calculos;
using System;
using BancoDLL;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"A soma de 2 com 3 = {Operacoes.Soma(2, 3)}");

            Outras.Mostra("Ola");

            Conta c1 = new Conta(12, 1234.5);
            Banco.InsereConta(c1);
            Console.WriteLine($"Existe a conta Nº {c1.NumConta}? {Banco.ExisteConta(c1.NumConta)}");
            Console.ReadKey();
        }
    }
}
