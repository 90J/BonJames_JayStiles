using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BondJames
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars
            string fName;
            string lName;

            //get user input
            Console.Write("Please enter a first name: ");
            fName = Console.ReadLine();

            Console.Write("Please enter a last name: ");
            lName = Console.ReadLine();

            //spit out swapped names
            Console.WriteLine(lName + " " + fName);
        }
    }
}
