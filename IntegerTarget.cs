﻿namespace Week_3_Challenge_Labs;

public class IntegerTarget
{
    public void SearchForTarget(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == target)
                {
                    Console.WriteLine($"""
                                       The target number: {target} 
                                       can be reached by:
                                       adding the number {array[i]} which is at position {i} 
                                       and the number {array[j]} which is at position {j}.
                                       """);
                    break;
                }
                else
                {
                    Console.WriteLine("The target number cannot be reached.");
                }
            }
        }
    }
}