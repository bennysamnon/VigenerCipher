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

            for (int index = 0; index< _plain.Length; index++)
            {
                char plainChar = char.ToUpper(_plain[index]);
                char keyChar = char.ToUpper(_key[index % _key.Length]);

                sbEncrypted.Append(square[plainChar - 'A', keyChar - 'A']);
            }

            return sbEncrypted.ToString();
        }
    }
}
