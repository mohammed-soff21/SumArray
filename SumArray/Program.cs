namespace SumArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declaring variables
            char cUserChoice = ' ';
            int nArraySize = 0;
            while (true)
            {
                // Welcome message
                WelcomeApp("sum of all integer array elements accepted by the user");
                // To read the size of the array from the user and validate the user input
                if (!IsNumber("the size of the array", out nArraySize))
                    return;
                // declare an array to store the user input
                int[] nValues = new int[nArraySize];
                // fill the array with user input and validate the user input
                if (!ReadArray(nValues))
                    return;
                // To calculate the sum of all elements in the array
                Print($"The sum is: {SumArray(nValues)}");


                // To read user choice to continue in the app again and validate the user input
                if (!IsChar("y to continue in the application else enter n", out cUserChoice))
                    return;
                // Convert the character to lower 
                cUserChoice = Char.ToLower(cUserChoice);
                // To check the user input in the right format (y,n)
                if (!IsInRightFormat(cUserChoice))
                    return;
                // To check if the user want to continue or not
                if (!WantToContinue(cUserChoice))
                    return;
            }

        }


        #region Methods 

        // This region contains the main methods used in the application
        #region main-methods

        // 1) this method to welcome user in the beginning of the application
        static void WelcomeApp(String welcomeMessage)
        {
            Console.Clear();
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine($"  Welcome to {welcomeMessage} Application!");
            Console.WriteLine("  This app is designed to make your life easier.");
            Console.WriteLine("  Let's get started!");
            Console.WriteLine("  Developed by: Mohammed Salem");
            Console.WriteLine("*********************************************************************************");
        }

        // 2) this method to print message in a beatiful form
        static void Print(String message)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine(message);
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        // 3) this method to read and validate character from the user
        static bool IsChar(string field, out char cInput)
        {
            Console.Write($"Please, enter {field}: ");
            if (!char.TryParse(Console.ReadLine(), out cInput))
            {
                Print("Please, enter a valid character");
                return false;
            }
            return true;
        }

        // 4) this method to check that the user entered (y,n) only
        static bool IsInRightFormat(char input)
        {
            if (input == 'y' || input == 'n')
                return true;
            Print("Please, enter (y) to continue in the application again else enter (n)");
            return false;
        }

        // 5) this method to check the user choice if he wants to continue in the app or not
        static bool WantToContinue(char input)
        {
            if (input == 'y')
                return true;
            Print("The program ended : see you soon again");
            return false;
        }

        // 6) this method to read and validate int number from the user
        static bool IsNumber(string field, out int nValue)
        {
            Console.Write($"Please, enter {field}: ");
            if (!int.TryParse(Console.ReadLine(), out nValue))
            {
                Print("Please, enter a valid number");
                return false;
            }
            return true;
        }

        // 7) read int array
        static bool ReadArray(int[] nValues)
        {
            for (int nCounter = 0; nCounter < nValues.Length; nCounter++)
            {
                if (!IsNumber($"element no. {nCounter + 1}", out nValues[nCounter]))
                    return false;
            }
            return true;
        }

        // 8) this method to calculate the sum of all elements in the array
        static long SumArray(int[] elements)
        {
            long nSum = 0;
            for (int nCounter=0;nCounter<=elements.Length-1;nCounter++)
                nSum += elements[nCounter];
            return nSum;
        }
    
        #endregion

        #endregion

    }
}