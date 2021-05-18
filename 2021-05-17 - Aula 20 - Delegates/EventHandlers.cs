/*
*	<copyright file="EventHandlers.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/21/2020 11:57:59 AM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegates
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/21/2020 11:57:59 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
        class Counter
        {
            private int threshold;
            private int total;

            public Counter(int passedThreshold)
            {
                threshold = passedThreshold;
            }

            public void Add(int x)
            {
                total += x;
                Console.WriteLine("Atual Threshold: " + total);
                if (total >= threshold)
                {
                    ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                    args.Threshold = threshold;
                    args.TimeReached = DateTime.Now;
                    OnThresholdReached(args);
                }
            }

            protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
            {
                ThresholdReachedEventHandler handler = ThresholdReached;
                if (handler != null)
                {
                    handler(this, e);
                }
            }

            public event ThresholdReachedEventHandler ThresholdReached;
        }

        public class ThresholdReachedEventArgs : EventArgs
        {
            public int Threshold { get; set; }
            public DateTime TimeReached { get; set; }
        }

        public delegate void ThresholdReachedEventHandler(Object sender, ThresholdReachedEventArgs e);
    }
