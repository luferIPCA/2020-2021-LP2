/*
*	<copyright file="Aula2.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>3/2/2021 12:20:29 PM</date>
*	<description>
*	return
*	parametros valor versus referência: out, ref
*	
*	</description>
**/
using System;

namespace Aula2
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 3/2/2021 12:20:29 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Funcoes
    {
        #region METODOS

        /// <summary>
        /// Calcula a SOma de dois valors inteiros
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns></returns>
        
        public static int Soma(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="r"></param>
        public static void Soma(int x, int y, ref int r)
        {
            r=x + y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="r"></param>
        public static void SomaII(int x, int y, out int r)
        {
            r = x + y;
        }

        /*
        int SomaMultiplica(int x, int y, int *r)
        {
            *r=x*y;
            return (x+y);
        }

        typedef struct A{
            int s;
            int p;
        }A;

        A SomaMultiplica(int x, int y)
        {
            A aux;
            aux.s=x+y;
            aux.p=x*y;
            return aux;

        }
        */

        /// <summary>
        /// Calcula a diferença de dois valors inteiros
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns></returns>
        public static int Sub(int x, int y)
        {
            return x - y;
        }

        #endregion
    }
}
