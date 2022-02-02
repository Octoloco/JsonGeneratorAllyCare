using System;
using System.IO;
using System.Text.Json;

namespace SerializeToFile
{    
    public class Program
    {
        private int property1 = 0;
        private int property2 = 0;
        private int property3 = 0;
        private int property4 = 0;
        private int property5 = 0;

        private void Generate(int iterations, int startingIndex)
        {
            for (int i = 0; i < iterations; i++)
            {
                string fileName = "C:/Users/Diego/Desktop/Projects/AllyCare/JsonGeneratorAllyCare/Jsons/" + (startingIndex + i).ToString() + ".json";
                string jsonString = "{\r\n\"name\": \"Test #" + (startingIndex + i + 1).ToString() + "\",\r\n\"symbol\": \"NB\",\r\n\"description\": \"Collection of 22,000 numbers on the blockchain. This is the number " + (startingIndex + i + 1).ToString() + "/22000.\",\r\n\"seller_fee_basis_points\": 500,\r\n\"image\": \"" + (startingIndex + i).ToString() + ".jpg\",\r\n\"attributes\": [\r\n{ \"trait_type\": \"Holidays\", \"value\": \"" + property1.ToString() + "\"},\r\n{ \"trait_type\": \"Courses\", \"value\": \"" + property2.ToString() + "\"},\r\n{ \"trait_type\": \"Yoga\", \"value\": \"" + property3.ToString() + "\"},\r\n{ \"trait_type\": \"Car\", \"value\": \"" + property4.ToString() + "\"},\r\n{ \"trait_type\": \"kit\", \"value\": \"" + property5.ToString() + "\"}\r\n],\r\n\"properties\": {\r\n\"creators\": [{ \"address\": \"2AxNK5iCSP5JrdnpyaJZpsx4CyuGALCcyMWcnq7Fwgzh\", \"share\": 100}],\r\n\"files\": [{ \"uri\": \"" + (startingIndex + i).ToString() + ".jpg\", \"type\": \"image/jpg\"}]\r\n},\r\n\"collection\": { \"name\": \"ACTests\", \"family\": \"ACTests\"}\r\n}";
                File.WriteAllText(fileName, jsonString);
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

        private void SetProperty1()
        {
            Console.WriteLine("Has property1? Y/N:");
            string input = Console.ReadLine();
            if (input == "y" || input == "Y")
            {
                property1 = 1;
            }
            else if (input == "n" || input == "N")
            {
                property1 = 0;
            }
            else
            {
                Console.WriteLine("Input invalid, try again");
                SetProperty1();
            }
        }

        private void SetProperty2()
        {
            Console.WriteLine("Has property2? Y/N:");
            string input = Console.ReadLine();
            if (input == "y" || input == "Y")
            {
                property2 = 1;
            }
            else if (input == "n" || input == "N")
            {
                property2 = 0;
            }
            else
            {
                Console.WriteLine("Input invalid, try again");
                SetProperty2();
            }
        }

        private void SetProperty3()
        {
            Console.WriteLine("Has property3? Y/N:");
            string input = Console.ReadLine();
            if (input == "y" || input == "Y")
            {
                property3 = 1;
            }
            else if (input == "n" || input == "N")
            {
                property3 = 0;
            }
            else
            {
                Console.WriteLine("Input invalid, try again");
                SetProperty3();
            }
        }

        private void SetProperty4()
        {
            Console.WriteLine("Has property4? Y/N:");
            string input = Console.ReadLine();
            if (input == "y" || input == "Y")
            {
                property4 = 1;
            }
            else if (input == "n" || input == "N")
            {
                property4 = 0;
            }
            else
            {
                Console.WriteLine("Input invalid, try again");
                SetProperty4();
            }
        }

        private void SetProperty5()
        {
            Console.WriteLine("Has property5? Y/N:");
            string input = Console.ReadLine();
            if (input == "y" || input == "Y")
            {
                property5 = 1;
            }
            else if (input == "n" || input == "N")
            {
                property5 = 0;
            }
            else
            {
                Console.WriteLine("Input invalid, try again");
                SetProperty5();
            }
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
            program.SetProperty1();
            program.SetProperty2();
            program.SetProperty3();
            program.SetProperty4();
            program.SetProperty5();
            Console.WriteLine("Generating " + totalItrations + "NFTs starting with Index: " + startingIndex);
            program.Generate(totalItrations, startingIndex);
            Console.WriteLine("Done!");
        }
    }
}