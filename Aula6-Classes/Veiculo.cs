/*
*	<copyright file="Aula6_Classes.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>3/11/2021 10:56:37 PM</date>
*	<description></description>
**/
using System;

namespace Aula6_Classes
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 3/11/2021 10:56:37 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Veiculo
    {
        static int tot;

        #region Attributes
        public string marca;
        int rodas;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Veiculo()
        {
            tot++;
        }

        #endregion

        #region Properties

        public int Rodas 
        {
            get { return rodas*2; }
            set { rodas = value; }
        }
        public int NumeroRodas()
        {
            return rodas;
        }

        public static int Tot
        {
            get => tot;
        }
        #endregion

        #region Overrides

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Veiculo()
        {
        }
        #endregion

        #endregion
    }
}
