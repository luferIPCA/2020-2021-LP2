/*
*	<copyright file="_2015_11_19___Arrays.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>3/4/2021 8:48:18 PM</date>
*	<description></description>
**/
using System;

namespace _2015_11_19___Arrays
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 3/4/2021 8:48:18 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Outra
    {
        int[,] valores = { { 1, 2, 3 },{ 2, 3, 4 } };
        string[] strArray = new string[] {
            "Mahesh Chand",
            "Mike Gold",
            "Raj Beniwal",
            "Praveen Kumar",
            "Dinesh Beniwal"
        };

        int[,] v = new int[3, 2] { { 2, 3 }, { 2, 4 } ,{ 2,6} };

        int[][] v2 = new int[3][];
        static int[][] jagged = new int[3][];
 
       


        public static int ShowArray(int [,] v)
        {
            for(int i=0; i< v.GetLength(0); i++)
                for(int j=0; j < v.GetLength(1); j++)
                {
                    Console.WriteLine(v[i, j]);
                }
            return 1;
        }


        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Outra()
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
        ~Outra()
        {
        }
        #endregion

        #endregion
    }
}
