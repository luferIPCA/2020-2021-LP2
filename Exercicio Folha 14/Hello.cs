/*
*	<copyright file="Exercicio_Folha_14.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/5/2021 10:13:37 PM</date>
*	<description></description>
**/
using System;

namespace Exercicio_Folha_14
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/5/2021 10:13:37 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
     class Hello
    {
        /// <summary>
        /// SOLID: 
        /// Falhas:
        ///  - Apenas escreve no ecrã. E se quisermos escrever num ficheiro?
        ///  - Apenas escreve "Olá MUndo"...e se quisermos escrever outras coisa?
        ///  - E se quisermos a acrescentar mais "features"?
        /// </summary>
        static void Main()
        {
            //1
            //Console.WriteLine("Ola Mundo");
            //2
            IMessageCollector mensagem = new ConsoleMessageCollector();
            ITextWriter writer = new ConsoleTextWriter();
            PublicMessage publicMessage = new PublicMessage(mensagem, writer);
            publicMessage.Go();

            Console.ReadKey();

        }

        //1 - Onde escrever a Mensagem (ver Adapter Pattern)
        public interface ITextWriter
        {
            void WriteText(string text);
        }
        public class ConsoleTextWriter : ITextWriter
        {
            public void WriteText(string text)
            {
                Console.WriteLine(text);
            }
        }
        public class FileTextWriter : ITextWriter
        {
            public void WriteText(string text)
            {
                //escrever em ficheiro
            }
        }

        //2 - Que texto escrever

        public interface IMessageCollector
        {
            string CollectMessageFromUser();
        }
        public class ConsoleMessageCollector : IMessageCollector
        {
            public string CollectMessageFromUser()
            {
                Console.Write("Que mensagem pretende: ");
                return Console.ReadLine();
            }
        }

        //3 - Juntar features numa noca class

        public class PublicMessage
        {
            private  IMessageCollector _messageCollector;
            private  ITextWriter _textWriter;

            public PublicMessage(IMessageCollector messageCollector, ITextWriter textWriter)
            {
                if (messageCollector == null) throw new ArgumentNullException("Message collector");
                if (textWriter == null) throw new ArgumentNullException("Text writer");
                _messageCollector = messageCollector;
                _textWriter = textWriter;
            }

            public void Go()
            {
                string message = _messageCollector.CollectMessageFromUser();
                _textWriter.WriteText(message);
            }
        }
    }
}
