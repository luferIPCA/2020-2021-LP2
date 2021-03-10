/*
*	<copyright file="Aula1.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>2/26/2021 9:45:58 AM</date>
*	<description>
*	Revisão de Conceitos de C como base para C#
*	CLS
*	</description>
**/
using System;

struct X
{
    public int a;

}

namespace Aula1
{
    /// <summary>
    /// Resumo do que a função faz...
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <see cref=""/>
    public class Programa
    {
        //int x=2;          //variavel paera....
        float z;        //ATENÇÃO: esta variavel...

        #region UM
        static int Main()
        {
            #region TD
            int a=2;
            float b=2.3F;
            char c='a';
            string d="ola";
            bool e=true;
            double f=2.4;

            //int valores[10]={1,2,3};

            int[] valores = { 12, 34, 5, 6 };
            int[] val = new int[10];            //gestão de memória...
            char[] nome = new char[20];         //char nome[20];

            #endregion

            #region ESTRUTURAS DE CONTROLO

            if (a > 0)
            {
                e = true;
            }
            else
            {
                e = false;
            }
            //?:
             e = (a > 0) ? true : false;

            switch (a)
            {
                case 1: 
                case 2: e = false;break;
                default: e = !e; break;
            }

            //for
            for(int j = 0; j < 10; j++)
            {
                a++;
            }

            int i = 0;
            for(; ; i++ )
            {
                if (i >= 10) break;
                if (i % 2 == 0) continue;
                    a++;
            }

            //while
            while (i < 10)
            {
                a++;
                i++;
            }

            //do..while
            do
            {
                if (a != 0) { 
                a = a / 2 * a;
                 }

                a++;
                i++;
            } while (i <= 10);

            //foreach

            #endregion


            //int x = Soma(2, 3);
            X x = Soma(2, 3);
            Console.WriteLine(x.a);

            Soma(2, 3, ref x.a);
            Console.WriteLine(x.a);

            return 1;

        }


        #region METODOS
        /// <summary>
        /// Método para calcualr......
        /// </summary>
        /// <returns></returns>
        static int main()
        {

            return 1;

        }

        //#pragma region UM
        //#pragma endregion

        /// <summary>
        /// Calcula a soma
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns>Res</returns>
        static X Soma(int x, int y)
        {
            X aux;
            aux.a = x + y;
            return aux;
        }

        /// <summary>
        /// Parametro variável ou referência
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="r"></param>
        static void Soma(int x, int y, ref int r)
        {
            r = x + y;
        }

        /// <summary>
        /// Parametro de saída "out"
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="r"></param>
        static void Soma2(int x, int y, out int r)
        {
            r = x + y;
        }
        #endregion


        #endregion
    }
}
