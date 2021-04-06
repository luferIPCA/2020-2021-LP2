/*
 * Herança de Classes
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta c1 = new Conta();
            c1.num = 1;
            c1.titular.nome = "ola";
            //c1.tipo = TIPOCONTA.CC;
            c1.saldo = 1000;

            c1.Deposito(300);
            c1.Levantamento(150);

            Conta c2 = new Conta();
            c2.num = 2;
            c2.titular.nome = "ole";
            //c2.tipo = TIPOCONTA.CP;
            c2.saldo = 1000;
            c2.Deposito(350);
            c2.Levantamento(100);


            ContaPoupanca c3 = new ContaPoupanca();
            c3.Deposito(1000);
            c3.Levantamento(130);


            ContaBancariaPoupanca c4 = new ContaBancariaPoupanca("oli",12,124.5);
            
            c4.Deposito(1200);
            c4.Levantamento(120);

            ContaBancariaPoupanca c5 = new ContaBancariaPoupanca("olu", 13, 1200.5,DateTime.Now);

        }
    }
}
