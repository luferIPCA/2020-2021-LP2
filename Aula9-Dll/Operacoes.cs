/*
 * lufer
 * LP2
 * Dynamic Link Library (DLL)
 * Class Math
 * ildasm nome.dll  //Intermediate Language Disassembler
 * */
using System;

namespace Calculos
{
    /// <summary>
    /// Operações sobre valores numéricos
    /// </summary>
    public class Operacoes
    {
        /// <summary>
        /// Calcula a Soma de dois valores inteiros
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns>Soma de ambos</returns>
        public static int Soma(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Calcula a raiz quadrada de um valor numérico
        /// </summary>
        /// <param name="x">Valor a calcular</param>
        /// <returns>Raiz quadrada</returns>
        public static double MySqrt(double x)
        {
            return OutraRaiz(x);
            
        }

        private static double OutraRaiz(double x)
        {
            return Math.Sqrt(x);
        }

        /// <summary>
        /// Método apenas disponível numa herança desta classe
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        protected static int Abs(int x)
        {
            return Math.Abs(x);
        }

        /// <summary>
        /// Método apensa usado dentro da biblioteca
        /// </summary>
        /// <param name="b"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        internal static double Potencia(double b, double e)
        {
            return Math.Pow(b, e);
        }
    }


    /// <summary>
    /// Outro conjunto de operações
    /// </summary>
    public class Outras
    {

        public static void Mostra(string s)
        {
            Console.WriteLine(s);
            Operacoes.Potencia(2, 3);
        }
    }
}
