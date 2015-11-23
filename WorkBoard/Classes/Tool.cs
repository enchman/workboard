using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WorkBoard
{
    class Tool
    {
        const int CYCLE_TIME = 1000;

        public Function.Type Type { get; set; }

        private Timer lifetime;
        private int numberOfItem = 0;

        public Tool()
        {

        }

        public void Start()
        {
            // Initialize a new work
            if(lifetime == null)
            {
                lifetime = new Timer((int)Type);
                lifetime.Elapsed += GeneratePart;
            }
            // Continue the work
            else if(!lifetime.Enabled)
            {
                lifetime.Start();
            }
        }

        public void Pause()
        {
            // Pause the work process
            if(lifetime != null)
            {
                lifetime.Stop();
            }
        }

        public void Stop()
        {
            // Determinate the work instance
            if(lifetime != null)
            {
                lifetime.Dispose();
                lifetime.Stop();
            }
        }

        

        public int EstimatedTime()
        {
            return 0;
        }

        private void GeneratePart(object source, ElapsedEventArgs e)
        {
            this.numberOfItem++;
        }

    }
}
