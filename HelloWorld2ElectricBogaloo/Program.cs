using System;

namespace HelloWorld2ElectricBogaloo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(AddNumbers(numbers));
            string[] words = { "one", "two", "tree", "four", "five", "six", "seven", "eight", "nine", "ten" };
            ReverseWords(words);
            Console.WriteLine("biggest number: " + BigSmallNumber(numbers, true)); //true ger största number
            Console.WriteLine("smallest number: " + BigSmallNumber(numbers, false));//false ger minsta number
        }
        public static int AddNumbers(int[] numbersToAdd)
        {
            int sum = 0;
            foreach(int Element in numbersToAdd)
            {
                sum += Element;
            }
            return sum;
        }

        public static void ReverseWords(string[] wordsToReverse)
        {
            for(int i = (wordsToReverse.Length - 1); i >= 0; i--)
            {
                Console.WriteLine(wordsToReverse[i]);
            }
        }

        public static int BigSmallNumber(int[] numbersToBigSmall, bool bigOrSmall)
        {

            if(bigOrSmall) //leta efter största number
            {
                var currentBiggestNumber = numbersToBigSmall[0];

                foreach(int element in numbersToBigSmall)
                {
                    if(element > currentBiggestNumber)
                    {
                        currentBiggestNumber = element;
                        continue;
                    }
                }
                return currentBiggestNumber;
            } else // leta efter minsta number
            {
                var currentSmallestNumber = numbersToBigSmall[0];

                foreach (int element in numbersToBigSmall)
                {
                    if (element < currentSmallestNumber)
                    {
                        currentSmallestNumber = element;
                        continue;
                    }
                }
                return currentSmallestNumber;
            }
        }
    }
}
