using System;

namespace _04_basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // 1. Print 1-255
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255
            for (uint i = 1; i <= 255; ++i)
                Console.WriteLine(i);
        }
        // ------------------------------------------------------------------------------
        // 2. Print odd numbers between 1-255
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255
            for (uint i = 1; i <= 255; ++i)
                if( i % 2 != 0)
                    Console.WriteLine(i);   
        }
        // ------------------------------------------------------------------------------
        // 3. Print Sum
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255,
            // but this time, also print the sum a syou go.
            uint sum = 0;
            for (uint i = 0; i <= 255; ++i)
            {
                sum += i;
                Console.WriteLine($"New number: {i} \tSum: {sum}");
            }
        }
        // ------------------------------------------------------------------------------
        // 4. Iterating through an Array
        public static void LoopArray(int[] numbers)
        {
            foreach(int number in numbers)
                Console.WriteLine($"Current number = {number}");
        }
        // ------------------------------------------------------------------------------
        // 5. Find Max
        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach(int number in numbers)
            {
                if (max > number)
                    max = number;
            }
            return max;
        }
        // ------------------------------------------------------------------------------
        // 6. Get Average
        public static double GetAverage(int[] numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
                sum += number;
            return (double)sum / (double)numbers.Length;
        }
        // ------------------------------------------------------------------------------
        // 7. Array with Odd-Numbers
        public static uint[] OddArray()
        {
            // -Write a function that creates, and then returns,
            //  an array that contains all the odd numbers between 1 to 255.
            // -When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
            uint[] numbers = new uint[255];
            for (uint i = 0, count=0; i <= 255; i+=2)
                numbers[count++] = i;
            return numbers;
        }
        // ------------------------------------------------------------------------------
        // 8. Greater than Y
        public static int GreaterThanY(int[] numbers, int y)
        {
            // -Write a function that takes as input an interger array, and ta integer y
            //  and returns the number of array values that are greater than the y-value.
            int count = 0;
            foreach (int number in numbers)
            {
                if(number > y)
                    ++count;
            }
            return count;
        }
        // ------------------------------------------------------------------------------
        // 9. Square the Values
        public static void SquareArrayValues(int[] numbers)
        {
            // -Write a function that takes an integer array "numbers", 
            //  and then multiplies each value by itself.
            for(int i = 0; i < numbers.Length; ++i)
                numbers[i] *= numbers[i];
        }
        // ------------------------------------------------------------------------------
        // 10. Eliminate Negative Numbers
        public static void EliminateNegatives(ref int[] numbers)
        {
            // -Given an integer array "numbers", create a function that 
            //  replaces any negateive numbers with the value of zero.
            for(int i = 0; i < numbers.Length; ++i)
            {
                if(numbers[i] < 0)
                    numbers[i] = 0;
            }

            // NOTE: Passed by reference!
        }
        // ------------------------------------------------------------------------------
        // 11. Min, Max, and Average
        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            foreach (int number in numbers)
            {
                if (max > number)
                    max = number;
                if (min < number)
                    min = number;
                sum += number;
            }
            double ave = (double)sum / (double)numbers.Length;
        }
        // ------------------------------------------------------------------------------
        // 12. Shifting the Values in an Array
        public static void shift(int[] arr)
        {
            int end = arr[arr.Length-1];
            for(int i = arr.Length-1; i >= 0; --i)
                arr[i+1] = arr[i];
            arr[0] = end;
        }
        // ------------------------------------------------------------------------------
        // 13. Number to String
        public static string NumToString(int number)
        {
            return number.ToString();
        }     
    }
}
