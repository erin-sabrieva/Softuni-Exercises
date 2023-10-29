using System;
using System.Linq;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine().ToLower();

            Symbols(password);
        }
        
        static void Symbols(string password)
        {
            int count = 0;
            int result = 0;
            int resul2 = 0;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            else
            {
                result++;
            }

            foreach (char word in password)
            {
              resul2 = 0;
                if ("1234567890".Contains(word) || "abcdefghijklmnopqrstuvwxyz".Contains(word))
                {
                    
                    if (char.IsDigit(word))
                    { 
                        count++;
                    }
                    resul2++;
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;
                }
                
            }
            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            else
            {
                result++;
            }
            if (result+resul2==3)
            {
                Console.WriteLine("Password is valid");
            }
        }
        
        
    }
}
