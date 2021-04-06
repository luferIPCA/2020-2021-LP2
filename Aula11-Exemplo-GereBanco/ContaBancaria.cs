using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereBanco
{
    class ContaBancaria : DadosContaBancaria, IContaBancaria
    {
        protected double saldo;


        public ContaBancaria()
        {
            saldo = 0;
        }
        public override string IBAN()
        {
            return base.iban.ToUpper();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public bool DepositaValor(double valor)
        {
            //verificar regras
            saldo += valor;
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public virtual double LevantaValor(double valor)
        {
            //verificar regras
            saldo -= valor;
            return valor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double SaldoCorrente()
        {
            return saldo;
        }

    }
}
