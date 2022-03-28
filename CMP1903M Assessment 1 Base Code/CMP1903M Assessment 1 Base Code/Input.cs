using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        public string text = "nothing";
        List<string> paragraph = new List<string>();
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            while (true)
            {
                Console.WriteLine("Write sentence at a time, to get the report of the text back. If this is the last sentence, add '*' at the end, after the full stop.\n");
                text = Console.ReadLine();
                paragraph.Add(text);
                if (text.Contains('*'))
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            text = string.Join(" ", paragraph.ToArray());
            Console.WriteLine("Full paragraph: " + text);
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            text = File.ReadAllText(fileName);
            Console.WriteLine(text);
            return text;
        }

    }
}
