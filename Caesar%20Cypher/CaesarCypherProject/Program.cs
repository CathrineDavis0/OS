using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCypherProject
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press E for encyption or D for decryption ");
            string choice = Console.ReadLine();
            Console.WriteLine("Enter your phrase");
            string userInput = Console.ReadLine();

            Console.WriteLine("Enter a shift value between 1 to 26: ");
            int shiftValue = Int32.Parse(Console.ReadLine());

            CaesarCypher obj = new CaesarCypher(userInput, shiftValue);
            


            Console.WriteLine($"userinput = {userInput}. userkey = {shiftValue}");

            if (choice == "E")
            {
                string encryptedWord = obj.Encrypt();
                Console.WriteLine(encryptedWord);
            }
            else if (choice == "D")
            {
                string decryptedWord = obj.Decrypt();
                Console.WriteLine(decryptedWord);
            }


            Console.ReadLine();
        }
      
    }

}
