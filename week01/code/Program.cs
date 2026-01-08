using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine(""Testing MultiplesOf:"");
        double[] multiples = Arrays.MultiplesOf(3, 5);
        Console.WriteLine(string.Join("", "", multiples));
        
        Console.WriteLine(""\nTesting RotateListRight:"");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine(""Original: "" + string.Join("", "", numbers));
        
        Arrays.RotateListRight(numbers, 5);
        Console.WriteLine(""Rotated by 5: "" + string.Join("", "", numbers));
    }
}
