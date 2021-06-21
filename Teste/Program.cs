/*
 * Propostas de resolução do teste
 * ESI e ESIN
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Teste
{
   

    #region TESTE ESIN    
    abstract class A
    {
        int x;
        string y;

        public A(int x, string y) {
            this.x = x*int.Parse(y);    //atenção
            this.y = y;
        }
        public A(int x, int y) { 
            this.x = x * y;
            this.y = y.ToString();
        }

        public abstract int Calc(int x, int y);

        /// <summary>
        /// Verifica se dois objetos "A" são iguais. 
        /// Isso acontece quando o atributo "y" de cada objeto é igual.
        /// </summary>
        public override bool Equals(object obj) 
        { //...
          return true; 
        }

    }

    abstract class Essential : A, IB
    {
        string s;

        public Essential(int x, string y) : base(x,x) {
            this.s = y.ToLower();
        }

        public abstract int Oper(int x);

        /// <summary>
        /// Junta todas as strings existentes em "y", após colocar o prefixo "x" em cada uma delas
        /// Exemplo:
        /// PrefixaAll(2,{"Lisboa","Porto"}) == "2Lisboa2Porto"
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public string PrefixaAll(int x, params string[] y) 
        {
            return "";
            //completar!!!
            
        }

        public bool Equal(A x, A y)
        {
            //return x.Equals(y);
            return x==y;        //definir operador == e !=
        }
    }

    interface IB
    {
        /// <summary>
        /// Junta todas as strings existentes em "y", após colocar o prefixo "x" em cada uma delas
        /// Exemplo:
        /// PrefixaAll(2,{"Lisboa","Porto"}) == "2Lisboa2Porto"
        /// </summary>
        string PrefixaAll(int x, params string[] y);

        /// <summary>
        /// Verifica se os dois objetos parametros são iguais
        /// </summary>
        bool Equal(A x, A y);
    }

    #endregion


    #region TESTE ESI

    #region GRUPOII

    public class Aluno
    {
        string nome;
        public string uc;
        public int ano;
        public string epoca;
        public string curso;
        public bool aprovado;

    }

    public class GrupoII
    {
        static Dictionary<char, Aluno> turma;
        //static Dictionary<char, List<Aluno>> turma;
        /// <summary>
        /// devolve todos os alunos que tenham tido aprovação
        /// a uma determinada unidade curricular, num determinado curso e numa determinada época
        /// </summary>
        /// <returns></returns>
        public static List<Aluno> AlunosAprovados(string cur, string uc, string epoca)
        {
            List<Aluno> res = new List<Aluno>();

            foreach( char c in turma.Keys)
            {
                //turma[c] devolve o aluno associado a esse caracter
                if (turma[c].uc == uc && turma[c].curso == cur && turma[c].epoca == epoca && turma[c].aprovado == true)
                    res.Add(turma[c]);
            }
            return res;
        }
    }

    #endregion

    #region GRUPO I
    /// <summary>
    /// Esta classe não era pedida no teste!!!
    /// </summary>
    public class Pessoas
    {
        private static List<Pessoa> populacao;


        #region Files
        /// <summary>
        /// .........
        /// 
        /// </summary>
        /// <param name="fileName">Nome de ficheiro a criar</param>
        /// <returns>Sucesso ou Insucesso</returns>
        public static bool Save(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, populacao);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    populacao = (List<Pessoa>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return false;
        }
        #endregion
    }

    public class Pessoa : QuasePessoa, IDados
    {
        double nc;
        DateTime dn;

        public Pessoa() { }

        public DateTime DN
        {
            get => dn;
            set => dn = value;
        }

        public double NC
        {
            get => nc;
            set => NC = value;
        }

        public long DiaDaSemana()
        {
            return (long)dn.DayOfWeek; 
        }

        public override string Morada()
        {
            return base.morada;
        }

        public long GetDiasVida()
        {
            return base.GetDiasVida(dn);
        }

        //Operador ==
        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            if ((p1.NC == p2.NC) && p1.DN.Month==p2.DN.Month)
                return true;
            return false;
        }

        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            return (!(p1 == p2));
        }

        public override bool Equals(object obj)
        {
            //Verificar se obj é do tipo Pessoa!!!!
            Pessoa p = (Pessoa)obj;
            return (this == p);
            //ou
            //if ((this.NC == p.NC) && this.DN.Month == p.DN.Month)
            //    return true;


        }


    }

    public abstract class QuasePessoa
    {
        protected string morada;

        /// <summary>
        /// Devolve a morada da pessia
        /// </summary>
        /// <returns></returns>
        public abstract string Morada();

        /// <summary>
        /// Devolve o número de dias que decorreram desde o nascimento
        /// </summary>
        /// <param name="dn"></param>
        /// <returns></returns>
        protected long GetDiasVida(DateTime dn)
        {
            return (DateTime.Now - dn).Days;
        }
    }

    public interface IDados
    {
        /// <summary>
        /// Devolve o dia da semana em que nasceu
        /// </summary>
        /// <returns></returns>
        long DiaDaSemana();

        /// <summary>
        /// Devolve o NC da pessoa
        /// </summary>
        double NC { get; }

        long GetDiasVida();
    }

    #endregion

    #endregion


    public class Program
    {
        
        void Main()
        {
            Pessoa p = new Pessoa();
            p.NC = 123456789;
            p.DN = new DateTime(2021, 12, 12);
            long dia=p.DiaDaSemana();
            Console.WriteLine("Nasceu no dia {0}\n",dia);
            Console.WriteLine("Vive há {0} dias\n",p.GetDiasVida());

            Pessoa p1 = new Pessoa();

            bool x = (p1 == p);     //testar o "=="

            x = p1.Equals(p);       //testar o "Equals"

            bool suc = Pessoas.Save("Pessoas.bin");

            suc = Pessoas.Load("Pessoas.bin");


            List<Aluno> aux = GrupoII.AlunosAprovados("ESI", "LP2", "1ºSEMESTRE");

        }
        
        
    }
}
