using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static bool IsFromList(int[] initArr, int i, string[] strArr)
        {
            return initArr[i] - 1 == Array.IndexOf(strArr, "a") ||
                    initArr[i] - 1 == Array.IndexOf(strArr, "e") ||
                    initArr[i] - 1 == Array.IndexOf(strArr, "i") ||
                    initArr[i] - 1 == Array.IndexOf(strArr, "d") ||
                    initArr[i] - 1 == Array.IndexOf(strArr, "h") ||
                    initArr[i] - 1 == Array.IndexOf(strArr, "j");
        }

        public static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            Console.Write("Enter the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int evenCounter = 0, oddCounter = 0, evenIndex = 0, oddIndex = 0, evenUpperCounter = 0, oddUpperCounter = 0;
            int[] arr = new int[n];
            int num;
            for (int i = 0; i < n; i++)
            {
                num = rnd.Next(1, 26);
                arr[i] = num;
                if (num % 2 == 0)
                {
                    evenCounter++;
                }
                else
                {
                    oddCounter++;
                }
            }

            int[] evenArr = new int[evenCounter];
            string[] evenLetterArr = new string[evenCounter];
            int[] oddArr = new int[oddCounter];
            string[] oddLetterArr = new string[oddCounter];

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[evenIndex] = arr[i];
                    evenIndex++;
                }
                else
                {
                    oddArr[oddIndex] = arr[i];
                    oddIndex++;
                }
            }

            for (int i = 0; i < evenCounter; i++)
            {
                if (IsFromList(evenArr, i, alphabet))
                {
                    evenLetterArr[i] = alphabet[evenArr[i] - 1].ToUpper();
                    evenUpperCounter++;
                }
                else
                {
                    evenLetterArr[i] = alphabet[evenArr[i] - 1];
                }
            }

            for (int i = 0; i < oddCounter; i++)
            {
                if (IsFromList(oddArr, i, alphabet))
                {
                    oddLetterArr[i] = alphabet[oddArr[i] - 1].ToUpper();
                    oddUpperCounter++;
                }
                else
                {
                    oddLetterArr[i] = alphabet[oddArr[i] - 1];
                }
            }

            if (evenUpperCounter > oddUpperCounter)
            {
                Console.WriteLine($"The first array has the most capital letters: {evenUpperCounter}");
            }
            else if (evenUpperCounter < oddUpperCounter)
            {
                Console.WriteLine($"The second array has the most capital letters: {oddUpperCounter}");
            }
            else
            {
                Console.WriteLine($"Both arrays has equal number of capital letters: {oddUpperCounter}");
            }

            Console.WriteLine();
            Console.WriteLine("First array:");
            Console.WriteLine(string.Join(" ", evenLetterArr));
            Console.WriteLine("Second array:");
            Console.WriteLine(string.Join(" ", oddLetterArr));
            Console.WriteLine();
        }
    }
}
