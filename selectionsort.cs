using System;

namespace selectionsort
{
    class Selectionsort
    {

        static void PrintArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                System.Console.WriteLine(nums[i]);
            }
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];

            arr[i] = arr[j];

            arr[j] = temp;
        }

        static int FindSmallestValue(int[] nums, int start)
        {
            int smallestNumPos = start - 1;

            for (int i = start; i < nums.Length; i++)
            {
                if (nums[i] < nums[smallestNumPos])
                {
                    smallestNumPos = i;
                }
            }

            return smallestNumPos;
        }

        static void Sort(int[] nums)
        {
            // _ amarilla 0 -> penúltima
            // flechas amarillas: _ + 1 -> última posición

            //Penúltima posición = ?
            // nums.Length => 9
            // última posición => 8
            // penúltima posición => 7

            for (int i = 0; i < nums.Length - 1; i++)
            {
                int smallestNumPos = FindSmallestValue(nums, i + 1);
                if (i != smallestNumPos)
                {
                    //Swap values / Intercambiar valores
                    Swap(nums, i, smallestNumPos);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] nums = new int[]{6, 2, 20, 5, 4, 4, 3, 2, 9};

            System.Console.WriteLine("Antes de ordernar:");
            PrintArray(nums);
            //Ordenar
            Sort(nums);

            System.Console.WriteLine("\n");

            System.Console.WriteLine("Después de ordernar:");
            PrintArray(nums);

        }
    }
}