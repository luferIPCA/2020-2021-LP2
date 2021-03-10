/*
 * autor: lufer
 * email: lufer@ipca.pt
 * data:
 * versao:
 * descrição: Calculadora simples
 * 
 * */

using System;

namespace Aula2
{
    public class Program
    {


        static void Main(string[] args)
        {
           
            int x, y;
            x = 10;
            y = 23;

            //int
            //12--> "12"

            //int a = int.Parse(Console.ReadLine());
            //int.TryParse()

            Console.WriteLine(" {0} + {1} = {2}",x,y,x+y);

            

            Console.WriteLine(" SOM: {0} + {1} = {2}", x, y, Funcoes.Soma(x, y));
            Console.WriteLine(" SUB: {0} + {1} = {2}", x, y, Funcoes.Sub(x, y));

            Escreve("Fim");

        }


        /// <summary>
        /// Auxiliar de output...
        /// </summary>
        /// <param name="x"></param>
        static void Escreve(string x)
        {
            Console.WriteLine(x);
        }
       

    }



}
