/*
*	<copyright file="AnonymousMethods.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/10/2021 7:49:23 PM</date>
*	<description>
*	Adaptado de:
*	https://www.tutorialspoint.com/csharp/csharp_anonymous_methods.htm
*	</description>
**/
using System;

namespace _LINQ
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/10/2021 7:49:23 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class TestDelegate
    {
        static int num = 10;

        int x;

        public int X
        {
            //get { return x; }
            get => x;
            //set { x = value; }
            set => x = value;
        }

        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named Method: {0}", num);
        }
        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("Named Method: {0}", num);
        }
        public static int getNum()
        {
            return num;
        }
    }

    }
