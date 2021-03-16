/**
 * @file Auditorio.cs
 * @author João Pinto (a20808@alunos.ipca.pt)
 * @brief 
 * @version 0.2
 * @date 2021-03-09
 * 
 * @copyright Copyright (c) 2021, João Carlos Pinto
 */

namespace Aula20210309_arrays2
{

    /// <summary>
    /// 
    /// </summary>
    class Auditorio
    {
        
        #region Metodos
        /// <summary>
        /// 
        /// </summary>
        /// <param name="linha"></param>
        /// <param name="posicao"></param>
        /// <param name="p"></param>
        /// <param name="aud"></param>
        /// <returns></returns>
        public static bool ColocaPessoa(int linha, int posicao, Pessoa p, SalaQuadrada aud)
        {
            // linhas dentro dos limites
            // posicao dentro dos limites
            // verificar se cada lugar está livre
            // verificar se a pessoa já está na sala
            if (!VerificaPessoaNaSala(p, aud))
            {
                aud.lugares[linha, posicao] = p;
                return true;
            }
            else { return false; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="linha"></param>
        /// <param name="posicao"></param>
        /// <param name="p"></param>
        /// <param name="aud"></param>
        /// <returns></returns>
        public static bool ColocaPessoa(int linha, int posicao, Pessoa p, SalaDesigual aud)
        {
            // linhas dentro dos limites
            // posicao dentro dos limites
            // verificar se cada lugar está livre
            // verificar se a pessoa já está na sala
            if (!VerificaPessoaNaSala(p, aud))
            {
                aud.lugares[linha][posicao] = p;
                return true;
            }
            else { return false; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool VerificaPessoaNaSala(Pessoa p, SalaQuadrada aud)
        {
            bool existe = false;
            for (int i = 0; (i < aud.lugares.GetLength(0)) && !existe; i++)
            {
                for (int j = 0; (j < aud.lugares.GetLength(1)) && !existe; j++)
                {
                    if ((aud.lugares[i, j]!=null) &&(aud.lugares[i, j].cc == p.cc))
                    {
                        existe = true;
                    }
                }
            }
            return existe;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="aud"></param>
        /// <returns></returns>
        public static bool VerificaPessoaNaSala(Pessoa p, SalaDesigual aud)
        {
            bool existe = false;
            for (int i = 0; (i < aud.lugares.GetLength(0)) && !existe; i++)
            {
                for (int j = 0; (j < aud.lugares[i].Length) && !existe; j++)
                {
                    if ((aud.lugares[i][j] != null) && (aud.lugares[i][j].cc == p.cc))
                    {
                        existe = true;
                    }
                }
            }
            return existe;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aud"></param>
        /// <returns></returns>
        public static int QuantasPessoasAssistiram(SalaQuadrada aud)
        {
            int contador = 0;
            for (int i = 0; i < aud.lugares.GetLength(0); i++)
            {
                for (int j = 0; j < aud.lugares.GetLength(1); j++)
                {
                    if (aud.lugares[i, j] != null)
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aud"></param>
        /// <returns></returns>
        public static int QuantasPessoasAssistiram(SalaDesigual aud)
        {
            int contador = 0;
            for (int i = 0; i < aud.lugares.GetLength(0); i++)
            {
                for (int j = 0; j < aud.lugares[i].Length; j++)
                {
                    if (aud.lugares[i][j] != null)
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aud"></param>
        /// <returns></returns>
        public static int QuantosLugaresLivres(SalaQuadrada aud)
        {
            int contador = 0;
            for (int i = 0; i < aud.lugares.GetLength(0); i++)
            {
                for (int j = 0; j < aud.lugares.GetLength(1); j++)
                {
                    if (aud.lugares[i, j] == null)
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aud"></param>
        /// <returns></returns>
        public static int QuantosLugaresLivres(SalaDesigual aud)
        {
            int contador = 0;
            for (int i = 0; i < aud.lugares.GetLength(0); i++)
            {
                for (int j = 0; j < aud.lugares[i].Length; j++)
                {
                    if (aud.lugares[i][j] == null)
                    {
                        contador++;
                    }
                }
            }
            return contador;
        }

        #endregion

    }

    /// <summary>
    /// 
    /// </summary>
    class Pessoa
    {
        public string nome;
        public string cc;
    }

    /// <summary>
    /// 
    /// </summary>
    class SalaQuadrada
    {
        public Pessoa[,] lugares;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="totFilas"></param>
        /// <param name="totLugares"></param>
        public SalaQuadrada(int totFilas, int totLugares)
        {
            lugares = new Pessoa[totFilas, totLugares];
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class SalaDesigual
    {
        public Pessoa[][] lugares;
        /// <summary>
        /// a composição da sala é baseada num jagged array [totLugaresCadaLinha.Length][]
        /// </summary>
        /// <param name="totLugaresCadaLinha">cada item tem a dimensão de cada linha</param>
        public SalaDesigual(int[] totLugaresCadaLinha)
        {
            lugares = new Pessoa[totLugaresCadaLinha.Length][];
            for (int i=0; i<totLugaresCadaLinha.Length; i++)
            {
                lugares[i] = new Pessoa[totLugaresCadaLinha[i]];
            }
        }
    }

}
