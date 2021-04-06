using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereBanco
{
    /// <summary>
    /// 
    /// </summary>
    interface IContaBancaria
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        bool DepositaValor(double valor);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        double LevantaValor(double valor);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        double SaldoCorrente();
    }
}
