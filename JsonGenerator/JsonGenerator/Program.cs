using System;
using System.IO;
using System.Text.Json;

namespace SerializeToFile
{    
    public class Program
    {
        private void Generate(int iterations, int startingIndex)
        {
            for (int i = 0; i < iterations; i++)
            {
                string fileName = "C:/Users/Diego/Desktop/AllyCare/JsonGeneratorAllyCare/Jsons/" + (startingIndex + i).ToString() + ".json";
                string jsonString = "{\r\n\"name\": \"Test #" + (startingIndex + i + 1).ToString() + "\",\r\n\"symbol\": \"NB\",\r\n\"description\": \"Collection of 22,000 numbers on the blockchain. This is the number " + (startingIndex + i + 1).ToString() + "/22000.\",\r\n\"seller_fee_basis_points\": 500,\r\n\"image\": \"" + (startingIndex + i).ToString() + ".jpg\",\r\n\"attributes\": [\r\n{ \"trait_type\": \"Holidays\", \"value\": \"0\"},\r\n{ \"trait_type\": \"Courses\", \"value\": \"0\"},\r\n{ \"trait_type\": \"Yoga\", \"value\": \"1\"},\r\n{ \"trait_type\": \"Car\", \"value\": \"0\"},\r\n{ \"trait_type\": \"kit\", \"value\": \"1\"}\r\n],\r\n\"properties\": {\r\n\"creators\": [{ \"address\": \"8TXdPWnq8dB4Nnj1WxSqQnLJdbbduw9sQomsBZx7TCs3\", \"share\": 100}],\r\n\"files\": [{ \"uri\": \"" + (startingIndex + i).ToString() + ".jpg\", \"type\": \"image/jpg\"}]\r\n},\r\n\"collection\": { \"name\": \"ACTests\", \"family\": \"ACTests\"}\r\n}";
                File.WriteAllText(fileName, jsonString);

                Console.WriteLine(File.ReadAllText(fileName));
            }
        }

        private int SetIterations()
        {
            int totalItrations = 0;

            Console.WriteLine("Number of NFTs to create:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out totalItrations))
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Input invalid, try again");
                totalItrations = SetIterations();
            }

            return totalItrations;
        }

        private int SetStartingIndex()
        {
            int startingIndex = 0;

            Console.WriteLine("Index to start with:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out startingIndex))
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Input invalid, try again");
                startingIndex = SetIterations();
            }

            return startingIndex;
        }


        public static void Main()
        {
            Program program = new Program();
            int totalItrations = program.SetIterations();
            int startingIndex = program.SetStartingIndex();
            Console.WriteLine("Generating " + totalItrations + "NFTs starting with Index: " + startingIndex);
            //program.Generate(totalItrations, startingIndex);
            Console.WriteLine("Done!");
        }
    }
}