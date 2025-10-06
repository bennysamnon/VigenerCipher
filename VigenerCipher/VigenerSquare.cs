using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenerCipher
{
    public class VigenerSquare
    {
        private static VigenerSquare _instance = null;
        private static object _padlock = new object();

        public const int SIZE = 26;
        private char[,] _square = new char[SIZE, SIZE];
        private VigenerSquare()
        {
            GenerateSquare();
        }

        public static VigenerSquare GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padlock)
                    {
                        if (_instance == null)
                            _instance = new VigenerSquare();
                    }
                }
                return _instance;
            }
        }

        private void GenerateSquare()
        {
            for (int row = 0; row < SIZE; row++)
            {
                for (int column = 0; column < SIZE; column++)
                {
                    _square[row, column] = (char)('A' + (row + column) % SIZE);
                }
            }
        }

        public char[,] GetSquare
        {
            get { return _square; }
        }
    }
}
