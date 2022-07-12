using System;

namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PasswordValidator(password);
        }


        static void PasswordValidator(string input)
        {           
            if (LengthChecker(input) == true && ContentChecker(input) == true && DigitCountChecker(input) == true)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (LengthChecker(input) == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (ContentChecker(input) == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (DigitCountChecker(input) == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
        static bool LengthChecker(string input)
        {
            bool result = false;
            if (input.Length >= 6 && input.Length <= 10)
            {
                result = true;
            }
            return result;
        }
        static bool ContentChecker(string input)
        {
            bool result = false;
            char[] password = input.ToCharArray();
            int validCharsCounter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                bool isValid = (password[i] >= 65 && password[i] <= 90) || (password[i] >= 97 && password[i] <= 122) || (password[i] >= 48 && password[i] <= 57);
                if (isValid)
                {
                    validCharsCounter++;
                }
            }

            if (validCharsCounter == input.Length)
            {
                result = true;
            }
            return result;
        }
        static bool DigitCountChecker(string input)
        {
            bool result = false;
            char[] password = input.ToCharArray();
            int digitCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    digitCounter++;
                }
            }
            if (digitCounter >= 2)
            {
                result = true;
            }
            return result;
        }
    }
}
