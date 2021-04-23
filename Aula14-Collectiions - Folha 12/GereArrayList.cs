/*
*	<copyright file="_2017_04_07___Aula_9___Collections.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>4/16/2021 11:09:05 AM</date>
*	<description></description>
**/

using System.Collections;

namespace MyCollections
{
    /// <summary>
    /// Purpose: Gere qualquer ArrayList de Pessoas
    /// Created by: lufer
    /// Created on: 4/16/2021 11:09:05 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class GereArrayList
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public GereArrayList()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public static bool Existe(ArrayList x, string nome)
        {

            foreach (object obj in x)
            {
                if (obj is Pessoa)
                {
                    Pessoa aux = (Pessoa)obj;
                    if (aux.nome == nome)
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Pessoa? - Nullable value ...pode devolver null
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static Pessoa Find(ArrayList x, string n)
        {
            foreach (object obj in x)
            {
                if (obj is Pessoa)
                {
                    Pessoa aux = (Pessoa)obj;
                    if (aux.nome == n)
                        return aux;
                }
            }
            return null;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~GereArrayList()
        {
        }
        #endregion

        #endregion
    }
}
