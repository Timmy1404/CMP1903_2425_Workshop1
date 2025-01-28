using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Workshop_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumbers = GenerateRandomIntegers(100, 1, 1000);

            int sum = ComputeSum(randomNumbers);

            int[] histogram = ComputeHistogram(randomNumbers);

            DisplayHistogram(histogram);
        }

        static int[] GenerateRandomIntegers(int count, int min, int max)
        {
            Random random = new Random();
            // Array to store random integers
            int[] numbers = new int[count];

            for (int i = 0; i < numbers.Length; i++)
            {
                // Random number between min and max
                numbers[i] = random.Next(min, max + 1);
                Console.WriteLine($"Number {i + 1}: {numbers[i]}");
            }

            return numbers;
        }

        static int ComputeSum(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                //Console.WriteLine($"sum: {sum}");
            }
            Console.WriteLine($"sum: {sum}");

            return sum;
        }


        static int[] ComputeHistogram(int[] numbers)
        {
            int binCount = 20;
            // Array to hold frequency for 20 bins
            int[] histogram = new int[binCount];
            int maxNumber = 1000;
            int binSize = maxNumber / binCount;
            foreach (int number in numbers)
            {
                // Calculate the bin index
                int binIndex = (number - 1) / binSize;
                histogram[binIndex]++;
            }

            return histogram;

        }

        static void DisplayHistogram(int[] histogram)
        {
            Console.WriteLine("Frequency Histogram:");
            int binSize = 1000 / histogram.Length;
            for (int i = 0; 1 < histogram.Length; i++)
            {
                // Display the range of each bin
                int binStart = i * binSize + 1;
                int binEnd = (i + 1) * binSize;
                Console.WriteLine($"Numbers {binStart} to {binEnd}: {histogram[i]} times");

            }

        }

    }
}
