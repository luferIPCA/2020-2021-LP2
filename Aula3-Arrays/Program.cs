/*
 * lufer
 * 04-03-2021
 * LP2
 * Data
 * email
 * Desc: Trabalhar com arrays...
 *          Simples
 *          Matrizes
 *          Jagged
 * */

using System;

namespace Aula3_Arrays
{
    class Program
    {
        /// <summary>
        /// struct auxiliar
        /// </summary>
        struct Aluno
        {
            public int numero;
            public string nome;
        }

        static void Main(string[] args)
        {
            #region input/Output

            //int valor = int.Parse(Console.ReadLine());      //"12" -> 12

            //bool aux = int.TryParse(Console.ReadLine(), out valor);
            //if (aux == true) 
            //    Console.WriteLine("Inseriu: " + valor.ToString());

           
            ////H1
            //do
            //{
            //    aux = int.TryParse(Console.ReadLine(), out valor);
            //} while (aux != true);
            //Console.WriteLine("Inseriu: " + valor.ToString());
            ////H2
            ////while (!int.TryParse(Console.ReadLine(), out valor)); 
            //DateTime d1;
            //aux = DateTime.TryParse(Console.ReadLine(), out d1);

            ////aux = float.TryParse()
            ///
            #endregion

            #region ArraySimples

            //int valores[40];
            //int[] valores = new int[40];
            int[] valores = new int[] { 1, 2, 3, 4, 5, 6 };
            valores[2] = valores[1] * 2;

            //array de structs
            Aluno[] turma = new Aluno[20];
            turma[0].numero = 10;
            turma[0].nome = "ola";

            //mostrar alunos da turma
            for(int i=0; i<turma.Length; i++)
            {
                Console.WriteLine("Nome: {0} - Numero: {1}", turma[i].nome, turma[i].numero.ToString());
            }

            //foreach(Tipo x in array) fazer{}
            foreach(Aluno a in turma)
            {
                Console.WriteLine("Nome: {0} - Numero: {1}", a.nome, a.numero.ToString());
            }

            //verificar se existe valor no array
            int x = 20;
            bool existe = false;
            foreach (int a in valores)
            {
                if (a == x)
                {
                    existe = true;
                    break;
                }
            }
            Console.WriteLine(" {0} ", (existe == true ? "Sim" : "Nao"));   //?:
            //ou
            //if (existe == true)
            //{
            //    Console.WriteLine(" {0} ", "Sim");
            //}
            //else
            //{
            //    Console.WriteLine("Não");
            //}

            //verificar se existe valor no array com recurso a método
            Console.WriteLine(" O valor {0} existe? {1}", x, (Arrays.Existe(valores, x)==true) ? "Sim" : "Não");

            InterArrays.MostraArray(valores);

            Arrays.Incrementa(valores, 10);

            InterArrays.MostraArray(valores);


            #region METODOS_PAR

            //out:      apenas retornar valores
            //ref:      permite alterar valore que entra

            Console.WriteLine("Size: " +Arrays.TamanhoArray(valores).ToString());   //usa return
            int auxSize;
            Arrays.TamanhoArrayVoidOut(valores, out auxSize);                       //usa out
            auxSize *= 2;
            Arrays.TamanhoArrayVoidRef(valores, ref auxSize);                       //usa ref

            DateTime dia = Arrays.GetSizeAndDate(valores, out auxSize);

            #endregion

            //Ordenar
            //Inserir
            //Remover

            #endregion

            #region ArrayMultidimensional - MATRIZ
            //int valores[][]
            //int[,] val = new int[3, 5];
            int[,] val = { { 2, 3 }, { 4, 5 }, { 4, -7 } };
            int [,] xx = new int[3, 2] { { 2, 3 }, { 4, 5 }, { 4, -7 } };

            //mostrar o array
            for(int i=0; i<val.GetLength(0);i++)
                for(int j=0; j < val.GetLength(1); j++)
                {
                    Console.WriteLine(val[i,j].ToString());
                }

            InterArrays.MostraArray(val);
            InterArrays.MostraArray(valores);

            #endregion

            #region JAGGED-Array
            int[][] jogo = new int[3][];

            jogo[0] = new int[20];
            jogo[1] = new int[2];
            jogo[2] = new int[] { 1, 2, 3, 4 };

            for(int i=0; i<jogo.Length;i++)
                for(int j=0;j<jogo[i].Length;j++)
                {
                    Console.WriteLine(jogo[i][j]);
                }

            //Rever
            //foreach(int a in jogo[2])
            //{

            //}
            #endregion

        }


    }

    /// <summary>
    /// Interação com Arrays
    /// </summary>
    class InterArrays
    {
        #region INTERACAO
        public static void MostraArray(int[] v)
        {
            foreach (int a in v) Console.WriteLine(a);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static void MostraArray(int[,] val)
        {
            for (int i = 0; i < val.GetLength(0); i++)
            {
                for (int j = 0; j < val.GetLength(1); j++)
                {
                    Console.WriteLine(val[i, j].ToString());
                }
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        public static void MostraArray(int[][] val)
        {
            for (int i = 0; i < val.Length; i++)
                for (int j = 0; j < val[j].Length; j++)
                {
                    Console.WriteLine(val[i][j].ToString());
                }
        }

        #endregion

    }
}
