using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Given a string that can only contain characters 
// a - z, get the unique characters from this string
namespace GetUniqueChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "aaabcdssfhh";

            var result = GetUniqueChars(input);

            foreach (char ch in result)
            {
                Console.Write(ch + " ");
            }
        }

        static List<char> GetUniqueChars(string input)
        {
            // 26 since only characters a - z can be present
            bool[] flags = new bool[26];

            List<char> result = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                int index = input[i] - 'a';

                if (!flags[index])
                {
                    flags[index] = true;
                    result.Add(input[i]);
                }
            }

            return result;
        }
    }
}
