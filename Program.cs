using System;

namespace letsDoStrings
{
    class Program
    {

        static void Main(string[] args)
        {
            string fName = "", lName = "";

            GetFirstName(ref fName);
            
            GetLastName(ref lName);
           
            CreateFullName(fName, lName);

            CalculateNameLength(fName, lName);

            AskRiddle();

            Console.ReadKey();
        }


        static void GetFirstName(ref string firstName)
        {
            Console.WriteLine("Please enter Your First Name:");
            firstName = Console.ReadLine();
        }

        static void GetLastName(ref string lastName)
        {
            Console.WriteLine("Please enter your Last Name:");
            lastName = Console.ReadLine();
        }

        static void CreateFullName(string fName, string lName)
        {
            Console.WriteLine(fName + " " + lName);
        }

        static void CalculateNameLength(string firstName, string lastName )
        {
            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;
            Console.WriteLine("Your first name has {0} chars and your last name has {1} chars", firstNameLength, lastNameLength);
        }

        static void AskRiddle()
        {
            Console.WriteLine("Please answer the riddle below");
            Console.WriteLine("Box without latches, key or a lid, but golden treasure inside is hid.");
            
            string riddleAnswer = Console.ReadLine();
            CheckRiddleAnswer(riddleAnswer);
        }

        static void CheckRiddleAnswer(string riddleAnswer)
        {
            Console.WriteLine((riddleAnswer.ToLower() == "egg") ? "You guessed correct!" : "I will show you the way out!");
        }
    }
}
