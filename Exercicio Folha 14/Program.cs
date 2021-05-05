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
        static void Main(string[] args)
        {
            Console.WriteLine("Ola Mundo");
        }
    }


    /// <summary>
    /// SR Principle
    /// </summary>
    public class Book
    {

        private String name;
        private String author;
        private String text;

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
        #endregion
    }

    class Output
    {
        void printTextToConsole(String s)
        {
            // our code for formatting and printing the text
        }

        void printTextToAnotherMedium(String text)
        {
            // code for writing to any other location..
        }
    }

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

    public class SuperCoolGuitarWithFlames : Guitar
    {
        private String flameColor;

        //constructor, getters + setters
    }


    #region DIP

    public class StandardKeyboard
    {
        //
    }
    public class Monitor
    {
        //
    }
    /// <summary>
    /// DIP
    /// </summary>
    public class Windows98Machine
    {

        private StandardKeyboard keyboard;
        private  Monitor monitor;

        public Windows98Machine()
        {
            monitor = new Monitor();
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
    #endregion
}
