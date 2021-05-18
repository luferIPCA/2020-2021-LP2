/*
 * <copyright file="Programa.cs" company="PlaceholderCompany">
 * Copyright (c) PlaceholderCompany. All rights reserved.
 * </copyright>
 * <author>lufer</author>
 * <date>2/26/2021 9:45:58 AM</date>
 * <description>
 * Revisão de Conceitos de C como base para C#
 * CLS
 * </description>
*
 */

namespace Aula1
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Faz qualquer coisa.
    /// </summary>
    internal struct X
    {
        //private readonly int a;
        int a;

        /// <summary>
        /// Gets: Faz qualquer coisa.
        /// </summary>
        public int A
        {
            get { return this.a; }
            set { a = value; }
        }

    }
    /// <summary>
    /// Resumo do que a função faz...
    /// </summary>
    /// <remarks>Ok</remarks>
    /// <see cref=""/>
    public class Programa
    {
        // int x=2;          // variavel paera....
        float z;            // ATENÇÃO: esta variavel...

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


            
            // int valores[10]={1,2,3};

            int[] valores = { 12, 34, 5, 6 };
            int[] val = new int[10];            // gestão de memória...
            char[] nome = new char[20];         // char nome[20];

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
            // ?:
             e = (a > 0) ? true : false;

            switch (a)
            {
                case 1: 
                case 2: e = false;break;
                default: e = !e; break;
            }

            // for
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

            // while
            while (i < 10)
            {
                a++;
                i++;
            }

            // do..while
            do
            {
                if (a != 0) { 
                a = a / 2 * a;
                 }

                a++;
                i++;
            } while (i <= 10);

            // foreach

            #endregion


            // int x = Soma(2, 3);
            X x = Soma(2, 3);
            Console.WriteLine(x.A);

            //------
            //João Carlos - "variant"=="dynamic"
            Type tip = Type.GetType(x.GetType().ToString());
            dynamic uretilenNesne = Activator.CreateInstance(tip);
            uretilenNesne.A = 12;

            PropertyInfo pinfo = tip.GetProperty("A");
            object o = pinfo.GetValue(uretilenNesne, null);
            //----------------
            


            Soma(2, 3, ref a);
            Console.WriteLine(x.A);

            return 1;

        }

        static int MAIN()
        {
            return 0;
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

        // #pragma region UM
        // #pragma endregion

        /// <summary>
        /// Calcula a soma
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns>Res</returns>
        static X Soma(int x, int y)
        {
            X aux = new X();
            aux.A = x + y;
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
