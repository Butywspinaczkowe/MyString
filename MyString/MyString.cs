using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CP
{
    public class MyString
    {
        private char[] charArray;
        private int length;

        public char[] CharArray { get; set; }

        public int Length
        {
            get { return LengthGetter(); }
        }

        public MyString()
        { }

        public MyString(char[] inputArray)
        {
            CharArray = inputArray;
        }

        public MyString(char character)
        {
            CharArray[0] = character;
        }

        private int LengthGetter()
        {
            int arrayLength = 0;
            foreach (char element in CharArray)
            {
                arrayLength++;
            }
            return arrayLength;
        }

        public void Write()
        {
            Console.Write(CharArray);
        }

    }
}
