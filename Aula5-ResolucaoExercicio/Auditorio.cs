/*
 * Paula Rodrigues nº21133
 * Ficha de trabalho nº5
 * LP2
 * 09/03/2021
 */
using System;

namespace Aula4_Fichaex1
{
    /// <summary>
    /// implementação de uma auditorios do IPCA
    /// </summary>
    class Auditorio
    {
        /// <summary>
        /// array de registo
        /// </summary>
        public struct Pessoa
        {
            public string nome;
            public string ncartCidadao;
            public DateTime hEntr;
            public DateTime hSaida;
        }

        #region Metodos do array multidimencional 

        /// <summary>
        /// Metodo para inicializar o array
        /// </summary>
        /// <param name="auditorio"></param>
        public static void InicializarArrays(Pessoa [,] auditorio)
        {
            for (int i = 0; i < auditorio.GetLength(0); i++)
            {
                for (int j = 0; j < auditorio.GetLength(1); j++)
                {
                    auditorio[i, j].ncartCidadao = "-1";
                }
            }
        }

        
        /// <summary>
        /// Método que permite uma determinada pessoa assistir e sentar-se num lugar determinado, registando a hora em que entra na sessão.
        /// </summary>
        /// <param name="registo">registo dos dados de uma pessoa</param>
        /// <param name="auditorio">arrays multidimensional</param>
        /// <param name="fila">valor usado nas linhas</param>
        /// <param name="lugar">valor usado nas colunas</param>
        /// <returns></returns>
        public static bool RegistarPessoas(Pessoa registo, Pessoa [,] auditorio, int fila, int lugar)
        {
            if(VerificarPessoa(registo, auditorio) == true)
            {
                return false;
            }
            //atenção à validação de fila e lugar
            auditorio[fila, lugar] = registo;
            return true;

        }


        /// <summary>
        /// Método que verifica se uma determinada pessoa se encontra na sala
        /// </summary>
        /// <param name="registo"></param>
        /// <param name="auditorio"></param>
        /// <returns></returns>
        public static bool VerificarPessoa(Pessoa registo, Pessoa[,] auditorio)
        {
            //verificar se a pessoa está dentro do cinema
            for (int i = 0; i<auditorio.GetLength(0); i++)
            {
                for(int j=0; j<auditorio.GetLength(1); j++)
                {
                    if(auditorio[i,j].ncartCidadao == registo.ncartCidadao)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Metodo para saber quantas pessoas assistiram ao evento
        /// </summary>
        /// <param name="auditorio"></param>
        /// <returns></returns>
        public static int PessoasPres(Pessoa[,] auditorio)
        {
            int nPessoas = 0;

            for (int i = 0; i < auditorio.GetLength(0); i++)
            {
                for (int j = 0; j < auditorio.GetLength(1); j++)
                {
                    if(auditorio[i, j].ncartCidadao != "-1")
                    {
                        nPessoas++;
                    }
                }
            }

            return nPessoas;
        }

        #endregion


        #region Metodos do array jagged


        /// <summary>
        /// Metodo para inicializar o array
        /// </summary>
        /// <param name="auditorio"></param>
        public static void InicializarArrays(Pessoa[][] auditorio)
        {
            for (int i = 0; i < auditorio.Length; i++)
            {
                for (int j = 0; j < auditorio[i].Length; j++)
                {
                    auditorio[i][j].ncartCidadao = "-1";
                }
            }
        }


        /// <summary>
        /// Método que permite uma determinada pessoa assistir e sentar-se num lugar determinado, registando a hora em que entra na sessão.
        /// </summary>
        /// <param name="registo">registo dos dados de uma pessoa</param>
        /// <param name="auditorio">arrays multidimensional</param>
        /// <param name="fila">valor usado nas linhas</param>
        /// <param name="lugar">valor usado nas colunas</param>
        /// <returns></returns>
        public static bool RegistarPessoas(Pessoa registo, Pessoa[][] auditorio2, int fila, int lugar)
        {
            //if (VerificarPessoa2(registo, auditorio2) == true)
            //{
            //    return false;
            //}

            if (VerificarPessoa2(registo.ncartCidadao, auditorio2) == true)
            {
                return false;
            }
            //atenção à validação de fila e lugar
            auditorio2[fila][lugar] = registo;
            return true;

        }


        /// <summary>
        /// Método que verifica se uma determinada pessoa se encontra na sala
        /// este metodo recebe um campo do registo de uma pessoa, recebe só o numero de cartao de cidadao
        /// </summary>
        /// <param name="registo"></param>
        /// <param name="auditorio"></param>
        /// <returns></returns>
        public static bool VerificarPessoa2(string ncc, Pessoa[][] auditorio2)
        {
            //verificar se a pessoa está dentro do cinema
            for (int i = 0; i < auditorio2.Length; i++)
            {
                for (int j = 0; j < auditorio2[i].Length; j++)
                {
                    if (auditorio2[i][j].ncartCidadao == ncc)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        // o verificarPessoa2 a seguir versão que recebe todos os dados de registo de uma pessoa
        /// <summary>
        /// Método que verifica se uma determinada pessoa se encontra na sala
        /// </summary>
        /// <param name="registo"></param>
        /// <param name="auditorio"></param>
        /// <returns></returns>
        public static bool VerificarPessoa2(Pessoa registo, Pessoa[][] auditorio2)
        {
            //verificar se a pessoa está dentro do cinema
            for (int i = 0; i < auditorio2.Length; i++)
            {
                for (int j = 0; j < auditorio2[i].Length; j++)
                {
                    if (auditorio2[i][j].ncartCidadao == registo.ncartCidadao)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Metodo para saber quantas pessoas assistiram ao evento
        /// </summary>
        /// <param name="auditorio"></param>
        /// <returns></returns>
        public static int PessoasPres(Pessoa[][] auditorio)
        {
            int nPessoas = 0;

            for (int i = 0; i < auditorio.Length; i++)
            {
                for (int j = 0; j < auditorio[i].Length; j++)
                {
                    if (auditorio[i][j].ncartCidadao != "-1")
                    {
                        nPessoas++;
                    }
                }
            }

            return nPessoas;
        }

        #endregion

    }
}
