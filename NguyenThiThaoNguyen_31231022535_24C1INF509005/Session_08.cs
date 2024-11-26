using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiThaoNguyen_31231022535_24C1INF509005
{
    internal class Session_08
    {

        static void Main()
        {
            // Input a string and print it
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Your entered string: " + input);

            int length = FindStringLength(input);
            Console.WriteLine("Length of the string: " + length);

            // Separate individual characters from a string
            Console.WriteLine("Individual characters of the string:");
            foreach (char ch in input)
            {
                Console.WriteLine(ch);
            }

            // Print individual characters of the string in reverse order
            Console.WriteLine("Characters in reverse order:");
            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();

            // Count the total number of words in a string
            int wordCount = CountWords(input);
            Console.WriteLine("Total number of words: " + wordCount);

            // Compare two strings without using library functions
            Console.Write("Enter another string to compare: ");
            string input2 = Console.ReadLine();
            bool areEqual = CompareStrings(input, input2);
            Console.WriteLine($"Strings are {(areEqual ? "equal" : "not equal")}.");

            // Count the number of alphabets, digits, and special characters
            CountAlphabetsDigitsSpecials(input, out int alphabets, out int digits, out int specials);
            Console.WriteLine($"Alphabets: {alphabets}, Digits: {digits}, Special Characters: {specials}");

            // Count the number of vowels or consonants
            int vowels, consonants;
            CountVowelsAndConsonants(input, out vowels, out consonants);
            Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");

            // Check whether a given substring is present in the string
            Console.Write("Enter a substring to search: ");
            string substring = Console.ReadLine();
            bool isSubstringPresent = CheckSubstringPresence(input, substring);
            Console.WriteLine($"Substring is {(isSubstringPresent ? "present" : "not present")} in the string.");

            // Search for the position of a substring within a string
            int substringPosition = GetSubstringPosition(input, substring);
            if (substringPosition != -1)
            {
                Console.WriteLine($"Substring found at position: {substringPosition}");
            }
            else
            {
                Console.WriteLine("Substring not found.");
            }

            // Check whether a character is an alphabet and its case
            Console.Write("Enter a character to check: ");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine();
            CheckCharacter(character);

            // Find the number of times a substring appears in a given string
            int substringCount = CountSubstringOccurrences(input, substring);
            Console.WriteLine($"Substring appears {substringCount} times in the string.");

            // Insert a substring before the first occurrence of a string
            Console.Write("Enter a substring to insert: ");
            string insertSubstring = Console.ReadLine();
            string modifiedString = InsertSubstring(input, insertSubstring, substring);
            Console.WriteLine("Modified string: " + modifiedString);
        }

        // Function to find string length
        static int FindStringLength(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                count++;
            }
            return count;
        }

        // Function to count words
        static int CountWords(string str)
        {
            string[] words = str.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        // Function to compare two strings
        static bool CompareStrings(string str1, string str2)
        {
            if (FindStringLength(str1) != FindStringLength(str2)) return false;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i]) return false;
            }
            return true;
        }

        // Function to count alphabets, digits, and special characters
        static void CountAlphabetsDigitsSpecials(string str, out int alphabets, out int digits, out int specials)
        {
            alphabets = digits = specials = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c)) alphabets++;
                else if (char.IsDigit(c)) digits++;
                else specials++;
            }
        }

        // Function to count vowels and consonants
        static void CountVowelsAndConsonants(string str, out int vowels, out int consonants)
        {
            vowels = consonants = 0;
            foreach (char c in str.ToLower())
            {
                if ("aeiou".Contains(c)) vowels++;
                else if (char.IsLetter(c)) consonants++;
            }
        }

        // Function to check substring presence
        static bool CheckSubstringPresence(string str, string substr)
        {
            return GetSubstringPosition(str, substr) != -1;
        }

        // Function to get substring position
        static int GetSubstringPosition(string str, string substr)
        {
            int strLen = FindStringLength(str);
            int subLen = FindStringLength(substr);

            for (int i = 0; i <= strLen - subLen; i++)
            {
                int j;
                for (j = 0; j < subLen; j++)
                {
                    if (str[i + j] != substr[j]) break;
                }
                if (j == subLen) return i;
            }
            return -1;
        }

        // Function to check character and its case
        static void CheckCharacter(char c)
        {
            if (char.IsLetter(c))
            {
                Console.WriteLine($"'{c}' is an alphabet.");
                Console.WriteLine($"It is {(char.IsUpper(c) ? "uppercase" : "lowercase")}.");
            }
            else
            {
                Console.WriteLine($"'{c}' is not an alphabet.");
            }
        }

        // Function to count substring occurrences
        static int CountSubstringOccurrences(string str, string substr)
        {
            int count = 0;
            int pos = 0;
            while ((pos = GetSubstringPosition(str.Substring(pos), substr)) != -1)
            {
                count++;
                pos += substr.Length;
            }
            return count;
        }

        // Function to insert a substring before the first occurrence
        static string InsertSubstring(string str, string toInsert, string before)
        {
            int pos = GetSubstringPosition(str, before);
            if (pos == -1) return str;
            return str.Substring(0, pos) + toInsert + str.Substring(pos);
        }
    }
}
