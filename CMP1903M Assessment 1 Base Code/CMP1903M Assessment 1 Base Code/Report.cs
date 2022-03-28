using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        //public void outputConsole(List<int>)
        //{
        //    Console.WriteLine("Report.");
        //}

        public void outputConsole(List<int> analysis)
        {
            Console.WriteLine("Report.");
            Console.WriteLine("Sentences: " + analysis[0]);
            Console.WriteLine("Vowels: " + analysis[1]);
            Console.WriteLine("Consonants: " + analysis[2]);
            Console.WriteLine("Total characters: " + analysis[3]);
            Console.WriteLine("Lowercase letters: " + analysis[4]);
            Console.WriteLine("Uppercase letters: " + analysis[5]);
        }
    }
}