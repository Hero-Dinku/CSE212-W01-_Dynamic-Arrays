using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine(""Testing MultiplesOf function:"");
        
        // Test 1: Multiples of 3, 5 times
        double[] result1 = Arrays.MultiplesOf(3, 5);
        Console.Write(""MultiplesOf(3, 5): "");
        foreach (var num in result1)
            Console.Write(num + "" "");
        Console.WriteLine();
        
        // Test 2: Multiples of 7, 3 times
        double[] result2 = Arrays.MultiplesOf(7, 3);
        Console.Write(""MultiplesOf(7, 3): "");
        foreach (var num in result2)
            Console.Write(num + "" "");
        Console.WriteLine();
        
        Console.WriteLine(""\nTesting RotateListRight function:"");
        
        // Test 1: Rotate by 5
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.Write(""Original: "");
        foreach (var num in list1)
            Console.Write(num + "" "");
        Console.WriteLine();
        
        Arrays.RotateListRight(list1, 5);
        Console.Write(""After rotating by 5: "");
        foreach (var num in list1)
            Console.Write(num + "" "");
        Console.WriteLine();
        
        // Test 2: Rotate by 3
        List<int> list2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Arrays.RotateListRight(list2, 3);
        Console.Write(""After rotating by 3: "");
        foreach (var num in list2)
            Console.Write(num + "" "");
        Console.WriteLine();
    }
}
