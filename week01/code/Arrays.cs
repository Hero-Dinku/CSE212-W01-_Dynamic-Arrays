using System;
using System.Collections.Generic;
using System.Diagnostics;

public static class Arrays
{
    /// <summary>
    /// Returns an array containing multiples of a number.
    /// </summary>
    /// <param name=""number"">The number to find multiples of.</param>
    /// <param name=""count"">How many multiples to find.</param>
    /// <returns>An array containing multiples of the number.</returns>
    public static double[] MultiplesOf(int number, int count)
    {
        // Step 1: Plan - Create an array of size 'count' to store results
        // Step 2: Plan - Use a for loop to calculate each multiple
        // Step 3: Plan - For each iteration, multiply number by (i + 1)
        // Step 4: Plan - Store result in array and return
        
        // Implementation:
        double[] result = new double[count];
        
        for (int i = 0; i < count; i++)
        {
            result[i] = number * (i + 1);
        }
        
        return result;
    }

    /// <summary>
    /// Rotates a list to the right by the specified amount.
    /// </summary>
    /// <param name=""data"">The list to rotate.</param>
    /// <param name=""amount"">How far to rotate to the right.</param>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Plan - Check for edge cases (null, empty, invalid amount)
        // Step 2: Plan - Calculate split index = data.Count - amount
        // Step 3: Plan - Get right part using GetRange(splitIndex, amount)
        // Step 4: Plan - Get left part using GetRange(0, splitIndex)
        // Step 5: Plan - Clear original list
        // Step 6: Plan - Add right part then left part
        
        // Implementation:
        if (data == null || data.Count == 0 || amount <= 0 || amount > data.Count)
            return;
            
        int splitIndex = data.Count - amount;
        
        // Get the two parts
        List<int> rightPart = data.GetRange(splitIndex, amount);
        List<int> leftPart = data.GetRange(0, splitIndex);
        
        // Clear and rebuild the list
        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}
