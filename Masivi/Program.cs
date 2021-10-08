using System;

namespace Masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-ва задача

            /*Console.Write("Въведете число: ");
            int number = int.Parse(Console.ReadLine());
            int numberr;
            int sum = 0;
            int temp = number;

            while (number > 0)
            {
                numberr = number % 10;
                sum = (sum * 10) + numberr;
                number = number / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("Числото {0} е палиндром.",temp);
            }
            else
            {
                Console.WriteLine("Числото {0} не е палиндром",temp);
            }*/

        }
    
        static void SecondBiggestNumber()
        {
            // 2-ра задачаа

            /*int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

            int index = 0;
            int value = nums[index];

            for (int i = 1; i < nums.Length; i++)
            {
                if (value < nums[i])
                {
                    value = nums[i];
                    index = i - 1;
                }
            }

            Console.WriteLine("\nНай-голяма стойност: " + value);
            Console.WriteLine("\nВтора най-голяма стойност: " + nums[index]);*/
        }
        static void DoublingTheEven()
        {
            // З-та задача

            /*int[] nums = new int[] { 2, 4, 6, 17, 33, 11 };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine("\n");

            foreach (int n in nums)
            {
                Console.WriteLine("Числото {0} е {1}", n, n % 2 == 0 ? "четно" : "нечетно");
                if (n % 2 == 0)
                {
                    int s = n * 2;
                    Console.WriteLine("Числото {0} * 2 е равно на {1}", n, s);
                }
            }*/
        }
        static void SortedArray()
        {
            // 4-та задача

            /*int[] arr = new int[] { 11, 33, 17, 66, 21, 77 };
            int n = arr.Length;
            if (arraySortedOrNot(arr, n) != 0)
            {
                Console.WriteLine("Масивът е сортиран");
            }

            else
            {
                Console.WriteLine("Масивът не е сортиран");
            }*/
        }
        static int arraySortedOrNot(int[] arr, int n)
        {
            // 4-та задача (останалата част)

            /*if (n == 1 || n == 0)
            {
                return 1;
            }

            if (arr[n - 1] < arr[n - 2])
            {
                return 0;
            }

            return arraySortedOrNot(arr, n - 1);*/
        }
        static void SequenceOfElements()
        {
            // 5-та задача

            /*int count = 1;
            int tempCount = 1;
            int number = 0;

            Console.Write("Въведете дължината на масива: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Въведете {0} елемент: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i] == arr[i + 1])
                {
                    tempCount++;
                }
                else
                {
                    tempCount = 1;
                }

                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[i];
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write("{0}; ", number);
            }*/
        }

    }
}
