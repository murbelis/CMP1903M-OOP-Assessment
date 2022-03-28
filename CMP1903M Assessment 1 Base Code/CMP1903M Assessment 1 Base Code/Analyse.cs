using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text
        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            int sentences = 0;
            char fullStop = '.';
            char questionMark = '?';
            char exclamationMark = '!';
            foreach (char sentence in input)
            {
                if (sentence == fullStop || sentence == questionMark || sentence == exclamationMark)
                {
                    sentences++;
                }
            }

            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            int vowels = 0;
            int consonants = 0;
            int total = 0;
            int upperCase = 0;
            int lowerCase = 0;
            var listOfVowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            var listOfVowelsUpper = new HashSet<char> { 'A', 'E', 'I', 'O', 'U' };
            var listOfConsonants = new HashSet<char> { 'b', 'c', 'd', 'f', 'g', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 's', 't', 'v', 'x', 'z', 'h', 'r', 'w', 'y' };
            var listOfConsonantsUpper = new HashSet<char> { 'B', 'C', 'D', 'F', 'G', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'S', 'T', 'V', 'X', 'Z', 'H', 'R', 'W', 'Y' };
            var listOfCharacters = new HashSet<char> { '.', ' ', ',', '?', '!' };

            for (int i = 0; i < input.Length; i++)
            {
                if (listOfVowels.Contains(input[i]) || listOfVowelsUpper.Contains(input[i]))
                {
                    vowels++;
                }
                if (listOfConsonants.Contains(input[i]) || listOfConsonantsUpper.Contains(input[i]))
                {
                    consonants++;
                }
                if (listOfCharacters.Contains(input[i]))
                {
                    total++;
                }
                if (listOfVowelsUpper.Contains(input[i]) || listOfConsonantsUpper.Contains(input[i]))
                {
                    upperCase++;
                }
                if (listOfVowels.Contains(input[i]) || listOfConsonants.Contains(input[i]))
                {
                    lowerCase++;
                }
            }
            total = total + vowels + consonants;
            //Console.WriteLine("\nSentences: " + sentences);
            //Console.WriteLine("Vowles: {0}", vowels);
            //Console.WriteLine("Consonants: {0}", consonants);
            //Console.WriteLine("Total characters: {0}", total);
            //Console.WriteLine("Lowercase letters: {0}", lowerCase);
            //Console.WriteLine("Uppercase letters: {0}", upperCase);

            List<int> values = new List<int>();
            values.Add(sentences);
            values.Add(vowels);
            values.Add(consonants);
            values.Add(total);
            values.Add(lowerCase);
            values.Add(upperCase);

            return values;
        }
    }
}
