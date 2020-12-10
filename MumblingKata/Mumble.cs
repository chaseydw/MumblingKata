using System;
using System.Collections.Generic;
using System.Text;

namespace MumblingKata
{
    public class Mumble
    {
        public string mumble_letters(string letters) 
        {
            char[] arrayOfLetters = letters.ToCharArray();
            string returnLetters = string.Empty;
            int position = 1;
            foreach (char letter in arrayOfLetters)
            {
                returnLetters += letter.ToString().ToUpper();
                for (int i = 1; i < position; i++)
                {
                    returnLetters += letter.ToString().ToLower();
                }
                if (position < arrayOfLetters.Length)
                {
                    returnLetters += "-";
                }
                position++;
            }
            return returnLetters;
        }
    }
}
