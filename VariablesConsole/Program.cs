using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesConsole
{
    internal class Program
    {
        public static bool True { get; private set; }

        static void Main(string[] args)
        {
            string myName = "Ihab";
            int myProject = 2;
            double myPoints = 9.98d;
         

            Console.WriteLine($" Hello, My name is {myName},");
            Console.WriteLine( $" Here is my project number {myProject}, my average points are {myPoints}.");

          }
    }
}
