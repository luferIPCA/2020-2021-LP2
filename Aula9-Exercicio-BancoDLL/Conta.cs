/* 
 * lufer
 * LP2 - LESI
 * Estruturar Classes
 * */

namespace BancoDLL
{
    /// <summary>
    /// Classe que descreve uma conta bancária
    /// Author: Pedro Braga
    /// Contact: 21117@alunos.ipca.pt
    /// Description: Pequeno exemplo de conta bancária.
    /// </summary>
    public class Conta
    {
        #region Attributes

        int numConta;
        double saldo;

        #endregion

        #region Constructor

        /// <summary>
        /// Construtor do objeto.
        /// </summary>
        /// <param name="numConta">Número de conta bancária</param>
        /// <param name="saldo">Saldo bancário</param>
        public Conta(int numConta, double saldo)
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

    /// <summary>
    /// Classe que gere um Banco
    /// </summary>
    public class Banco
    {
        const int MAX = 100;
        static Conta[] contas;
        static int totContas;

        static Banco()
        {
            contas = new Conta[MAX];
            totContas = 0;
        }

        public static int TotContas
        {
            get => totContas;
        }

        /// <summary>
        /// Insere nova conta
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool InsereConta(Conta c)
        {
            //verificar se existe
            //Verificar se ainda há espaço
            contas[totContas++] = c;
            return true;
        }

        /// <summary>
        /// Encontra determinada conta
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static Conta QualConta(int num)
        {
            foreach(Conta c in contas)
            {
                if (c.NumConta == num) return c;
            }
            return null;
        }

        /// <summary>
        /// Verifica se determinada conta existe
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool ExisteConta(int num)
        {
            for (int i = 0; i < totContas; i++)
            {
                if (contas[i].NumConta == num) return true;
            }
            return false;
        }

    }


    /// <summary>
    /// Classe que gere vários Bancos
    /// </summary>
    public class BancoPortugal
    {
        static Banco[] varios;


    }
}