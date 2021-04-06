using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereBanco
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria cb = new ContaBancaria();
            cb.DepositaValor(1000);
            cb.LevantaValor(200);

            ContaPoupanca cp = new ContaPoupanca();
            cp.DepositaValor(1000);
            cp.LevantaValor(200);

            Console.WriteLine("Saldo CB: " + cb.SaldoCorrente().ToString());
            Console.WriteLine("Saldo CP: " + cp.SaldoCorrente().ToString());
        }
    }
}
