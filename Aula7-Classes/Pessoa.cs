using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7_Classes
{
    /// <summary>
    /// Classe para descrever uma pessoa
    /// </summary>
    class Pessoa
    {

        #region Atributos

        static int totPessoas=0;      //atributo de classe        

        string nome;                //atributtos de instancias
        int idade;
        #endregion

        #region Comportamento

        /// <summary>
        /// 
        /// </summary>
        static Pessoa()
        {
            totPessoas = 0;
        }

        #region Construtores
        /// <summary>
        /// Const por omissão!
        /// </summary>
        public Pessoa()
        {
            nome = "";
            idade = -1;

            totPessoas++;
            //
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Nome da Pessoa</param>
        /// <param name="i">Idade da Pessoa</param>
        public Pessoa(string n, int i)
        {
            nome = n;
            idade = i;
            totPessoas++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idade"></param>
        /// <param name="nome"></param>
        public Pessoa(int idade, string nome)
        {
            this.nome = nome;
            this.idade = idade;
            totPessoas++;
        }

        public int TotalPessoas
        {
            get { return totPessoas; }
        }

        public static int TotPessoas
        {
            get { return totPessoas; }
        }

        #endregion


        #region Propriedades

        #region H1 - A la JAVA
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string n)
        {
            nome = n;
        }
        #endregion

        //H2

        public string Nome
        {
            get { return nome.ToLower(); }
            set { if (value.Length>0) nome = value.Trim(); }
        }

        public int Idade
        {
            get { return idade; }
            set { if (idade>0) idade = value; }
        }

        #endregion


        #region Destrutor
        ~Pessoa()
        {
            //ultimas operações antes do objeto ser elimindo da memória...
        }
        #endregion

        #endregion

    }

    /*
    class Banco
        numero de conta
        saldo

        Levanta
        Deposita
    */

}
