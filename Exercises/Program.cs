using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Feel free to test out your stuff below...");

            var result = StringToFirstUpperLetter("giNte");

            Console.WriteLine(result);
        }

        // Generate a list of numbers from 1 to 10
        // Input: none
        // Output: a list of integers =>  1, 2 ... 8, 9, 10
        public static List<int> GetNumbersFromOneToTen()
        {
            var numbers = new List<int>() {1,2,3,4,5,6,7,8,9,10 };

            return numbers;
        }

        // Connect two strings
        // Input: Vilius, Zobela
        // Output: Vilius Zobela
        public static string GetFullName(string firstName, string lastName)
        {
            var name = firstName + " " + lastName;

            return name;
        }

        // Calculate the perimeter of a square by formula '2a + 2b'
        // Input: 2, 3
        // Output: 10
        public static int CalculatePerimeterOfSquare(int a, int b)
        {
            var sq = (2 * a) + (2 * b);

            return sq;
        }

        // Get the maximum number from an int array
        // Input: { 2, 5, 3, 2, 10, 4 }
        // Output: 10
        public static int GetMaxNumber(int[] array)
        {
            var maxNum = array.Max();
         
            return maxNum;
        }

        // Get the sum of the first and last elements of the array
        // Input: { 2, 5, 3, 2, 10, 4 }
        // Output: 2 + 4 = 6
        public static int GetFirstAndLastSum(int[] array)
        {
            var lastNum = array.Length;
            var sum = array[0] + array[lastNum - 1];

            return sum;
        }

        // Reverse the integer array
        // Input: { 1, 2, 3, 4 }
        // Output: { 4, 3, 2, 1 }
        public static int[] ReverseArray(int[] array)
        {
            var result = array.Reverse().ToArray();

            return result;
        }

        // Convert the string to first upper letter format
        // Input: vilius
        // Output: Vilius
        public static string StringToFirstUpperLetter(string someString)
        {

            var lower = someString.ToLower();
            var result = char.ToUpper(lower[0]) + lower.Substring(1);

            return result;
        }
    }
}