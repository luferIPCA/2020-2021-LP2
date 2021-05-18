/*
*  -------------------------------------------------
* <copyright file="Class1.cs" company="IPCA"/>
* <summary>
*	LP2 
* </summary>
* <date></date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc>Delegates</desc>
* -------------------------------------------------
**/
using System;

namespace Delegates
{
    class Delegates
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int AddNumNum(int p, int q)
        {
            return p+q;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int Num
        {
            get { return num; }
        }

        public static int ExecSomething(int x, int y, Exec callback)
        {
            return (callback(x, y));
        }

    }

    /// <summary>
    /// Delegates sobre Classes
    /// </summary>
    public class MethodClass
    {
        public void Method1(string message) { Console.Write("-1-" + message); }
        public void Method2(string message) { Console.Write("-2-" + message); }

        public static void Method3(int[] values, MyDelegate2 d)
        {
            foreach (int v in values) d(v.ToString());
        }

        /// <summary>
        /// Mostra apenas pares
        /// </summary>
        /// <param name="x"></param>
        public static void ShowOdd(string x)
        {
            int aux;
            bool b = int.TryParse(x, out aux);
            if (b==true && aux%2==0) Console.Write(x.ToString() + "-");
        }
    }
}
