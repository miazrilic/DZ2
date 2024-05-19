using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_PREIMENOVANJE
{
    internal class Zad5refakt
    {
        class Palindromes
        {
            public List<string> AddPalindromes(List<string> strings)
            {
                List<string> palindromes = new List<string>();
                if (strings == null) return palindromes;
                foreach (string str in strings)
                {
                    if (IsPalindrome(str))
                    {
                        palindromes.Add(str);
                    }
                }
                return palindromes;
            }
            public bool IsPalindrome(string str)
            {


                string temp1 = str.Replace(" ", "").ToLower();
                string temp2 = new string(temp1.Reverse().ToArray());
                return temp1.Equals(temp2);

            }


        }
    }
}
