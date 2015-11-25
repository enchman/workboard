using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard2
{
    class Makeup
    {

        public DefaultMakeup Type;
        public Dictionary<Requirement, int> WorkLines = new Dictionary<Requirement, int> { };
        
        /// <summary>
        /// Default Makeup
        /// </summary>
        public enum DefaultMakeup { Customized, Normal, Bread, Toast, Press}

        public enum Requirement { Punching = 4, Welding = 10, Bending = 6, LaserCutter = 10, Milling = 10, Shears = 6, Assembling = 10 }

        public Makeup()
        {

        }

        /// <summary>
        /// Initiate Makeup by using default setup
        /// </summary>
        /// <param name="choice">DefaultMakeup enum</param>
        public Makeup(DefaultMakeup choice)
        {
            this.SetDefault(choice);
        }

        /// <summary>
        /// Initiate Customized Makeup (Dynamic)
        /// </summary>
        /// <param name="instructions">List of Requirements</param>
        public Makeup(List<Requirement> instructions)
        {
            foreach(Requirement item in instructions)
            {
                if(WorkLines.ContainsKey(item))
                {
                    WorkLines[item] += 1;
                }
                else
                {
                    WorkLines.Add(item, 1);
                }
            }
        }

        /// <summary>
        /// Initiate Customized Makeup
        /// </summary>
        /// <param name="instructions">Dictionary List of Requirements</param>
        public Makeup(Dictionary<Requirement, int> instructions)
        {
            this.WorkLines = instructions;
        }

        private void SetDefault(DefaultMakeup choice)
        {
            if(choice != DefaultMakeup.Customized)
            {
                if(choice == DefaultMakeup.Normal)
                {
                    this.WorkLines.Add(Requirement.LaserCutter, 1);
                    this.WorkLines.Add(Requirement.Bending, 1);
                    this.WorkLines.Add(Requirement.Assembling, 1);
                }
                else if(choice == DefaultMakeup.Bread)
                {
                    this.WorkLines.Add(Requirement.Milling, 1);
                    this.WorkLines.Add(Requirement.LaserCutter, 1);
                    this.WorkLines.Add(Requirement.Bending, 1);
                    this.WorkLines.Add(Requirement.Assembling, 1);
                }
                else if (choice == DefaultMakeup.Toast)
                {
                    this.WorkLines.Add(Requirement.Milling, 1);
                    this.WorkLines.Add(Requirement.Punching, 1);
                    this.WorkLines.Add(Requirement.LaserCutter, 1);
                    this.WorkLines.Add(Requirement.Shears, 1);
                    this.WorkLines.Add(Requirement.Bending, 1);
                    this.WorkLines.Add(Requirement.Assembling, 1);
                }
                else if (choice == DefaultMakeup.Press)
                {
                    this.WorkLines.Add(Requirement.Milling, 1);
                    this.WorkLines.Add(Requirement.Bending, 1);
                    this.WorkLines.Add(Requirement.Assembling, 1);
                }
            }
        }
    }
}
