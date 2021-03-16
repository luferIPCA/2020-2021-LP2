/*
*	<copyright file="Aula_Arrays_05032021.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>3/5/2021 10:52:02 AM</date>
*	<description></description>
**/
using System;

namespace Aula_Arrays_05032021
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 3/5/2021 10:52:02 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ArraysMulti
    {
        #region Attributes
        #endregion

        #region Methods

        /// <summary>
        /// Apresenta o conteúdo de um array
        /// </summary>
        /// <param name="nomes"></param>
        public static void MostraArray(string[,] nomes)
        {
            for (int i = 0; i < nomes.GetLength(0); i++)       //GetLength(0) indica o tamanho da dimensão 1 == numero de linhas
                for (int j = 0; j < nomes.GetLength(1); j++)   //GetLength(1) indica o tamanho da dimensão 2 == número de colunas
                {
                    Console.WriteLine(nomes[i, j]);
                }
        }

        /// <summary>
        /// O que faz este método? 
        /// </summary>
        /// <param name="arr">Array bidimensional a tratar</param>
        static void Transpose(int[,] arr)
        {
            int temp;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i; j < arr.GetLength(1); j++)
                {
                    temp = arr[i, j];
                    arr[i, j] = arr[j, i];
                    arr[j, i] = temp;
                }
            }
        }

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public ArraysMulti()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~ArraysMulti()
        {
        }
        #endregion

        #endregion
    }
}
