/*
*	<copyright file="Exceptions.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>4/13/2021 12:29:03 PM</date>
*	<description></description>
**/
using System;

namespace Exceptions
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 4/13/2021 12:29:03 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class MyException : ApplicationException
    {

        public MyException() : base("Erro na minha Exception")
        {

        }

        public MyException(string s) : base(s)
        {
        }

        public MyException(Exception e)
        {
            throw new MyException(e.Message + " - não percebes nada disto...");
        }

    }
}
