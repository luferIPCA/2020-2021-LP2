/*
 * Rui Alves 15505
 * LP2
 * Data: 16/03/2021
 * Desc: Classe Banco
 *
 * 
 */

using System;
namespace Banco.Model
{
    public class ContaBancaria
    {

        #region Variaveis de Classe

        static int numConta = 0;

        #endregion

        #region Variaveis de Instância

        private int idConta;
        private int saldo;

        #endregion

        #region Construtores

        /// <summary>
        /// Contrutor que inicia o saldo e atribui o id da conta
        /// </summary>
        /// <param name="saldoInicial"></param>
        public ContaBancaria(int saldoInicial)
        {
            saldo = saldoInicial;
            idConta = numConta++;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Metodo para levantar dinheiro
        /// - Realiza verificação se o saldo é superior ou igual ao valor a retirar
        /// </summary>
        /// <param name="valor">Valor inteiro usado para decrementar se verificarem todas as condições</param>
        /// <returns></returns>
        public bool LevantarDinheiro(int valor)
        {
            //Verifica se existe saldo suficiente para a quantia pretendida a levantar
            if (saldo >= valor)
                saldo -= valor;
            else
                return false;

            return true;
        }

        /// <summary>
        /// Metodo para depositar dinheiro
        /// - Soma ao saldo existente o valor passado por parametro
        /// </summary>
        /// <param name="valor">Valor inteiro usado para incrementar ao saldo</param>
        public void DepositarDinheiro(int valor)
        {
            saldo += valor;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Propriedade para obtenção do valor do saldo
        /// </summary>
        public int Saldo
        {
            get => saldo;
        }

        /// <summary>
        /// Propriedade para obtenção do valor do id da conta
        /// </summary>
        public int Conta
        {
            get => idConta;
        }

        #endregion
    }
}
