using System;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)

        {
            int index = -1;
            string userContinue = "y";
            bool found = false;
            int[] numbers = { 2, 8, 0, 24, 51 };


            while(userContinue == "y")
            {
                int usersNumber = GetUserInput("Enter a number: ");

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == usersNumber)
                    {
                        index = i;
                        found = true;
                        break;
                                       
                    }
                                    
                }

                if (found == true)
                {
                    Console.WriteLine(usersNumber + " is at position " + index);
                }
                else
                {
                    Console.WriteLine(usersNumber + " could not be found");
                }

                userContinue = Continue("Would you like to try another number? (y/n)").ToLower();

                if (userContinue == "n")
                {
                    Console.WriteLine("Good bye!");
                }
            }

            Console.ReadKey();
        }

        public static int GetUserInput(string message)
        {
            Console.WriteLine(message);
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        public static string Continue(string message)
        {
            Console.WriteLine(message);
            string userContinue = Console.ReadLine();
            return userContinue;
        }
    }
}
