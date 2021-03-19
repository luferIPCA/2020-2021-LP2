/*
*	<copyright file="Banco.cs" company="jclab">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>João Carlos Pinto</author>
*   <date>3/16/2021 8:05:37 PM</date>
*	<description></description>
**/

namespace Aula20210316_banco
{
    /// <summary>
    /// conta bancária
    ///     numConta
    ///     Saldo
    ///     
    ///     Depositar
    ///     Levantar
    ///     Saldo?
    /// </summary>
    class BancoJC
    {

        #region ClassAtributes
        static int sequenciaConta;
        static int totContas;
        #endregion

        #region Attributes
        private int numeroConta;
        private float saldoConta;
        private bool permiteSaldoNegativo;
        #endregion

        #region ClassInternals
        /// <summary>
        /// inicializa a classe e as respetivas variáveis internas...
        /// </summary>
        static BancoJC() { sequenciaConta = 10000; totContas = 0; }

        /// <summary>
        /// incrementa o contador interno dos objetos
        /// </summary>
        static void IncrementaTotalContas() { totContas++; }

        /// <summary>
        /// incrementa a sequência e retorna o próximo número
        /// </summary>
        /// <returns></returns>
        static int CriarNovaConta() { sequenciaConta++; return sequenciaConta; }
        #endregion

        #region Constructors
        /// <summary>
        /// inicializa o objeto 
        /// </summary>
        public BancoJC()
        {
            IncrementaTotalContas();
            numeroConta = CriarNovaConta();
            saldoConta = 0;
            permiteSaldoNegativo = false;
        }

        /// <summary>
        /// inicializa o objeto com saldo
        /// </summary>
        /// <param name="novoSaldo"></param>
        public BancoJC(float novoSaldo)
        {
            IncrementaTotalContas();
            numeroConta = CriarNovaConta();
            saldoConta = novoSaldo;
            permiteSaldoNegativo = false;
        }

        /// <summary>
        /// inicializa o objeto com saldo
        /// </summary>
        /// <param name="novoSaldo"></param>
        public BancoJC(float novoSaldo, bool saldoPodeSerNegativo)
        {
            IncrementaTotalContas();
            numeroConta = CriarNovaConta();
            saldoConta = novoSaldo;
            permiteSaldoNegativo = saldoPodeSerNegativo;
        }
        #endregion

        #region ClassProperties
        /// <summary>
        /// property TotContas, total de objetos criados
        /// </summary>
        public int TotContas { get => totContas; }
        #endregion

        #region Properties
        /// <summary>
        /// property Saldo, saldo atual
        /// </summary>
        public float Saldo { get => saldoConta; }

        /// <summary>
        /// property NumeroConta, número da conta
        /// </summary>
        public int NumeroConta { get => numeroConta; }

        /// <summary>
        /// property PermiteSaldoNegativo
        /// </summary>
        public bool PermiteSaldoNegativo { get => permiteSaldoNegativo; set => permiteSaldoNegativo = value; }
        #endregion

        #region Métodos
        /// <summary>
        /// Depositar(), acrescenta um valor no saldo (verifica se o valor é positivo)
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool Depositar(float v)
        {
            if (v > 0)
            {
                saldoConta += v;
                return true;
            }
            return false;
        }

        /// <summary>
        /// PodeLevantar(), verifica se se pode fazer um levantamento
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool PodeLevantar(float v)
        {
            if (!PermiteSaldoNegativo)
            {
                return (Saldo - v > 0);
            }
            return true;
        }

        /// <summary>
        /// Levantar = retirar um valor do saldo, caso tenha saldo suficiente
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool Levantar(float v)
        {
            if (PodeLevantar(v))
            {
                saldoConta -= v;
                return true;
            }
            return false;
        }
        #endregion

        #region ClassDestructor
        /// <summary>
        /// destructor, decrementa o contador de objetos
        /// </summary>
        ~BancoJC() { totContas--; }
        #endregion

    }
}
