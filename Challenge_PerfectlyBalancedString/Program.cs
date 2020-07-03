using System;

namespace Challenge_PerfectlyBalancedString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main variables init
            string userInput;
            bool isBalanced;

            //Console Text set up asking for user input
            Console.Write("Submit your text to the balance test:  ");

            //Getting User input
            userInput = Console.ReadLine();

            //Test for seeing the read user input
            //Console.WriteLine(userInput);

            //Test for the user input
            isBalanced = BalanceTest(userInput);

            Console.WriteLine("..");
            Console.WriteLine("Is the text balanced?");
            if (isBalanced)
                Console.WriteLine("The text is perfectly balanced.");
            else
                Console.WriteLine("The text is unbalanced.");

            //Wait for input before closing
            Console.ReadKey();
        }

        private static bool BalanceTest(string userInput)
        {
            //Methode Variables Init
            bool testResult = true;
            int middlePoint = (userInput.Length / 2);
            string[] splittedInput = new string[2];

            //Getting the halves of the userInput
            splittedInput[0] = userInput.Substring(0, middlePoint).ToLower();

            //An "If" so that we escape the middle character if the text length isn't even
            if (userInput.Length % 2 == 0)
                splittedInput[1] = userInput.Substring(middlePoint).ToLower();
            else
                splittedInput[1] = userInput.Substring(middlePoint + 1).ToLower();

            //Test to see the halves in the console
            //Console.WriteLine(splittedInput[0]);
            //Console.WriteLine(splittedInput[1]);

            //loop to compare each character in the halved strings until the middlepoint is reached
            for (int i = 0; i < middlePoint; i++)
            {
                //running the 1st half sequentially and the 2nd half in reverse
                if (splittedInput[0][i] == splittedInput[1][middlePoint - i - 1])
                    continue; //continue comparing in the next loop until finished

                //If the loop doesn't skip to the next test, the result is changed to unbalanced and the loop is broken with no need for further test
                testResult = false;
                break;
            }

            //Simple return
            return testResult;
        }
    }
}
