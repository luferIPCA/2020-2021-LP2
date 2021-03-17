/*
 * Rui Alves 15505
 * LP2
 * Data: 16/03/2021
 * Desc: Programa ATM, realiza levantamentos, depositos e consulta contas bancárias
 * 
 */

using System;
using Banco.Model;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis
            ContaBancaria b1, b2;

            //Instanciação das váriaveis
            b1 = new ContaBancaria(1000);
            b2 = new ContaBancaria(500);


            //Manipulação e apresentação de dados
            Console.WriteLine("Saldo do Banco 1: {0}", b1.Saldo);
            Console.WriteLine("Saldo do Banco 2: {0}", b2.Saldo);

            b1.DepositarDinheiro(200);
            Console.WriteLine("Saldo do Banco 1: {0}", b1.Saldo);

            Console.WriteLine("{0}", b1.LevantarDinheiro(1500) ? "Operação com sucesso!" : "Erro a operar");

            Console.WriteLine("Saldo do Banco 1: {0}", b1.Saldo);

            Console.WriteLine("O b1 tem id: {0}", b1.Conta);
            Console.WriteLine("O b2 tem id: {0}", b2.Conta);


        }
    }
}

