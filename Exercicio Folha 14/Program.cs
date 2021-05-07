/*
 * Exercícios da Folha 14
 * SOLID Design Principles
 * Ver: https://www.baeldung.com/solid-principles
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Folha_14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ola Mundo");

            Book b = new Book();
            b.text = "Ola";
            Output o = new Output();
            o.printTextToConsole(b);
            //o.printTextToAnotherMedium(b);
        }
    }

    #region Grupo2

    /// <summary>
    /// SR Principle
    /// </summary>
    public class Book : IText
    {

        private String name;
        private String author;
        public String text;

        //constructor, getters and setters

        #region Methods 
        //methods that directly relate to the book properties
        public String replaceWordInText(String word)
        {
            return text.Replace(word, text);
        }

        public bool isWordInText(String word)
        {
            return text.Contains(word);
        }

        void printTextToConsole()
        {
            // our code for formatting and printing the text
        }


        public string output()
        {
            return text;
        }

        public override string ToString()
        {
            return output();
        }
        #endregion
    }


    interface IText
    {
        string output();
        string ToString();
    }

    class Output
    {
        public void printTextToConsole(IText x)
        {
            // our code for formatting and printing the text
            Console.WriteLine(x.ToString());
        }

        public void printTextToAnotherMedium(String text)
        {
            // code for writing to any other location..
        }
    }

    #endregion


    #region Grupo3

    /// <summary>
    /// OC Princinple
    /// </summary>
    public class Guitar
    {
        private String make;
        private String model;
        private int volume;

        //Constructors, getters & setters
    }

    public class GuitarWithCosts : Guitar
    {
        private double custo;

        //constructor, getters + setters
    }

    #endregion

    #region Grupo4

    public class StandardKeyboard
    {
        //
    }
    public class Monitor
    {
        //
    }
    /// <summary>
    /// Violação de DIP
    /// </summary>
    public class Windows98Machine
    {

        private StandardKeyboard keyboard;
        private  Monitor monitor;

        public Windows98Machine()
        {
            monitor = new Monitor();            //Viola DIP
            keyboard = new StandardKeyboard();
        }
    }

    public interface IKeyboard { }

    public class Windows98MachineDIP
    {

        private  IKeyboard keyboard;
        private  Monitor monitor;

        public Windows98MachineDIP(IKeyboard keyboard, Monitor monitor)
        {
            this.keyboard = keyboard;
            this.monitor = monitor;
        }
    }

    public class StandardKeyboardDIP : IKeyboard
    {
        //
    }

    public class QWERTKeyboard : IKeyboard
    {

    }
    #endregion
}
