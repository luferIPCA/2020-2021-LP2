/*
 * by lufer
 * Array
 * ArrayList
 * Etc.
 * Ordenar MyCollections
 *  1º Criar Classe X:IComparer
 *  2º Criar método Compare com return (1,-1 ou 0)
 *  3º Usar: arrayList.Sort(new X()) ou
 *  4º Usar: arrayList.Sort(new X(ENUMERADO))
 *  
 * URL: 
 * http://www.java2s.com/Tutorial/CSharp/CatalogCSharp.htm
 * http://www.tutorialsteacher.com/csharp/csharp-queue
 * */
using System;

using System.Collections;

namespace MyCollections
{

    /// <summary>
    /// Demonstrar ArrayList
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region MySortedList
            MySortedListPessoas ms = new MySortedListPessoas(6);
            ms.InsertElement(new Pessoa("Pedro", 12));
            ms.InsertElement(new Pessoa("Joana", 15));
            ms.InsertElement(new Pessoa("Joana1", 18));

            ms.UpdateElement(new Pessoa("Joana1", 27));

            SortedList aux = (SortedList)ms.SelectElements(typeof(Pessoa));

            #endregion

        }

      
    }
}