//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input input = new Input();
            while (true)
            {
                Console.WriteLine("1. Do you want to enter the text via the keyboard?");
                Console.WriteLine("2. Do you want to read in the text from a file?");
                int userInput = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input: " + userInput);

                if (userInput == 1)
                {
                    input.manualTextInput();
                    break;
                }
                else if (userInput == 2)
                {
                    input.fileTextInput("CMP1903M Assessment 1 Test File.txt");
                    break;
                }
            }

            //Create an 'Analyse' object
            Analyse analyse = new Analyse();

            //Pass the text input to the 'analyseText' method
            List<int> values = analyse.analyseText(input.text);

            //Receive a list of integers back

            //Report the results of the analysis
            Report report = new Report();
            report.outputConsole(values);

            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}
