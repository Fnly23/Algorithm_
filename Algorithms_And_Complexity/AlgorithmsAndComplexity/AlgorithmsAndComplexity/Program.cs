using System;
using System.IO;



namespace AlgorithmsAndComplexity
{
    internal class Program
    {
        static void Main()
        {
            
            // create an exit loop
            bool exit = false;
            
            // exit loop
            while (exit == false) 
            {
            // allows user to open which net file
            Console.WriteLine("Which net file to open? [1/2/3]");
            string userInput = Console.ReadLine();
            
            //Convert.ToInt32(userInput);
                if (userInput == "1")
                {
                    fileReader.ReadFile("Net_1_256.txt");
                }
                
                else if (userInput == "2")
                {
                    fileReader.ReadFile("Net_2_256.txt");
                }
               
                
                
                else if (userInput == "3")
                {
                    fileReader.ReadFile("Net_3_256.txt")
                }
               
                
                
                
                else
                {
                    Console.WriteLine("Not a valid input");
                
                }

            }



        }
    }
}
