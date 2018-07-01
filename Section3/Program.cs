using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro to variables
            int number1 = 0;
            char holdsABetter = 'a';
            double amount;
            amount = 2.5;

            //variables of simple types
            int number = 5;
            int sum;
            sum = number + 5;
            bool test = true;
            sum = number + test; //doesn't work

            //ask the user a question
            Console.WriteLine("What is your favorite number?");
            int number2;
            number2 = Convert.ToInt32(Console.ReadLine());


            //formatting using concatenation
            string userFirstName;
            string age;
            Console.WriteLine("What is your first name?");
            userFirstName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = Console.ReadLine();
            string response = "Your name is " + userFirstName + " and you are " + age + " years old";
            Console.WriteLine(response);

            //using string interpolation
            string response2 = $"Your name is: {userFirstName} and you are {age} years old";

            //Formatting text for output
            double pricePerOunce = 17.36;
            string outputString;
            outputString = String.Format("The current price is {0:C}", pricePerOunce);
            Console.WriteLine(outputString);

            string itemName = "Widget";
            string outputString2 = String.Format("{0,10} {1,10}", itemName, pricePerOunce);
            Console.WriteLine(String.Format("{0,10} {1,10}", "Item Name", "Price"));
            Console.WriteLine(outputString2);

            //Verbatim strings and escape sequences
            string file = "C:\\my documents\\homedirectory\\files";
            file = @"C:\my documents\homedirectory\files"; //alternative
            Console.WriteLine(file);
        }
    }
}
