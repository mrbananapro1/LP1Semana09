using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {

            string file = args[0];


            bool readingInput = true;


            Queue<string> userInputs = new Queue<string>();
            while (readingInput)
            {
                string userInput = Console.ReadLine();
                if (userInput == "")
                {
                    break;
                }
                else
                {

                    userInputs.Enqueue(userInput);
                }
            }

            File.WriteAllLines(file, userInputs);
        }
    }
}