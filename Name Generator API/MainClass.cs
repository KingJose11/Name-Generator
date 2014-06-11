using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    public static class MainClass
    {
        public static String GenerateName(String pattern, String vowels = "", String consonants = "", String numbers = "")
        {
            var sb = new StringBuilder();
            pattern = pattern.ToLower();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == 'c' || pattern[i] == 'C')
                {
                    if (consonants != "")
                    {
                        sb.Append((new Consonant(consonants)).Value);
                    }
                    else
                    {
                        sb.Append((new Consonant()).Value);
                    }
                }

                if (pattern[i] == 'v' || pattern[i] == 'V')
                {
                    if (vowels != "")
                    {
                        sb.Append((new Vowel(vowels)).Value);
                    }
                    else
                    {
                        sb.Append((new Vowel()).Value);
                    }
                }

                if (pattern[i] == 'n' || pattern[i] == 'N')
                {
                    if (numbers != "")
                    {
                        sb.Append((new Number(numbers)).Value);
                    }
                    else
                    {
                        sb.Append((new Number()).Value);
                    }
                }

                if (pattern[i] == ' ')
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}
