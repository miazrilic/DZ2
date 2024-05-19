using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_PREIMENOVANJE
{
    internal class Zad4refakt
    {
        class Occurence
        {
            public static List<char> AddReoccuringChars(string text)
            {
                List<char> chars = new List<char>();
                for (int i = 0; i < text.Length; i++)
                {
                    if (CountCharOccurence(text, text[i]) == 1)
                    {
                        chars.Add(text[i]);
                    }
                }
                return chars;
            }

            public static int CountCharOccurence(string text, char currentCharacter)
            {

                int occurrenceCount = 0;
                for (int j = 0; j < text.Length; j++)
                {
                    if (currentCharacter == text[j])
                    {
                        occurrenceCount++;
                    }
                }
                return occurrenceCount;

            }

        }
    }
}
