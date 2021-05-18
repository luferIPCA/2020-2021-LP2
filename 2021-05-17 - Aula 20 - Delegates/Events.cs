/*
*  -------------------------------------------------
* <copyright file="Events.cs" company="IPCA"/>
* <summary>
*	LP2 
* </summary>
* <date></date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc>
*   Delegates and Events
*   Adaptado de: https://www.akadia.com/services/dotnet_delegates_and_events.html
* </desc>
* -------------------------------------------------
**/
using System;
using System.IO;

namespace Delegates
{
    /* ========= Publisher of the Event ============== */
    public class MyClass
    {
        // Define a delegate named LogHandler, which will encapsulate
        // any method that takes a string as the parameter and returns no value
        public delegate void LogHandler(string message);

        // Define an Event based on the above Delegate
        public event LogHandler Log;

        // Instead of having the Process() function take a delegate
        // as a parameter, we've declared a Log event. Call the Event,
        // using the OnXXXX Method, where XXXX is the name of the Event.
        public void Process()
        {
            OnLog("Process() begin");
            OnLog("Process() end");
        }

        // By Default, create an OnXXXX Method, to call the Event
        protected void OnLog(string message)
        {
            if (Log != null)
            {
                Log(message);
            }
        }

        /// <summary>
        /// Auxiliar
        /// </summary>
        /// <param name="s"></param>
        public static void Logger(string s)
        {
            Console.WriteLine(s);
        }
    }

    // The FileLogger class merely encapsulates the file I/O
    public class FileLogger
    {
        FileStream fileStream;
        StreamWriter streamWriter;

        // Constructor
        public FileLogger(string filename)
        {
            fileStream = new FileStream(filename, FileMode.Create);
            streamWriter = new StreamWriter(fileStream);
        }

        // Member Function which is used in the Delegate
        public void Logger(string s)
        {
            streamWriter.WriteLine(s);
        }

        public void Close()
        {
            streamWriter.Close();
            fileStream.Close();
        }
    }
}
