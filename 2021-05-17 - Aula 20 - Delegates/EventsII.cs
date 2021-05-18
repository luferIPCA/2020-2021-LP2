/*
*  -------------------------------------------------
* <copyright file="EventsII.cs" company="IPCA"/>
* <summary>
*	LP2
* </summary>
* <date></date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc>
*   Delegates and Events
* </desc>
* -------------------------------------------------
**/
using System;
using System.Threading;

namespace Delegates
{

    /* ======================= Event Publisher =============================== */

    // Our subject -- it is this class that other classes
    // will observe. This class publishes one event:
    // SecondChange. The observers subscribe to that event.
    public class Clock
    {
        // Private Fields holding the hour, minute and second
        private int _hour;
        private int _minute;
        private int _second;

        // The delegate named SecondChangeHandler, which will encapsulate
        // any method that takes a clock object and a TimeInfoEventArgs
        // object as the parameter and returns no value. It's the
        // delegate the subscribers must implement.
        public delegate void SecondChangeHandler( object clock, TimeInfoEventArgs timeInformation);

        // The event we publish
        public event SecondChangeHandler SecondChange;

        
        /// <summary>
        /// Gerar evento
        /// </summary>
        /// <param name="clock"></param>
        /// <param name="timeInformation"></param>
        protected void OnSecondChange(object clock, TimeInfoEventArgs timeInformation )
        {
            // Se alguém subscreveu o evento "secondChange"
            if (SecondChange != null)
            {
                // Gera o evento
                SecondChange(clock, timeInformation);
            }
        }

        // Set the clock running, it will raise an event for each new second
        public void Run()
        {
            for (; ; )
            {
                // Espera 1 segundo
                Thread.Sleep(1000);

                // Hora atual
                System.DateTime dt = System.DateTime.Now;

                // If the second has changed notify the subscribers
                if (dt.Second != _second)
                {
                    // Create the TimeInfoEventArgs object
                    // to pass to the subscribers
                    TimeInfoEventArgs timeInformation = new TimeInfoEventArgs(dt.Hour, dt.Minute, dt.Second);

                    // If anyone has subscribed, notify them
                    OnSecondChange(this, timeInformation);
                }

                // update the state
                _second = dt.Second;
                _minute = dt.Minute;
                _hour = dt.Hour;

            }
        }
    }


    // The class to hold the information about the event
    // in this case it will hold only information
    // available in the clock class, but could hold
    // additional state information
    public class TimeInfoEventArgs : EventArgs
    {
        public TimeInfoEventArgs(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public readonly int hour;
        public readonly int minute;
        public readonly int second;
    }

    /* ======================= Event Subscribers =============================== */

    // An observer. DisplayClock subscribes to the
    // clock's events. The job of DisplayClock is
    // to display the current time
    public class DisplayClock
    {
        // Given a clock, subscribe to its SecondChangeHandler event
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChange += new Clock.SecondChangeHandler(TimeHasChanged);
        }

        private void TheClock_SecondChange(object clock, TimeInfoEventArgs timeInformation)
        {
            throw new NotImplementedException();
        }

        // The method that implements the delegated functionality
        public void TimeHasChanged( object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Tempo atual: {0}:{1}:{2}",
               ti.hour.ToString(),
               ti.minute.ToString(),
               ti.second.ToString());
        }
    }

    // A second subscriber whose job is to write to a file
    public class LogClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChange += new Clock.SecondChangeHandler(WriteLogEntry);
        }

        // This method should write to a file
        // we write to the console to see the effect 
        // this object keeps no state
        public void WriteLogEntry( object theClock, TimeInfoEventArgs ti)
        {
            Console.WriteLine("Logging to file: {0}:{1}:{2}",
               ti.hour.ToString(),
               ti.minute.ToString(),
               ti.second.ToString());
        }
    }

}
