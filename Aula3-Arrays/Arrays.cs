/*
 * Metodos para manipular arrays
 * Parâmetros ref e out
 * */

using System;

namespace Aula3_Arrays
{
    class Arrays
    {
        /// <summary>
        /// Verifica se uma valor existe num array
        /// </summary>
        /// <param name="valores">Valores a analisar</param>
        /// <param name="valor">Valor a comparar</param>
        /// <returns></returns>
        public static bool Existe(int[] v, int valor)
        {
            bool existe = false;
            foreach (int a in v)
            {
                if (a == valor)
                {
                    existe = true;
                    break;
                }
            }
            //for(int i=0; i<valores.Length; i++)
            //{
            //    if (valores[i]==valor)...
            //}

            return existe;
        }

        /// <summary>
        /// Incrementa um determinado valor a todos os calores do array
        /// </summary>
        /// <param name="v"></param>
        /// <param name="valorIncrementar"></param>
        public static void Incrementa(int[] v, int valorIncrementar)
        {
            for (int i = 0; i < v.Length; i++)
                v[i] += valorIncrementar;
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static int TamanhoArray(int[] v)
        {
            return v.Length;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="size"></param>
        public static void TamanhoArrayVoidOut(int[] v, out int size)
        {
          size = v.Length;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="size"></param>
        public static void TamanhoArrayVoidRef(int[] v, ref int size)
        {
            size = v.Length;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static DateTime GetSizeAndDate(int[] v, out int size)
        {
            TamanhoArrayVoidOut(v, out size);
            return DateTime.Today;
        }

    }
}
