/*
*	<copyright file="Person.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>4/12/2021 3:25:21 PM</date>
*	<description>
*	- nullable values
*	    int? a
*	    - a variável "a" pode ter uma valor inteiro ou "null"
*	    
*	- ??= (C#>=8)
*	    - O operador ??= não executa o lado direito da expressão caso o lado
*	    esquerdo seja diferente de nulo.
*	    
*	</description>
**/
using System;
using System.Collections.Generic;

namespace Extra
{
    enum ESTADO { VIVO, MORTO};

    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 4/12/2021 3:25:21 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class Person
    {
        string nome;
        int idade;
        bool? flag = null;  //nullable type - admite o valor true, false e null
        ESTADO estado;
        List<int> codPropriedades;

        public Person()
        {
            //c#>8.0
            //codPropriedades ??= new List<int>();


        }

        public string Nome
        {
            get { return $"{nome}".Trim(); }
            set { if (value.Length > 0) nome = value; }
        }

        //public int Idade
        //{
        //    get ;
        //    set ;
        //}

        public int Idade
        {
            get => idade;
            set => idade = value;
        }

        public Person(string n) => nome = n;
        public Person(int i) => idade = i;
        public Person(string n, int i)
        {
            nome = n; idade = i;
        }


        public override string ToString()
        {
            string vivo = "";
            if (flag.HasValue)          //testar nullable value
            {
                vivo = "- Vivo: " + ((flag == true) ? "Sim" : "Não");
            }
            return $"Nome: {this.nome} - Idade: {this.idade} {vivo}";
        }
    }
}
