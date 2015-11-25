using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workboard2
{
    class Program
    {
        public enum Test { Test1, Test2, Test3 }

        public static Test Block;

        static void Main(string[] args)
        {
            DateTime dateA = new DateTime(2015, 11, 25);
            DateTime dateB = new DateTime(2015, 11, 25);

            int result = DateTime.Compare(dateA, dateB);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }

        static void Initialize()
        {

        }
    }
}
