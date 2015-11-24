using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Workboard2
{
    //class Joblist
    //{
    //    public List<Machine> Machines = new List<Machine> { };
    //    //public List<Employee> Workers = new List<Employee> { };
    //    public List<bool> CheckList = new List<bool> { };

    //    public enum Progress { Stop, Start, Done }
    //    public Progress Type;
        
    //    private int totalWorks
    //    {
    //        get
    //        {
    //            return Machines.Count;
    //        }
    //    }
    //    private int cycleTime
    //    {
    //        get
    //        {
    //            return (int)currentWork.Function;
    //        }
    //    }
    //    private int workAt
    //    {
    //        get
    //        {
    //            return totalWorks > atWork ? atWork : totalWorks - 1;
    //        }
    //        set
    //        {
    //            if(totalWorks > value)
    //            {
    //                atWork = value;
    //            }
    //        }
    //    }

    //    private Machine currentWork;
    //    private Timer working;
    //    private DateTime startTime;
    //    private DateTime endTime;
    //    private int atWork = 0;

    //    public Joblist()
    //    {

    //    }

    //    public void AddMachine(Machine tool)
    //    {
            
    //    }

    //    public void Start()
    //    {
    //        if (working == null)
    //        {
    //            // Initiate Current Work
    //            currentWork = Machines.ElementAt(workAt);
    //            // Initiate Type set on Start
    //            Type = Progress.Start;
    //            // Initiate Status to Working
    //            currentWork.Status = Machine.Progress.Working;

    //            // Initiate Work Status
    //            working = new Timer(cycleTime);
    //            working.Elapsed += WorkCycle;
    //            working.AutoReset = false;

    //            // Initiate Work Status
    //            working.Start();
    //        }
    //    }

    //    private void WorkCycle(object source, ElapsedEventArgs e)
    //    {
    //        // Move to next
    //        workAt++;

    //        // Set Current work to 
    //        currentWork.Status = Machine.Progress.Done;

    //    }

    //}

    class Joblist
    {

    }
}
