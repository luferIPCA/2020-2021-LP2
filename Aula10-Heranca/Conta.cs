/*
*	<copyright file="Heranca.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>3/26/2021 9:58:48 AM</date>
*	<description>
*	Gerir uma conta bancária
*	Herança de classes
*	virtual / override / new
*	
*	Abordagens:
*	H1: Uma classe comporta todo o tipo de conta bancária (class Conta)
*	H2: Uma classe para cada tipo de conta bancária (class Conta e class ContaPoupanca)
*	H3: Uma herança de classes: (class ContaBancaria e class ContaBancariaPoupanca : ContaBancaria)
*	</description>
**/
using System;

#region Auxiliar
public struct Cliente
{
    public string nome;
}

public enum TIPOCONTA { CC,CE,CP}

#endregion

namespace Heranca
{

    #region SEM_HERANÇA

    #region CLASSE_SUPORTA_VARIOS_TIPOS_DE_CONTAS
    /// <summary>
    /// Purpose: Gerir conta bancária
    /// 
    /// Created by: lufer
    /// Created on: 3/26/2021 9:58:48 AM
    /// </summary>
    /// <remarks>
    /// Levantamento de Conta Corrente (CC) é gratuito!
    /// Levantamento de Conta Poupança (CP) custa 10 centimos;
    /// </remarks>
    /// <example></example>
    public class Conta : QuaseConta, IConta 
    {
        #region Attributes

        public int num;
        public Cliente titular;
        public double saldo;
        public TIPOCONTA tipo;

        #endregion

        #region Methods

        public override double Consulta(DateTime dia)
        {
            //throw new NotImplementedException();
            return saldo;
        }

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Conta()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public bool Deposito(double valor)
        {
            saldo += valor;
            return true;
        }
        /// <summary>
        /// Levantamento é diferente dependendo do tipo de conta
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public double Levantamento(double valor)
        {
            if (this.tipo == TIPOCONTA.CC)
                saldo -= valor;
            else
                saldo -= (valor + 0.1);
            return valor;
        }

        public string Extrato()
        {
            return ("");
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Conta()
        {
        }
        #endregion

        #endregion
    }

    #endregion

    #region CLASSES_DIFERENTES_PARA_TIPOS_CONTAS_DIFERENTES

    public class ContaCorrente
    {
        #region Attributes

        public int num;
        public Cliente titular;
        public double saldo;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public ContaCorrente()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public bool Deposito(double valor)
        {
            saldo += valor;
            return true;
        }
        /// <summary>
        /// Levantamento é diferente dependendo do tipo de conta
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public double Levantamento(double valor)
        {
            saldo -= valor;
            return valor;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~ContaCorrente()
        {
        }
        #endregion

        #endregion
    }
    public class ContaPoupanca
    {
        #region Attributes

        public int num;
        public Cliente titular;
        public double saldo;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public ContaPoupanca()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public bool Deposito(double valor)
        {
            saldo += valor;
            return true;
        }

        public double Levantamento(double valor)
        {
            saldo -= (valor + 0.1);
            return valor;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~ContaPoupanca()
        {
        }
        #endregion

        #endregion
    }

    #endregion

    #endregion

    #region COM_HERANÇA
    /// <summary>
    /// Classe gere uma conta bancária geral
    /// </summary>
    public class ContaBancaria
    {
        #region Attributes

        private static string numInterno;   //número de conta interno
        int num;
        Cliente titular;
        public double saldo;

        #endregion

        #region Methods

        #region Constructors


        static ContaBancaria()
        {
            numInterno = "PT500000";
        }
        /// <summary>
        /// The default Constructor.
        /// </summary>
        /// 

        public ContaBancaria()
        {
            numInterno += "_";
        }

        public ContaBancaria(int num)
        {
            //Console.WriteLine("CRIOU UMA CONTA");
            numInterno += num.ToString();
        }

        public ContaBancaria(int num, double saldo, string t): this(num)
        {
            titular.nome = t;
            this.saldo = saldo;
            this.num = num;
            numInterno += num.ToString();
        }

        #endregion

        #region Properties

        protected int Num
        {
            get => num;
            set => num = value;
        }

        public string Titular
        {
            get { return titular.nome; }
            set => titular.nome = value;
        }

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public bool Deposito(double valor)
        {
            saldo += valor;
            return true;
        }

        /// <summary>
        /// Admite reescrita em classes filho
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public virtual double Levantamento(double valor)
        {
            saldo -= valor;
            return valor;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~ContaBancaria()
        {
        }
        #endregion

        #endregion
    }

   
    /// <summary>
    /// Classe gere uma conta bancária de poupança
    /// </summary>
    class ContaBancariaPoupanca : ContaBancaria
    {
        DateTime data;          //data da criação da conta

        #region Construtores

        public ContaBancariaPoupanca(string nome, int num): this(nome,num,0, DateTime.Now)
        {

        }
        public ContaBancariaPoupanca(string nome, int num, double saldo) : this(nome,num,saldo,DateTime.Now)
        {
            //data = DateTime.Today;
            //this.Titular = nome;
            //this.saldo = saldo;
            //this.Num = num;
        }

        public ContaBancariaPoupanca(string nome, int num, double saldo, DateTime d) : base(num,saldo,nome)
        {
            data = d;
        }

        
        #endregion

        #region Metodos

        /// <summary>
        /// Reescrita de método da classe Pai
        /// Neste tipo de conta é cobrada uma comissão em cada levantamento
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public override double Levantamento(double valor)
        {
            this.saldo -= (valor + 0.1);
            return valor;
        }

        #endregion
    }

    class X
    {
        ContaBancaria y;

        public X()
        {
            y.Titular = "ola";
        }
    }
    #endregion


    public abstract class QuaseConta
    {
        public abstract double Consulta(DateTime dia);
        public double JuroAnual (double saldo, double perc)
        {
            return saldo * perc;
        }
    }
}
