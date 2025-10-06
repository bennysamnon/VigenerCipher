using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenerCipher
{
    public class VigenerDecryption
    {
        private string _encrypted;
        private string _key;

        private StringBuilder sbDecrypted = new StringBuilder();

        public VigenerDecryption(string encrypted, string key) 
        {
            _encrypted = encrypted;
            _key = key;
        }

        public string Decrypt()
        {
            char[,] square = VigenerSquare.GetInstance.GetSquare;

            for (int index = 0; index< _encrypted.Length; index++)
            {
                char vigenerChar = char.ToUpper(_encrypted[index]);
                char keyChar = char.ToUpper(_key[index % _key.Length]);

                for (int column = 0; column < VigenerSquare.SIZE; column++)
                {
                    char c = VigenerSquare.GetInstance.GetSquare[keyChar - 'A', column];
                    if(c == vigenerChar)
                    {
                        sbDecrypted.Append((char)('A' + column));
                        break;
                    }
                }
            }

            return sbDecrypted.ToString();
        }
    }
}
