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
            Console.WriteLine("Input your age");
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
            int windspeed;
            Console.WriteLine("Input your current windspeed category:)");
            int.TryParse(Console.ReadLine(), out windspeed);
            
            switch (windspeed)
            {
                case 1:
                    Console.WriteLine("Category 1: 74-95 mph or 64-82 kt or 119-153 km/hr");
                    break;
                case 2:
                    Console.WriteLine("Category 2: 96-110 mph or 83-95 kt or 154-177 km/hr");
                    break;
                case 3:
                    Console.WriteLine("Category 3: 111-130 mph or 96-113 kt or 178-209 km/hr");
                    break;
                case 4:
                    Console.WriteLine("Category 4: 131-155 mph or 114-135 kt or 210-249 km/hr");
                    break;
                case 5:
                    Console.WriteLine("Category 5: greater than 155 mph or 135 kt or 249 km/hr");
                    break;
                default:
                    Console.WriteLine("Invalid Category");
                    break;
         
                    
            }

            Random generator = new Random();
            Console.WriteLine("Random Number: " + generator.Next(2, 7));
            Console.WriteLine("Input a number bigger than the random number");
            
            
            
            
            
            
            
            
            
            
            
            
            
            Console.ReadLine();

        }
    }
}
