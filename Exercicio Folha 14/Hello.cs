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
        ///  Falhas:
        ///  - Apenas escreve no ecrã. E se quisermos escrever num ficheiro?
        ///  - Apenas escreve "Olá MUndo"...e se quisermos escrever outras coisa?
        ///  - E se quisermos a acrescentar mais "features"?
        ///  - ????
        /// </summary>
        static void Main1()
        {
            //1
            //Console.WriteLine("Ola Mundo");
            //2
            IGetMessage mensagem = new ConsoleGetMessage();
            ITextWriter writer = new ConsoleTextWriter();
            

            //auxiliar
            PrepareMessage msg = new PrepareMessage(mensagem, writer);
            msg.Go();

            ITextWriter writer2 = new FileTextWriter();
            PrepareMessage msg2 = new PrepareMessage(mensagem, writer2);
            msg2.Go();

            Console.ReadKey();

        }

        #region ESCREVEMENSAGEM

        //2 - Onde escrever a Mensagem (ver Adapter Pattern)

        public interface ITextWriter
        {
            void WriteText(string obj);
        }
        public class ConsoleTextWriter : ITextWriter
        {
            public void WriteText(string t)
            {
                Console.WriteLine(t.ToString());
            }
        }
        public class FileTextWriter : ITextWriter
        {
            public void WriteText(string t)
            {
                //escrever em ficheiro
            }
        }
        public class PhoneTextWriter : ITextWriter
        {
            public void WriteText(string text)
            {
                //escrever para phone!!!
            }
        }
        public class TrainTextWriter : ITextWriter
        {
            public void WriteText(string text)
            {
                //escreverpor comboio!!!
            }
        }

        #endregion

        #region LERMENSAGEM

        //1 - Que texto escrever

        public interface IGetMessage
        {
            string GetMessage();
        }
        public class ConsoleGetMessage : IGetMessage
        {
            public string GetMessage()
            {
                Console.Write("Que mensagem pretende: ");
                return Console.ReadLine();
            }
        }
        public class FormGetMessage : IGetMessage
        {
            public string GetMessage()
            {
                //ler dados de uma form
                return "";
            }
        }

        #endregion

        #region LER_E_ESCREVERMENSAGEM

        //3 - Juntar features numa unica class

        public class PrepareMessage
        {
            private  IGetMessage message;
            private  ITextWriter writer;

            public PrepareMessage(IGetMessage message, ITextWriter writer)
            {
                if (message == null) 
                    throw new ArgumentNullException("Message collector");
                if (writer == null) 
                    throw new ArgumentNullException("Text writer");
                this.message = message;
                this.writer = writer;
            }

            public void Go()
            {
                string msg = message.GetMessage();
                writer.WriteText(msg);
            }
        }

        #endregion
    }
}
