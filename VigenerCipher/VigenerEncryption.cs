using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenerCipher
{
    public class VigenerEncryption
    {
        private string _plain;
        private string _key;

        private StringBuilder sbEncrypted = new StringBuilder();

        public VigenerEncryption(string plain, string key)
        {
            _plain = plain;
            _key = key;
        }

        public string Encrypt()
        {
            char[,] square = VigenerSquare.GetInstance.GetSquare;
            int keyIndex = 0;
            foreach (char c in _plain)
            {
                if (c != ' ')
                {
                    char plainChar = char.ToUpper(c);
                    char keyChar = char.ToUpper(_key[keyIndex % _key.Length]);

                    sbEncrypted.Append(square[plainChar - 'A', keyChar - 'A']);

                    keyIndex++;
                }
                else
                {

                    sbEncrypted.Append(' ');
                }
            }

            return sbEncrypted.ToString();
        }
    }
}
