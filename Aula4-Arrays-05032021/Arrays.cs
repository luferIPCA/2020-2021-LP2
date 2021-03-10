/*
*	<copyright file="Aula_Arrays_05032021.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>3/5/2021 10:16:00 AM</date>
*	<description></description>
**/
using System;

namespace Aula_Arrays_05032021
{
    
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 3/5/2021 10:16:00 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Arrays
    {
        #region SIMPLES
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Arrays()
        {
        }

        #endregion

        #region Properties
        #endregion



        /// <summary>
        /// Inicializa Array
        /// </summary>
        /// <param name="v"></param>
        /// <param name="valor"></param>
        public static void InicializaArray(int[] v, int valor)
        {
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = valor;
            }

            //analisar se é possível
            //foreach (int x in v)
            //{
            //    x = valor;
            //}
        }


        /// <summary>
        /// Método para devolver um array
        /// Cria novo array a partir do original com operação sobre todos os valores originai
        /// </summary>
        /// <param name="v">Valores inciais</param>
        /// <param name="valor">Valor para operação de alterar</param>
        /// <returns></returns>
        public static int[] MultiplicaTodosArray(int[]v, int valor)
        {
            int[] aux = new int[v.Length];
            for (int i = 0; i < v.Length; i++)
                aux[i] = v[i] * valor;
            return aux;
        }

        //Métodos
        //Existe
        //Ordenar
        //Quantos
        //EmQUePosicao
        #endregion

        #endregion
    }
}
