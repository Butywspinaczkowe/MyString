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

        public char this[int i]
        {
            get => CharArray[i];
            set => CharArray[i] = value;
        }


        public int Length
        {
            get { return LengthGetter(); }
        }

        public MyString()
        {
            CharArray = new char[0];
        }

        public MyString(char[] inputArray)
        {
            CharArray = inputArray;
        }

        public MyString(char character)
        {
            CharArray = new char[1];
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

        public static MyString operator + (MyString MyStringA, MyString MyStringB)
        {
            char[] temp = new char[MyStringA.Length + MyStringB.Length];
            MyString concatMyString = new MyString(temp);

            Array.Copy(MyStringA.CharArray, concatMyString.CharArray, MyStringA.Length);
            Array.Copy(MyStringB.CharArray, 0, concatMyString.CharArray, MyStringA.Length, MyStringB.Length);

            return concatMyString;
        }

       /* public static void ToLower()
        {
            MyString.CharArray
        }*/
    }
}
