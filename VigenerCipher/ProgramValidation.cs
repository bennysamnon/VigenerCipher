using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenerCipher
{
    static class ProgramHelper
    {
        public enum Menu
        {
            Encrypt = 1,
            Decrypt = 2,
            Exit = 3,
            Other
        }
        public static void PrintMenu()
        {
            Console.WriteLine("1. Encrypt");
            Console.WriteLine("2. Decrypt");
            Console.WriteLine("3. Exit");
            Console.Write("Select Menu: ");
        }
        public static Menu MenuInputValidation(string menu)
        {
            if (menu == "1" || menu == "2" || menu == "3")
                return Enum.Parse<Menu>(menu);
            else
                return Menu.Exit;
        }

        public static void PrintEnterText(Menu menu)
        {
            if(menu == Menu.Encrypt)
                Console.WriteLine("Enter text to encrypt:");
            else if (menu == Menu.Decrypt)
                Console.WriteLine("Enter text to decrypt:");
            else
                Console.WriteLine("Enter text:");
        }

        public static bool IsAllAlphabetic(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }

        public static void PrintKeyText(Menu menu)
        {
            if (menu == Menu.Encrypt)
                Console.WriteLine("Enter key to encrypt:");
            else if (menu == Menu.Decrypt)
                Console.WriteLine("Enter key to decrypt:");
            else
                Console.WriteLine("Enter key:");
        }
         
    }
}
