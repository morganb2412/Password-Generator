using System;

namespace ConsolePasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Password Generator: ");

            int passwordLength = GetPasswordLength();

            string generatedPassword = GenerateRandPassword(passwordLength);

            Console.WriteLine($"Generated Password: {generatedPassword}");
        }

        static int GetPasswordLength()
        {
            int length;
            while (true)
            {
                Console.Write("Enter the length of the password: ");
                if (int.TryParse(Console.ReadLine(), out length) && length > 0)
                {
                    return length;
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive number for the length.");
                }
            }
        }

        static string GenerateRandPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^";
            Random random = new Random();
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }

            return new string(password);
        }
    }
}
