/*
 * lufer
 * LP2
 * Herança de Classes
 * Classes Abstratas
 * Interfaces
 * */
using System;

namespace Aula11_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Y a = new Y();
            Z1 a = new Z1();
            a.Prod(2, 3);
            a.Maior(2, 3);

            Z2 b = new Z2();

            Console.WriteLine("a R: " + Auxiliar.DoSomething(a).ToString());
            Console.WriteLine("b R: " + Auxiliar.DoSomething(b).ToString()); 

        }
    }
}
