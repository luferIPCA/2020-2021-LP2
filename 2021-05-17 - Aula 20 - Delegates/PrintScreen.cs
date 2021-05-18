/*
*  -------------------------------------------------
* <copyright file="PrintScreen.cs" company="IPCA"/>
* <summary>
*	LP2
* </summary>
* <date></date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc></desc>
* -------------------------------------------------
**/
using System;
using System.IO;

namespace Delegates
{
    class Print
    {
        static FileStream fs;
        static StreamWriter sw;

        /// <summary>
        /// Escreve texto na Consola
        /// </summary>
        /// <param name="str"></param>
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("Texto: {0}", str);
        }

        /// <summary>
        /// Escreve texto em ficheiro
        /// </summary>
        /// <param name="s"></param>
        public static void WriteToFile(string s)
        {
            fs = new FileStream(@"c:\temp\message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        /// <summary>
        /// Callback
        /// Recebe delegate como parâmetro e usa-o para invocar o metodo
        /// Metodo SendString não sabe o que PrintString executa!!!
        /// PrintString é um método Callback
        /// Asynchronous Callback
        /// </summary>
        /// <param name="ps"></param>
        public static void SendString(PrintString ps)
        {
            ps("Benfia é o maior");
        }

        public static void SendString(PrintString ps, string s)
        {
            ps(s);
        }


    }
}
