/*
*	<copyright file="GereBanco.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>4/6/2021 8:02:59 PM</date>
*	<description></description>
**/
using System;

namespace GereBanco
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 4/6/2021 8:02:59 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public abstract class DadosContaBancaria
    {
        protected string iban;
        double juro;
        protected void Juro(double juro)
        {
            this.juro = juro;
        }

        public double JuroMinimo()
        { 
            return (0.04);
        }

      public abstract string IBAN();
    }
}
