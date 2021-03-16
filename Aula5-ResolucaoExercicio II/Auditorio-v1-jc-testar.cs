/**
 * @file Auditorio.cs
 * @author João Pinto (a20808@alunos.ipca.pt)
 * @brief 
 * @version 0.2
 * @date 2021-03-09
 * 
 * @copyright Copyright (c) 2021, João Carlos Pinto
 */

using System;

namespace Aula20210309_arrays2
{
    public class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            #region Auditorio

            /// <summary>
            /// Sala com 10 filas de 10 lugares cada
            /// </summary>
            SalaQuadrada sala1 = new SalaQuadrada(10, 10);
            /// <summary>
            /// Sala com 3 filas de 20, 15 e 22 lugares cada fila respetivamente
            /// </summary>
            int[] tamFilas=new int[] { 20, 15, 22 };
            SalaDesigual sala2 = new SalaDesigual(tamFilas);
            Pessoa p = new Pessoa
            {
                nome = "João",
                cc = "123456789"
            };

            Console.WriteLine("[sala quadrada]");

            Console.WriteLine("Pessoa(\"{0}\",\"{1}\") adicionada à sala?: {2}",p.nome,p.cc, Auditorio.ColocaPessoa(1, 1, p, sala1) ? "sim":"não");

            Console.WriteLine("... tentar repetir a introdução da mesma pessoa...");
            Console.WriteLine("Pessoa(\"{0}\",\"{1}\") adicionada à sala?: {2}", p.nome, p.cc, Auditorio.ColocaPessoa(1, 1, p, sala1) ? "sim" : "não");

            int i = Auditorio.QuantasPessoasAssistiram(sala1);
            Console.WriteLine("Total de pessoas que assistiram ao espetéculo: {0}",i.ToString());

            i = Auditorio.QuantosLugaresLivres(sala1);
            Console.WriteLine("Total de lugares livres no espetéculo: {0}", i.ToString());

            Console.WriteLine(" ");
            Console.WriteLine("[sala desigual]");

            Console.WriteLine("Pessoa(\"{0}\",\"{1}\") adicionada à sala?: {2}", p.nome, p.cc, Auditorio.ColocaPessoa(1, 1, p, sala2) ? "sim" : "não");

            Console.WriteLine("... tentar repetir a introdução da mesma pessoa...");
            Console.WriteLine("Pessoa(\"{0}\",\"{1}\") adicionada à sala?: {2}", p.nome, p.cc, Auditorio.ColocaPessoa(1, 1, p, sala2) ? "sim" : "não");

            i = Auditorio.QuantasPessoasAssistiram(sala2);
            Console.WriteLine("Total de pessoas que assistiram ao espetéculo: {0}", i.ToString());

            i = Auditorio.QuantosLugaresLivres(sala2);
            Console.WriteLine("Total de lugares livres no espetéculo: {0}", i.ToString());


            Console.WriteLine(" ");
            Console.WriteLine("... tecla para continuar ...");
            Console.ReadKey();
            #endregion
        }

    }
}
