/*
 * IPCA-EST-LP2
 * Lidar com Generics Classes
 * Generic Classes : type-safe classes
 * 
 * Consultar http://msdn.microsoft.com/en-us/library/ms379564%28v=vs.80%29.aspx
 * lufer
 * */

using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CLASSENORMAL

            MyClass m = new MyClass();

            m[0] = int.Parse("12");
            m[1] = int.Parse("13");

            m.Swap(0, 1);

            Console.WriteLine( m[0].ToString());
            Console.WriteLine( m[1].ToString());

            #endregion

            #region CLASSENORMAL_REFS
            //MyClass m = new MyClass();
            int[] valores = new int[2];

            m[0] = int.Parse("12");
            m[1] = int.Parse("13");
            valores[0] = m[0];
            valores[1] = m[1];

            m.Swap(ref valores[0], ref valores[1]);

            Console.WriteLine(valores[0].ToString());
            Console.WriteLine(valores[1].ToString());
            #endregion

            #region CLASSEGENERIC
           
            //Classe de inteiros
            MyGenericArray<int> m1 = new MyGenericArray<int>();

            

            //uso de Indexadores
            m1[0] = 12;
            m1[1] = 13;

            //Troca valores das posições
            m1.Swap<int>(0, 1);

            Console.WriteLine(m1[0].ToString());
            Console.WriteLine(m1[1].ToString());

            //Classe de strings
            MyGenericArray<string> m2 = new MyGenericArray<string>();

            m2[0] = "12";
            m2[1] = "13";

            m2.Swap<string>(0, 1);

            Console.WriteLine(m2[0]);
            Console.WriteLine(m2[1]);
            #endregion

            Console.ReadKey();
        }
    }
}
