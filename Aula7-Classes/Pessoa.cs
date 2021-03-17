/*
*	<copyright file="Hoje.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>3/16/2021 6:49:14 PM</date>
*	<description></description>
**/
using System;

namespace Classes
{

    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 3/16/2021 6:49:14 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Attributes

        static int totObjects = 0;      //atributo de classe

        private string nome;
        private int idade;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// Construtor de Classe
        /// </summary>
        static Pessoa()
        {
            totObjects = 0;
        }

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoa()
        {
            nome = "";
            idade = -1;
            totObjects++;
        }

        public Pessoa(string n)
        {
            nome = n;
            idade = -1;
            totObjects++;
        }

        public Pessoa(string n, int i)
        {
            nome = n;
            idade = i;
            totObjects++;
        }

        /// <summary>
        /// COnstroi Pessoa
        /// </summary>
        /// <param name="idade">Idade da Pessoa</param>
        /// <param name="nome">Nome da Pessoa</param>
        public Pessoa(int idade, string nome)
        {
            this.idade = idade;
            this.nome = nome;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade de classe
        /// </summary>
        public static int TotalPessoas
        {
            get { return totObjects; }
        }

        /// <summary>
        /// Propriedade de instância
        /// </summary>
        public int TotPessoas
        {
            get => totObjects;
        }

        //H1 - A la JAVA
        public string GetNome()
        {
            return nome.ToUpper();
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        //public string Nome
        //{
        //    get;set;
        //}

        //H2
        public string Nome
        {
            get { return nome.Trim().ToLower(); }
            set { if (value.Length > 0) nome = value; }
        }

        //lambda expressions
        public int Idade
        {
            get => idade;
            set => idade = value;
        }

        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoa()
        {
            totObjects--;
        }
        #endregion

        #endregion
    }

    /*
     * Conta Bancaria
     *  numConta
     *  Saldo
     *  
     *  Depositar
     *  Levantar
     *  Saldo?
     * */
}
