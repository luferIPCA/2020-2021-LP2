/*
*	<copyright file="Aula12_HerancaDLL.cs" company="jclab">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>Joao Carlos Pinto</author>
*   <date>4/8/2021 9:25:35 PM</date>
*	<description></description>
**/

using HerancaDLL;

namespace Aula12HerancaDLL
{
    /// <summary>
    /// Purpose: Pessoas esta classe tem como finalidade ...
    /// Created by: Joao Carlos Pinto
    /// Created on: 4/8/2021 9:25:35 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa:IPessoa
    {

        //*** ClassAtributes
        //------------------

        //*** Attributes 
        //--------------
        string nome;
        string userid;
        string password;

        //*** ClassInternals
        //------------------

        /// <summary>
        /// inicializa a classe Pessoas ...
        /// </summary>
        static Pessoa()
        {
            // fazer alguma coisa útil e necessária
        }

        //***** espaço para Constructors...
        //------------------------------

        /// <summary>
        /// inicializa o objeto Pessoas
        /// </summary>
        public Pessoa()
        {
            // acrescentar as restantes operações do constructor desta classe
            // ... fazer alguma coisa útil neste local...
        }


        //***** espaço para Properties...
        //------------------------------
        public string Nome { 
            get => nome; 
            set => nome = value; 
        }
        
        public string UserID { 
            get => GetUserId(); 
            set => userid = value; 
        }

        public string Password
        {
            get => GetPass();
            set => password = value;
        }

        //***** espaço para Métodos...
        //------------------------------
        public string GetPass()
        {
            return password;
        }

        public string GetUserId()
        {
            return userid;
        }

        //***** espaço para Destructor...
        //------------------------------
        /// <summary>
        /// destructor...
        /// </summary>
        ~Pessoa()
        {
            // fazer alguma coisa útil e necessária...
        }

    }

    public class User:IUser
    {
        string un;
        string pw;

        public bool Login(IPessoa p)
        {
            if (p.GetType()==typeof(Pessoa))
            {
                Pessoa aux = p as Pessoa;
                return (aux.Nome == un && aux.GetPass() == pw);
            }
            return false;
        }
    }

}
