using System;
using Microsoft.Extensions.Configuration;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var config = LoadConfiguration();

            int[] inputArray = GetUserInputArray();
            int evenPoints = GetConfigValue(config, "ScoringRules:EvenPoints", 1);
            int oddPoints = GetConfigValue(config, "ScoringRules:OddPoints", 3);
            int eightPoints = GetConfigValue(config, "ScoringRules:EightPoints", 5);

            int score = CalculateTotalScore(inputArray, evenPoints, oddPoints, eightPoints);

            Console.WriteLine("Total Score: " + score);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static IConfiguration LoadConfiguration()
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        return config;
    }

    static int[] GetUserInputArray()
    {
        Console.WriteLine("Enter an array of integers separated by spaces:");

        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input. Please enter integers separated by spaces.");
                continue;
            }

            string[] inputValues = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] inputArray = new int[inputValues.Length];

            for (int i = 0; i < inputValues.Length; i++)
            {
                if (int.TryParse(inputValues[i], out int value))
                {
                    inputArray[i] = value;
                }
                else
                {
                    Console.WriteLine($"Invalid input: '{inputValues[i]}'. Please enter valid integers.");
                    return GetUserInputArray();
                }
            }

            return inputArray;
        }
    }

    static int CalculateTotalScore(int[] arr, int evenPoints, int oddPoints, int eightPoints)
    {
        int score = 0;

        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                score += evenPoints; // Add points for even numbers
            }
            else
            {
                score += oddPoints; // Add points for odd numbers
            }

            if (num == 8)
            {
                score += eightPoints; // Add points for each occurrence of 8
            }
        }

        return score;
    }

    static int GetConfigValue(IConfiguration config, string key, int defaultValue)
    {
        string value = config[key];
        if (int.TryParse(value, out int intValue))
        {
            return intValue;
        }

        return defaultValue;
    }
}
