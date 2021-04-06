using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereBanco
{
    class ContaPoupanca: ContaBancaria
    {
        public ContaPoupanca()
        {
            saldo = 100;
        }
        public override double LevantaValor(double valor)
        {
            saldo -= (valor + 0.10);
            return valor;
        }
    }
}
