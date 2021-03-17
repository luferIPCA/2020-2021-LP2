/* 
 * 
 * Author: Pedro Braga
 * Contact: 21117@alunos.ipca.pt
 * Description: Pequeno exemplo de conta bancária.
 *
 */

namespace Classes
{
    /// <summary>
    /// Classe que descreve uma conta bancária
    /// </summary>
    class ContaBancariaI
    {
        #region Attributes

        private int numConta;
        private double saldo;

        #endregion

        #region Constructor

        /// <summary>
        /// Construtor do objeto.
        /// </summary>
        /// <param name="numConta">Número de conta bancária</param>
        /// <param name="saldo">Saldo bancário</param>
        public ContaBancariaI(int numConta, double saldo)
        {
            this.numConta = numConta;
            this.saldo = saldo;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Propriedade do atributo NumConta
        /// </summary>
        public int NumConta
        {
            get
            {
                return this.numConta;
            }
        }

        /// <summary>
        /// Propriedade do atributo Saldo
        /// </summary>
        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                if (value>0) this.saldo = value;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Metodo LevantarDinheiro
        /// </summary>
        /// <param name="quantia">Quantia a levantar</param>
        /// <returns></returns>
        public bool LevantarDinheiro(double quantia)
        {
            if (quantia <= 0) return false;
            double s = saldo - quantia;
            if (s < 0) return false;
            else
            {
                saldo = s;
                return true;
            }
        }

        /// <summary>
        /// Metodo DepositarDinheiro
        /// </summary>
        /// <param name="quantia">Quantia a depositar</param>
        /// <returns></returns>
        public bool DepositarDinheiro(double quantia)
        {
            if (quantia <= 0) return false;
            saldo += quantia;
            return true;
        }

        #endregion
    }
}