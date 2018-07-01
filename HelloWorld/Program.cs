using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string userFirstname;
            string age;

            //ask the user their name
            Console.WriteLine("What is your first name?");
            userFirstname = Console.ReadLine();

            //ask the user their age
            Console.WriteLine("How old are you?");
            age = Console.ReadLine();

            string response = "Your name is: " + userFirstname + 
                              " and you are " + age + " years old";
            response = $"Your name is: {userFirstname} and you are {age} years old";
            Console.WriteLine(response);


            //FORMATTING TEST FOR OUTPUT
            //double pricePerOunce = 17.36;
            //var outputString = "The current price is " + pricePerOunce;
            //var outputString = string.Format("The current price is {0}", pricePerOunce);
            //var outputString = string.Format("The current price is {0:C}", pricePerOunce);

            //string itemName = "Widget";
            //var outputString = string.Format("{0,10} {1,10}", itemName, pricePerOunce);
            //Console.WriteLine(String.Format("{0,10} {1,10}", "Item Name", "Price"));

            //Console.WriteLine(outputString);

            //VERBATIM STRINGS AND ESCAPE SEQUENCES
            //string file = "c:\\file\\mine";
            //file = @"c:\file\mine";


        }
    }
}
