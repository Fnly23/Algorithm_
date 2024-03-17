using System;
using System.IO;



namespace AlgorithmsAndComplexity
{
    internal class Program
    {
        static void Main()
        {
            bool exit = false;
            
            
            while (exit == false) 
            {

            Console.WriteLine("Which net file to open? [0/1/2/3]");
            string userInput = Console.ReadLine();
            Convert.ToInt32(userInput);
                if (userInput == "1") 
                {
                    fileReader.ReadFile("Net_1_256.txt");

                    Console.WriteLine("Net_1_256.txt");
                    Console.ReadKey();  
                
                }




            }



        }
    }
}
