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
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"d:\test2.txt");
                while ((line = file.ReadLine()) != null)
                {
                    modifiedLine = UpperToLower(line);
                    modifiedLine = EndOfSentence(modifiedLine);
                    System.Console.Write(DataStampe() + " ");
                    System.Console.WriteLine(modifiedLine);
                    counter++;
                }
                file.Close();
                System.Console.WriteLine("There were {0} lines.", counter);
                System.Console.ReadLine();
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Error reading from {0}. Message = {1}", @"d:\test2.txt", e.Message);
            }
  
        }
        public string UpperToLower(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("Error: null or empty");
            return input.ToLower();
        }
        public string EndOfSentence(string input)
        {
            string pattern = "[.]";
            string replacement= ".\n"+ DataStampe();
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            return result;
        }
        public string DataStampe() {
            DateTime dateValue = DateTime.Now;
            return dateValue.ToString("MM/dd/yyyy hh:mm:ss.fff tt");
        }

    }
}
