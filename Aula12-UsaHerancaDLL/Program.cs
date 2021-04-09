/*
 * Herança, Classes Abstractas, Interfaces definidas em DLL
 * lufer
 * 
 * Ver dotPeek em
 * URL: https://www.jetbrains.com/decompiler/?fromJetBrainsToolbox
 * para analisar conteúdo da DLL
 */

using System;

namespace Aula12_UsaHerancaDLL
{
    class Program
    {
        static void Main(string[] args)
        {

            Quadrado q = new Quadrado();
            q.Lado = 7;
            Console.WriteLine($"Area do {q.Nome}: " + q.GetArea().ToString());


            Triangulo t = new Triangulo();
            t.Base = 2;
            t.Altura = 7;
            Console.WriteLine($"Area do {t.Nome}: " + t.GetArea().ToString());

        }
    }
}
