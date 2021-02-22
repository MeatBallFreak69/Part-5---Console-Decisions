using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5___Console_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            int intAge;
            string strInput;
            Console.WriteLine("State your age");
            strInput = Console.ReadLine();
            int.TryParse(strInput, out intAge);
            if (intAge >= 18 ) {
                Console.WriteLine("adult");
            }
            else if(intAge <= 5 & intAge > 0) {
                Console.WriteLine("Toddler");
            }
            else if(intAge <= 10 & intAge > 5) {
                Console.WriteLine("Child");
            }
            else if(intAge <= 12 & intAge > 10) {
                Console.WriteLine("PreTeen");
            }
            else if(intAge < 12 & intAge > 18) {
                Console.WriteLine("Teen");
            }
            else if(intAge <= 0) {
                Console.WriteLine("Error: Your age can't be below 0");
            }
            Console.ReadLine();
        }
    }
}
