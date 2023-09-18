using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._1._5_BooleanOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Be familiar with and be able to use:

            //• NOT
           
            bool found = false;
            if (!found)
            {
                Console.WriteLine("Not Found");
            }
            while (!found)
            {
                Console.WriteLine("Loop while not found");
            }
            do
            {
                Console.WriteLine("Loop while not found");
            } while (!found);

            // AND
            bool Valid = true;
                   
            if (!found && Valid)
            {
                Console.WriteLine("Not found and Valid");
            }
            while (!found && Valid)
            {
                Console.WriteLine("Loop while not found and valid");
            }
            do
            {
                Console.WriteLine("Loop while not found and valid");
            } while (!found && Valid);

            // OR.
            if (found || Valid)
            {
                Console.WriteLine("If found or valid");
            }
            while (found || Valid)
            {
                Console.WriteLine("Loop while found or valid");
            }
            do
            {
                Console.WriteLine("Loop while found or valid");
            } while (found || Valid);
            
            //• XOR.
            if(found ^ Valid)
            {
                Console.WriteLine("Either found or valid is true but not both");
            }
            while(found ^ Valid)
            {
                Console.WriteLine("loop while found or valid is true but not both");
            }
            do
            {
                Console.WriteLine("loop while found or valid is true but not both");
            } while (found ^ Valid);
        }
    }
}
