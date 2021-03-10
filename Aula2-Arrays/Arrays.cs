/*
lufer
Manipular Arrays
Passagem de arrays como parâmetro de uma função
Arrays de structs
*/
using System;

namespace MyArrays
{

    /// <summary>
    /// Métodos para processar Arrays
    /// </summary>
    public class Arrays
    {
        #region METODOS_ARRAYS
        /// <summary>
        /// Verifica de determinado valor existe num array
        /// </summary>
        /// <param name="v"></param>
        /// <param name="vals"></param>
        /// <returns></returns>
        public static bool Existe(int v, int[] vals)
        {

            //for(int i=0; i < vals.Length; i++)
            //{
            //    if (vals[i] == v) return true;
            //}
            //return false;

            foreach (int valor in vals)
            {
                if (valor == v)
                    return true;
                //else              //Errado!!!
                //    return false;
            }
            return false;
        }


        /// <summary>
        /// Verifica quantos valores existem num array que sejam iguais a v
        /// Returns de amount of values in an array that are equal to v
        /// </summary>
        /// <param name="vals"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static int ContaQuantosValores(int[] vals, int v)
        {
            int count = 0;
            foreach (int valor in vals)
            {
                if (valor == v) count++;
            }

            return count;
        }


        /// <summary>
        /// Verifica quantos valores existem numa matriz que sejam iguais a v
        /// Returns de amount of values in a matrix that are equal to v
        /// </summary>
        public static int ContaQuantosValoresMatriz(int[,] vals, int v)
        {
            int count = 0;

            for (int i = 0; i < vals.GetLength(0); i++)
            {
                for (int k = 0; k < vals.GetLength(1); k++)
                {
                    if (v == vals[i, k]) count++;
                }
            }
            return count;
        }



        /// <summary>
        /// Mostra os valores de um Array
        /// </summary>
        /// <param name="vals"></param>
        public static void MostraArray(int[] vals)
        {
            foreach (int i in vals)
            {
                Console.WriteLine("Val: " + i);
            }
        }

        /// <summary>
        /// Multiplica por dois todos os valores de um array
        /// </summary>
        /// <param name="vals"></param>
        public static void DobraArray(int[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                vals[i] *= 2;//vals[i] = vals[i] *2
            }
        }

        /// <summary>
        /// Verifica se determinado valor existe num array
        /// </summary>
        /// <param name="v">Valor a procurar</param>
        /// <param name="val">Array de valores</param>
        /// <returns>Sim/Não</returns>
        public static bool ExisteValorII(int v, int[] val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                if (val[i] == v)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica se determinado valor existe num array
        /// </summary>
        /// <param name="v">Valor a procurar</param>
        /// <param name="val">Array de valores</param>
        /// <returns>Sim/Não</returns>
        public static bool ExisteValor(int v, int[] val)
        {
            bool existe = false;

            for (int i = 0; i < val.Length; i++)
            {
                if (val[i] == v)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        /// <summary>
        /// Verifica quantas vezes determinado valor existe num array
        /// </summary>
        /// <param name="v">Valor a procurar</param>
        /// <param name="val">Array de valores</param>
        /// <returns>Sim/Não</returns
        public static bool Existevalor(int v, int[] vals, out int tot)
        {
            tot = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == v)
                {
                    tot++;
                }
            }
            return (tot > 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="valores"></param>
        /// <returns></returns>
        public static bool ExisteValor(int v, int[,] valores)
        {
            // Completarem!!!
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="valores"></param>
        /// <returns></returns>
        public static bool ExisteValore (int v, int[][] valores)
        {
            // Completarem!!!
            return false;
        }

        #endregion

        #region MAIS

        /// <summary>
        /// Procurar alguma coisa....
        /// </summary>
        /// <param name="v"></param>
        /// <param name="valores"></param>
        /// <returns></returns>
        public static bool ExisteValorArray(int v, int[] valores)
        {
            bool existe = false;
            //h1: com for e break;
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] == v)
                {
                    existe = true;
                    break;
                }
            }
            //return existe;

            //h2: for e sem break
            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] == v)
                {
                   return true;
                }
            }
            return false;

            //h3: com foreach (completam)

        }
        
        /// <summary>
        /// Verifica se existe e devolve a posição
        /// </summary>
        /// <param name="x">Valor a procurar</param>
        /// <param name="v">Array de valores</param>
        /// <param name="p">Posição onde se encontra</param>
        /// <returns></returns>
        public static bool ExisteOnde(int x, int[] v, out int p)
        {
            p = -1;

            for(int i=0; i < v.Length; i++)
            {
                if (v[i] == x)
                {
                    p = i;
                    return true;
                }
            }
            return false; 
        }

        /// <summary>
        /// devolve quais são maiores que x
        /// </summary>
        /// <param name="val"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int[] DescVal(int[] val, int x)
        {
            //p1: total= contar quantos são maiores que x
            //p2: criar novo array do tamanho igual ao total
            //p3: encontrar os maiores e colocar no novo array

            int[] aux;
            int t = val.Length;

            //p1:contar quantos são maiores que x
            int cont = 0;
            for (int i = 0; i < t; i++)
            {
                if (val[i] > x) cont++;

            }
            //p2: criar novo array do tamanho igual ao total
            if (cont > 0) //Só interessa se existem valores maiores
            {
                aux = new int[cont];

                //p3:encontrar os maiores e colocar no novo array
                int j = 0;
                for (int i = 0; i < t; i++)
                {
                    if (val[i] > x)
                    {
                        aux[j] = val[i];
                        j++;
                    }

                }
                return aux;
            }
            return null;
        }

        #endregion

        #region ARRAY_PARAMETROS

        /// <summary>
        /// Somatório de um conjunto de valores inteiros
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int Somatorio(params int[] values)
        {
            int s = 0;
            for (int i = 0; i < values.Length; i++)
                s = s + values[i];
            //ou
            //foreach (int x in values) s += x;
            return s;
        }
        #endregion

        #region ARRAYSTRUCTS

        /// <summary>
        /// Return all information for a particular student
        /// </summary>
        /// <param name="course"></param>
        /// <param name="numberStudent"></param>
        /// <returns></returns>
        public static Student GetStudent(Student[] course, int numberStudent)
        {

            if (course.Length == 0) return new Student(-1,"");//Caso o array não tenha valores!!!

            foreach(Student s in course)
            {
                if (s.number == numberStudent) return s;
            }

            return new Student(-1,"");
        }
        #endregion

    }
}
