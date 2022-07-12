using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputUserName = Console.ReadLine();
            string password = string.Empty;
            
            for (int i = inputUserName.Length - 1; i > - 1; i--)
            {
                password += inputUserName[i];
            }

            int attemptCounter = 1;
            string tryPassword;
            while ((tryPassword = Console.ReadLine()) != password)
            {
                if (attemptCounter == 4)
                {
                    Console.WriteLine($"User {inputUserName} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                attemptCounter++;
               
            }

            Console.WriteLine($"User {inputUserName} logged in.");

        }
    }
}
