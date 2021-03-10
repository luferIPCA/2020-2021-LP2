/*
*	<copyright file="Program.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>3/5/2021 10:16:00 AM</date>
*	<description>
*	https://www.c-sharpcorner.com/article/working-with-arrays-in-C-Sharp/
*   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/passing-arrays-as-arguments
*   https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
*   https://www.w3schools.com/cs/cs_arrays.asp
*   https://www.pluralsight.com/guides/array-and-utility-methods
*   Analisar class "Array" co C#
*   Manipular com arrays em C#
*      Simples
*      Multidimensional (matriz)
*      jagged array
*	</description>
**/

using System;

namespace Aula_Arrays_05032021
{
    public class Program
    {
        public struct Clube
        {
            public string nome;
            public int numSocios;
        }
        static void Main(string[] args)
        {
            #region Input/Output
            
            //int valor = int.Parse(Console.ReadLine());      //"12" -> 12
            //bool suc = int.TryParse(Console.ReadLine(), out valor);
            //if (suc == false)
            //    Console.WriteLine("Erro");

            //do
            //{
            //    suc = int.TryParse(Console.ReadLine(), out valor);
            //} while (suc != true);

            //DateTime aux = DateTime.Parse(Console.ReadLine());

            //suc = DateTime.TryParse(Console.ReadLine(), out aux);

            

            #endregion

            #region SIMPLES
            //em C: 
            //int valores[N];
            //valores[i]=x;
            //length= sizeof(valores)/sizeof(valores[0])

            //declaração/inicialização
            //int[] valores = new int[40];
            //int[] valores = { 1, 2, 3, 4, 5 };
            int[] valores = new int[] { 1, 2, 3 };
            valores[2] = 27;

            //inicializa o array a -1
            //h1
            //for (int i = 0; i < valores.Length; i++) 
            //    valores[i] = -1;
            //h2
            //Usar função
            Arrays.InicializaArray(valores, -1);

            char[] letras = { 'a', 'b', 'c' };
            string[] clubes = { "Benfica", "Braga", "Vianense" };

            Clube[] clubesPortugueses = new Clube[20];
            clubesPortugueses[0].nome = "Benfica";
            clubesPortugueses[0].numSocios = 60000000;

            //Apresenta array
            //h1
            //for(int i=0;i<clubesPortugueses.Length; i++)
            //{
            //    Console.WriteLine("Nome: {0} - Socios: {1}", clubesPortugueses[i].nome, clubesPortugueses[i].numSocios);
            //}
            //h2
            Frontend.MostraArray(clubesPortugueses);

            Frontend.MostraArray(valores);


            #endregion

            short vv=2;
            Clube xxxx= new Clube();
            Console.WriteLine(vv.GetTypeCode());

            //Console.WriteLine("TypeCode: " + Type.GetTypeCode(xxxx.GetType()) + " Type:" + xxxx.GetType().ToString());

            #region MULTIDIMENSIONAL
            //em  C
            //int matriz[L][C]
            int[,] matriz = new int[3, 2];
            int[,] mat = { 
                    { 2, 3 }, 
                    { 7, -1} 
            };

            string[,] desporto = { { "lufer", "benfica" }, { "Tones", "Porto" } };
            desporto[0, 1] = "ok";

            //Mostrar o array
            //for(int i=0; i<desporto.GetLength(0);i++)           //GetLength(0) indica o tamanho da dimensão 1 == numero de linhas
            //    for (int j=0; j < desporto.GetLength(1); j++)   //GetLength(1) indica o tamanho da dimensão 2 == número de colunas
            //    {
            //        Console.WriteLine(desporto[i, j]);
            //    }
            //ou
            ArraysMulti.MostraArray(desporto);
            //MostraArray(desporto);

            #endregion


            #region JAGGED_ARRAY
            //array de arrays

            int[][] numeros = new int[3][];
            numeros[0] = new int[20];
            numeros[1] = new int[10];
            numeros[2] = new int[] { 1,2,3,4,5,6};

            //mostrar
            for(int i=0; i<numeros.Length; i++)
                for(int j=0; j<numeros[i].Length; j++)
                {
                    Console.WriteLine(numeros[i][j].ToString());
                }
            //ou
            Frontend.MostraArray(numeros);
            #endregion


            #region MET_PAR

            int x=0;

            Console.WriteLine("Valor de X: {0}", x.ToString());

            Frontend.Change(x);
            Console.WriteLine("Valor de X: " +x.ToString() );

            x = Frontend.ChangeII(x);
            Console.WriteLine("Valor de X: " + x.ToString());

            Frontend.ChangeIII(out x);

            Frontend.ChangeIV(ref x);

            bool suc = Frontend.GetOddNumber(Console.ReadLine(), out x);
            if (suc)
            {
                //String.Format()
                Console.WriteLine("Valor par lido: " + x.ToString());
            }

            #endregion
        }
    }

    public class Frontend
    {

        #region INTERACAO

        //out: valor criado no interior do método
        //ref: Valor alterado ou não no interior do método

        public static void Change(int p)
        {
            p++;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int ChangeII(int p)
        {
            return (++p);
        }

        public static void ChangeIII(out int p)
        {
            p = 2;
            //p++;    //p = p+1
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static void ChangeIV(ref int p)
        {
            p++;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static DateTime GetDateAdd(int x, out int y)
        {
            y = x * 2;
            return DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool GetOddNumber(string  a, out int b)
        {
            int x = int.Parse(a);
            if (x%2==0)
            {
                b = x;
                return true;
            }
            b = 0;
            return false;
        }



        /// <summary>
        /// Metodo para apresentar o conteudo de um array de clubes
        /// </summary>
        /// <param name="clubes">Array de clubes</param>
        public static void MostraArray(Program.Clube[] clubes)
        {
            //h1
            //for(int i=0; i<clubes.Length; i++)
            //{
            //    Console.WriteLine("Nome: {0} - Socios: {1}", clubes[i].nome, clubes[i].numSocios);
            //}
            //h2
            //foreach(tipo x in array) { acc1 }
            foreach (Program.Clube c in clubes)
            {
                Console.WriteLine("Nome: {0} - Socios: {1}", c.nome, c.numSocios);
                //Console.WriteLine(c.ToString());
            }
        }

        public static void MostraArray(int[] v)
        {
            foreach (int c in v)
            {
                Console.WriteLine("Valor: {0} ", c.ToString());
            }
        }

        //Generalizar
        public static void MostraArray(Object[] v)
        {

            if (v[0] is int)
            {
                MostraArray(v);
            }

            if (v[0].GetType() == typeof(int))
            {
            }
            else
              if (v[0].GetType() == typeof(Program.Clube))
            {
            }

            //solução com switch
            switch (Type.GetTypeCode(v[0].GetType()))
            {
                case TypeCode.Int32: break;
                case TypeCode.String: break;
                case TypeCode.Boolean: break;
                //...
                default: break;
            }

        }


        public static void MostraArray(string[,] nomes)
        {
            for (int i = 0; i < nomes.GetLength(0); i++)       //GetLength(0) indica o tamanho da dimensão 1 == numero de linhas
                for (int j = 0; j < nomes.GetLength(1); j++)   //GetLength(1) indica o tamanho da dimensão 2 == número de colunas
                {
                    Console.WriteLine(nomes[i, j]);
                }
        }


        public static void MostraArray(int[][] v)
        {
            for (int i = 0; i < v.Length; i++)
                for (int j = 0; j < v[i].Length; j++)
                {
                    Console.WriteLine("Valor v[{0},{1}]={2}", i,j,v[i][j].ToString());
                }
        }
        #endregion

    }
}
