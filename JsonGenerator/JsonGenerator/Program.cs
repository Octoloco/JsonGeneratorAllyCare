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
                string fileName = "C:/Users/Diego/Desktop/AllyCare/JsonGeneratorAllyCare/Jsons/" + i.ToString() + ".json";
                string jsonString = "{\r\n\"name\": \"Test #" + i + "\",\r\n\"symbol\": \"NB\",\r\n\"description\": \"Collection of 22,000 numbers on the blockchain. This is the number " + i + "/22000.\",\r\n\"seller_fee_basis_points\": 500,\r\n\"image\": \"0.jpg\",\r\n\"attributes\": [\r\n{ \"trait_type\": \"Holidays\", \"value\": \"0\"},\r\n{ \"trait_type\": \"Courses\", \"value\": \"0\"},\r\n{ \"trait_type\": \"Yoga\", \"value\": \"1\"},\r\n{ \"trait_type\": \"Car\", \"value\": \"0\"},\r\n{ \"trait_type\": \"kit\", \"value\": \"1\"}\r\n],\r\n\"properties\": {\r\n\"creators\": [{ \"address\": \"8TXdPWnq8dB4Nnj1WxSqQnLJdbbduw9sQomsBZx7TCs3\", \"share\": 100}],\r\n\"files\": [{ \"uri\": \"0.jpg\", \"type\": \"image/jpg\"}]\r\n},\r\n\"collection\": { \"name\": \"ACTests\", \"family\": \"ACTests\"}\r\n}";
                File.WriteAllText(fileName, jsonString);

                Console.WriteLine(File.ReadAllText(fileName));
            }
        }


        public static void Main()
        {

        }
    }
}