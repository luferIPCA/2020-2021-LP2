/*
*	<copyright file="Hoje19_03_2021.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>3/19/2021 9:10:48 AM</date>
*	<description>Estruturação de Classes</description>
*	     
* Analisar:
*   DateTime
*   String
*   Math
**/
using System;

namespace Aula8_Classes
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 3/19/2021 9:10:48 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Attributes

        private string nome;
        private int idade;
     
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoa()
        {
        }

        #endregion

        #region Properties

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Ouput dos dados interiores
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //return String.Format("Nome: {0}", nome);
            //return $"Nome: {nome}";
            return "Nome: " + nome.ToLower();
        }

        /// <summary>
        /// Comparar objeto local com outro externo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Pessoa p = (Pessoa)obj;     //as , typeof()
            return ((String.Compare(p.nome, this.nome) == 0) && (this.idade==p.idade)); //this.nome == p.nome;
        }

        #endregion

        #region Operadores
        //+,-,*,>,!=,==

        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            return !(p1 == p2);
        }

        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoa()
        {
            //finalizador
        }
        #endregion

        #endregion


    }

    /// <summary>
    /// Classe para gerir várias pessoas
    /// </summary>
    public class Pessoas
    {
        #region ATTR

        const int MAX = 1000;
        private static Pessoa[] pessoas;
        private static int totPessoas;

        #endregion

        #region CONST
        static Pessoas()
        {
            pessoas = new Pessoa[MAX];
            totPessoas = 0;
        }

        #endregion

        #region METODOSCLASSE
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool InserePessoa (Pessoa p)
        {
            //Ver se pessoa já existe
            //Ver se existe espaço para mais uma pessoa
            pessoas[totPessoas++] = p;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool ExistePessoa(Pessoa p)
        {
            foreach (Pessoa p1 in pessoas)
            {
                if (p1 == p) return true;
            }
            return false;
        }

        
        /// <summary>
        /// Encontra a posição onde se encontra determinadaa pessoa
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int OndeEstaPessoa(Pessoa p)
        {
            for(int i=0; i < totPessoas; i++)
            {
                if (pessoas[i] == p) return i;
            }
            return -1;
        }

        /// <summary>
        /// Encontra a posição onde se encontra determinada pessoa a partir do nome
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int OndeEstaPessoa(string n)
        {
            for (int i = 0; i < totPessoas; i++)
            {
                if (pessoas[i].Nome == n) 
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Encontra a ficha de determinada pessoa a partir do seu nome
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static Pessoa QuemE(string n)
        {
            for (int i = 0; i < totPessoas; i++)
            {
                if (pessoas[i].Nome == n) 
                    return pessoas[i];
            }
            return null;
        }

        //Completar
        //InserePessoa()
        //LocalizaPessoa()
        #endregion
    }
}
