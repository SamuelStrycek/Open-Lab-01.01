using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int x = Int32.Parse(input);
            if (x < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }