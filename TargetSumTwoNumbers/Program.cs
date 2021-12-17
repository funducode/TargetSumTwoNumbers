using System;
using System.Collections.Generic;
using System.Linq;

namespace TargetSumTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read array from console
            Console.Write("Input integer array comma separated: ");
            var array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            // Read target sum from console
            Console.Write("Input target sum: ");
            var target = int.Parse(Console.ReadLine());

            var nums = FindTargetSumForTwoNumbers(array, target);
            if (nums.Length > 0)
                Console.WriteLine("Numbers: " + String.Join(",", nums) + " makes target sum of " + target);
            else
                Console.WriteLine("Unable to find numbers that add up to " + target);
        
        }

        static int[] FindTargetSumForTwoNumbers(int[] inputNumbers, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (dict.ContainsKey(inputNumbers[i]))
                   return new int[] { inputNumbers[i], dict[inputNumbers[i]] };
                else
                    dict[target - inputNumbers[i]] = inputNumbers[i];
            
            }

            // If not found return empty
            return new int[] { };
        }
    }


}
