using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    public class RepeatSubstringPattern
    {
        public bool IsRepeatSubstringPattern(string input)
        {
            int[] lps = new int[input.Length];
            int length = 0;
            int pointer = 1;
            lps[0] = 0;
            int inputLength = input.Length;

            while (pointer < inputLength)
            {
                if (input[pointer] == input[length])
                {
                    length++;
                    lps[pointer] = length;
                    pointer++;
                }
                else
                {
                    if (length != 0)
                    {
                        length = lps[length - 1];
                    }
                    else
                    {
                        lps[pointer] = length;
                        pointer++;
                    }
                }
            }
            for (int i = 0; i < lps.Length; i++)
            {
                Console.WriteLine($" {lps[i]} ");
            }
            int endValue = lps[inputLength - 1];

            return (endValue > 0 && inputLength % (inputLength - endValue) == 0)
                               ? true : false;

        }
    }
}
