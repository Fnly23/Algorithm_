using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class fileReader
{
    private static int[] numbers;


    public static void ReadFile(string filename)
    {
        bool exit = false;
        while (!exit)
        {
            // gets the directory and the file path
            string directory = Directory.GetCurrentDirectory();

            string filepath = Path.Combine(directory, filename);
            
            // creates a new array based on the chosen file
            string[] lines = File.ReadAllLines(filepath);
            numbers = new int[lines.Length];

            foreach (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(lines[i], out int num))

                {
                    numbers[i] = num;
                    Console.WriteLine(numbers[i]);
                    
                }

            }

        }





    }

}

