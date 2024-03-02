using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Create a Validator class to handle validation of all console input
//It could have methods like GetYN (gets Y/y or N/n) 


namespace RoshamboLab
{
    public static class Validator
    {
        public static string GetYN()
        {
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "y" || input == "yes" || input == "n" || input == "no")
                    return input;
                Console.WriteLine("Invalid input. Please enter y or n.");
          
            }
        }
    }
}

