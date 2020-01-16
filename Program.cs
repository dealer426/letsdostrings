using System;

namespace letsDoStrings
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter Your First Name:");
            string firstName = Console.ReadLine();
           
            Console.WriteLine("Please enter your Last Name:");
            string lastName = Console.ReadLine();

            FullName(firstName, lastName);

            CalculateNameLength(firstName, lastName);

            AskRiddle();

            Console.ReadKey();
        }

        public  string GetFirstName()
        {
            Console.WriteLine("Please enter Your First Name:");
            string firstName = Console.ReadLine();
            return firstName;
        }

        public string GetLastName()
        {
            Console.WriteLine("Please enter your Last Name:");
            string lastName = Console.ReadLine();

            return lastName;
        }

        static void FullName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + " " + lastName);
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
