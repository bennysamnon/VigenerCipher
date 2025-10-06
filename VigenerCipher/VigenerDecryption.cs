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
            int keyIndex = 0;
            foreach (char e in _encrypted)
            {
                char vigenerChar = char.ToUpper(e);

                if (vigenerChar == ' ')
                {
                    sbDecrypted.Append(' ');
                    continue;
                }

                char keyChar = char.ToUpper(_key[keyIndex % _key.Length]);

                for (int column = 0; column < VigenerSquare.SIZE; column++)
                {
                    char c = VigenerSquare.GetInstance.GetSquare[keyChar - 'A', column];
                    if (c == vigenerChar)
                    {
                        sbDecrypted.Append((char)('A' + column));
                        break;
                    }
                }

                keyIndex++;
            }

            return sbDecrypted.ToString();
        }
    }
}
