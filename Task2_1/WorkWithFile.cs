using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2_1
{
    class WorkWithFile
    {
        public void FileReader()
        {
            int counter = 0;
            string line;
            string modifiedLine;
            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"d:\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                modifiedLine = UpperToLower(line);
                modifiedLine=EndOfSentence(modifiedLine);
                System.Console.WriteLine(modifiedLine);
                counter++;
            }
            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.
            System.Console.ReadLine();
        }
        public string UpperToLower(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.ToLower();
        }
        public string EndOfSentence(string input)
        {
            string pattern = "[.]";
            string replacement=".\n";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            return result;
        }

    }
}
