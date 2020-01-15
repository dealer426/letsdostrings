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

            Console.WriteLine(firstName + " " + lastName);

            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;
            Console.WriteLine("Your first name has {0} chars and your last name has {1} chars", firstNameLength, lastNameLength);

            Console.WriteLine("Please answer the riddle below");
            Console.WriteLine("Box without latches, key or a lid, but golden treasure inside is hid.");
            string riddleAnswer = Console.ReadLine();

            if(riddleAnswer.ToLower() == "egg")
            {
                Console.WriteLine("You guess correct!");
            }

            else
            {
                Console.WriteLine("I will show you the way out!");  
            }

            Console.ReadKey();
        }
    }
}
