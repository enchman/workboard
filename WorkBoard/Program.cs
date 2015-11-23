using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WorkBoard
{
    class Program
    {
        //private static Timer atime;
        private static Timer aTimer;

        static void Main(string[] args)
        {
            Initialize();
        }

        static void Initialize()
        {
            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {
                //Timer atime = new Timer(2000);
                //atime.Elapsed += OnTriggerEvent;
                //atime.AutoReset = false;
                //atime.Enabled = true;

            }
            


            Console.ReadKey();
        }

        private static void OnTriggerEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Hello world");
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }

    }
}
