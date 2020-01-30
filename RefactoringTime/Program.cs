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

            bool userContinue = true;

            while (userContinue)
            {


                Console.WriteLine("Do you want to find the  hometown or favorite food?");
                string response = Console.ReadLine().ToLower();

                if (response == "hometown")
                {

                    //print the hometown[nameIndxex] which is the corresponding value we are looking for!!!
                    //PrintNames(Hometown[nameIndex])
                    Console.WriteLine(Hometown[nameIndex]);
                }

                if (response == "favorite food")
                {
                    Console.WriteLine(FavoriteFood[nameIndex]);
                }



                //need to figure out how to get the program to loop.  Also need to figure out why it will only let me type FavoriteFood and Hometown like this to return output
                //Also need to be able to have the user select a number corresponding to the name



                //Ask first if the user would like to find out information
                //about a student or add another student
                string nextStep = GetUserInput($"Would you like to find out more information about this student or add another student? (y/n)");
                
                if (nextStep == "n")
                {
                    userContinue = false;
                }

            }
        }

        public static string GetUserInput(string message)
        {

            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static void PrintNames(List<string> Names)
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
