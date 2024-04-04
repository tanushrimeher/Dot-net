using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        
        foreach (int num in numbers)
        {
            if (frequencyMap.ContainsKey(num))
            {
                frequencyMap[num]++;
            }
            else
            {
                frequencyMap[num] = 1;
            }
        }

        
        foreach (var kvp in frequencyMap)
        {
            Console.WriteLine($"Element: {kvp.Key}, Frequency: {kvp.Value}");
        }
    }
}
