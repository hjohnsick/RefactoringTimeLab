using System;
using System.Collections.Generic;

namespace RefactoringTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //list for storing student information
            List<string> Names = new List<string>
            { "Heather", "Ben", "Luke", "Dawn", "Ed"};

            List<string> Hometown = new List<string>
            { "St. Clair", "Alpena", "Richmond", "Marysville", "Port Huron"};

            List<string> FavoriteFood = new List<string>
            { "corn on the cob", "cheese Burger", "apple sauce", "tacos", "fish"};
            
            // Welcome message
            Console.WriteLine("Welcome to our C# class!");
            Console.WriteLine("What student would you like to learn more about?");
            //Console.ReadLine();
            PrintNames(Names);

            
            
            int nameIndex = Names.IndexOf(Console.ReadLine());
           

            Console.WriteLine("Do you want to find the  hometown or favorite food?");
            string response = Console.ReadLine();

            if (response == "Hometown") 
            {

                //print the hometown[nameIndxex] which is the corresponding value we are looking for!!!
                //PrintNames(Hometown[nameIndex])
                Console.WriteLine(Hometown[nameIndex]);
            }

            if (response == "FavoriteFood") 
            {
                Console.WriteLine(FavoriteFood[nameIndex]);
            }

           

            //need to figure out how to get the program to loop.  Also need to figure out why it will only let me type FavoriteFood and Hometown like this to return output

            bool userContinue = true;
            while (userContinue)
            {

                //Ask first if the user would like to find out information
                //about a student or add another student
                GetUserInput($"Would you like to find out more information about this student or add another student? (y/n)");
                string nextStep = Console.ReadLine();
                if ( nextStep == "n")
                {
                    break;
                }

            }
        }

        public static string GetUserInput(string message)
        {
            
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static void PrintNames(List<string>Names)
        {
            int j = 1;
            for (int i = 0; i < Names.Count; i++)
            {
                Console.WriteLine($"{j}.{Names[i]}");
                j++;
            }
        }

    }
}
