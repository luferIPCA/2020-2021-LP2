/*
*	<copyright file="Hoje.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>4/13/2021 7:33:02 PM</date>
*	<description></description>
**/
using System;

namespace Exceptions
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 4/13/2021 7:33:02 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class AlunoProprinasException : ApplicationException
    {
        public AlunoProprinasException() : base("Aluno não pagou propinas...")
        {
            //acção
        }
        public AlunoProprinasException(string s) :base(s)
        {
            //acção
        }
        public AlunoProprinasException(string s, Exception e) //inner exception
        {
            throw new AlunoProprinasException(e.Message + "-" + s);
        }
    }
}
