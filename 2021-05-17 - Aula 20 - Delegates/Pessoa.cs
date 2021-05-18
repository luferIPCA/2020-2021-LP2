/*
*  -------------------------------------------------
* <copyright file="Pessoa.cs" company="IPCA"/>
* <summary>
*	LP2 
* </summary>
* <date></date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc></desc>
* -------------------------------------------------
**/
using System;

namespace Delegates
{
    class Pessoa
    {
        string nome;
        DateTime nasci;

        public Pessoa(string n, DateTime nasc)
        {
            nome = n;
            nasci = nasc;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime Nasci
        {
            get { return nasci; }
            set { nasci = value; }
        }

        public int GetIdade()
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (nasci.Year * 100 + nasci.Month) * 100 + nasci.Day;

            return (a - b) / 10000;
        }
    }
}
