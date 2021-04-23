/*
*	<copyright file="SortedLists.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>4/23/2021 11:20:04 AM</date>
*	<description>
*	Exemplo retirado de:
*	https://docs.microsoft.com/en-us/dotnet/api/system.collections.sortedlist.-ctor?view=netframework-3.0&f1url=%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(System.Collections.SortedList.%2523ctor);k(TargetFrameworkMoniker-.NETFramework,Version%253Dv3.0);k(DevLang-csharp)%26rd%3Dtrue
*	</description>
**/
using System;
using System.Collections;
using System.Globalization;

namespace Collections
{
    /// <summary>
    /// Purpose:Demonstrar SortedList
    /// Created by: lufer
    /// Created on: 4/23/2021 11:20:04 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class SamplesSortedList
    {
        public static void Main1()
        {
            #region SortedList

            // Create a SortedList using the default comparer.
            SortedList mySL1 = new SortedList();
            Console.WriteLine("mySL1 (default):");
            mySL1.Add("FIRST", "Hello");
            mySL1.Add("SECOND", "World");
            mySL1.Add("THIRD", "!");
            try
            {
                mySL1.Add("first", "Ola!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            PrintKeysAndValues(mySL1);

            // Create a SortedList using the specified case-insensitive comparer.
            SortedList mySL2 = new SortedList(new CaseInsensitiveComparer());
            Console.WriteLine("mySL2 (case-insensitive comparer):");
            mySL2.Add("FIRST", "Hello");
            mySL2.Add("SECOND", "World");
            mySL2.Add("THIRD", "!");
            try
            {
                mySL2.Add("first", "Ola!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            PrintKeysAndValues(mySL2);

            // Create a SortedList using the specified CaseInsensitiveComparer,
            // which is based on the Turkish culture (tr-TR), where "I" is not
            // the uppercase version of "i".
            CultureInfo myCul = new CultureInfo("tr-TR");
            SortedList mySL3 = new SortedList(new CaseInsensitiveComparer(myCul));
            Console.WriteLine(
                "mySL3 (case-insensitive comparer, Turkish culture):");

            mySL3.Add("FIRST", "Hello");
            mySL3.Add("SECOND", "World");
            mySL3.Add("THIRD", "!");
            try
            {
                mySL3.Add("first", "Ola!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            PrintKeysAndValues(mySL3);

            // Create a SortedList using the
            // StringComparer.InvariantCultureIgnoreCase value.
            SortedList mySL4 = new SortedList(
                StringComparer.InvariantCultureIgnoreCase);

            Console.WriteLine("mySL4 (InvariantCultureIgnoreCase):");
            mySL4.Add("FIRST", "Hello");
            mySL4.Add("SECOND", "World");
            mySL4.Add("THIRD", "!");
            try
            {
                mySL4.Add("first", "Ola!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            PrintKeysAndValues(mySL4);

            #endregion
        }

        public static void PrintKeysAndValues(SortedList myList)
        {
            Console.WriteLine("        -KEY-   -VALUE-");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("        {0,-6}: {1}",
                    myList.GetKey(i), myList.GetByIndex(i));
            }
            Console.WriteLine();
        }
    }
}

