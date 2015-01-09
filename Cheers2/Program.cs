using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World");

            // Step 1: Geting user's name & print it.
            System.Console.WriteLine("what is your name?");
            string name = System.Console.ReadLine();

            System.Console.WriteLine("Welcome, " + name);
            //Step 2: Cheer the user on.

           // char[] letters = letters.ToCharArray();
            string upperName = name.ToUpper();
             //if name is "Bob", output should be:


                //Give me a.. B
                //Give me an..O
                //Give me a.. B
                //BOB is.. GRAND!
                foreach (char letter in name.ToLower())
                {
                    string article = "a";
                    if("halfnorsemix".IndexOf(letter) >= 0){
                        article = "an";
                    }
                    System.Console.WriteLine("Give me " + article + ".. " + letter);
                    
                   
                }

                     System.Console.WriteLine(upperName + " is.. GRAND!"); 
               
                     System.Console.WriteLine("Enter your birthdate (MM/DD):");

                DateTime birthdate = DateTime.Parse(Console.ReadLine());
                // cool! Your birthday is in 28 days!
                // or "Aw, damn, just missed it. Your birthday was 30 days ago

                System.Console.WriteLine("Press any key to exit");
                System.Console.ReadKey();
        }
    }
}
