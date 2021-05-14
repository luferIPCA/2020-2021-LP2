/*
 * IPCA-EST-LP2
 * Lidar com Generics Classes
 * Generic Classes : type-safe classes
 * 
 * Consultar http://msdn.microsoft.com/en-us/library/ms379564%28v=vs.80%29.aspx
 * lufer
 * */

using System;

using System.Collections;

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

            //Class Generica

            ReallyGeneric<MyGenericArray<string>> rgc = new ReallyGeneric<MyGenericArray<string>>(m2);

            MyGenericArray<string> xxx = rgc.Aux;


            #endregion

            #region CLASSGENERIC-I
            // Declare a List of type int, then loop through the List
            CustomList<int> list1 = new CustomList<int>();

            for (int x = 0; x < 10; x++)
            {
                list1.Add(x);
            }

            foreach (int i in list1)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine("\nDone\n");

            // Declare a List of type string, then loop through the List
            CustomList<string> list2 = new CustomList<string>();
            list2.Add("Martin");
            list2.Add("Zahn");
            list2.Add("Oberdiessbach");

            foreach (string s in list2)
            {
                System.Console.Write(s + " ");
            }
            System.Console.WriteLine("\nDone\n");

            // Use Indexer on the List
            string s1 = list2[1];

            // Declare a List of type ExampleClass, then loop through the List
            // ExampleClass holds any DataType.
            CustomList<ExampleClass> list3 = new CustomList<ExampleClass>();
            ExampleClass a = new ExampleClass(7);
            list3.Add(a);

            ExampleClass b = new ExampleClass("Hello");
            list3.Add(b);

            foreach (ExampleClass o in list3)
            {
                System.Console.Write(o.objGet.ToString() + " ");
            }
            System.Console.WriteLine("\nDone");

            // Use Indexer on the List
            ExampleClass c = list3[0];
            System.Console.Write("From Indexer: " + c.objGet.ToString() + "\n");
            #endregion


            X aux = new X();
            aux.valores[0] = 12;

            X<int> aux2 = new X<int>();
            aux2.a = 12;
            aux2.valores[0] = aux2.a;


            X<string> aux3 = new X<string>();
            aux3.a = "ola";
            aux3.valores[0] = aux2.a.ToString();


            X<int, string> aux4 = new X<int, string>();
            aux4.a = aux2.a;
            aux4.Valores= aux3.a;
            aux4.Valores = "12";

            X<int, MyClass> aux5 = new X<int, MyClass>();

            X<string, Hashtable> aux6 = new X<string, Hashtable>();



            Console.ReadKey();
        }
    }
}
