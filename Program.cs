using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WorkShop.Net._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int[] arr = AddArray();
            //int dex = 0;

            //Console.Write("Enter a number To Serch: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == num)
            //    {
            //        dex = i;
            //    }
            //}

            //Sort(arr);

            //Console.WriteLine(dex);
            #endregion

            #region Q2
            //int[] arr = AddArray();

            //Console.WriteLine("Enter A New Size: ");
            //int size = int.Parse(Console.ReadLine());

            //int temp = arr.Length;

            //if (size > temp)
            //{
            //    int[] arr01 = new int[size];

            //    for (int i = 0; i < temp; i++)
            //    {
            //        arr01[i] = arr[i];
            //    }

            //    for (int i = temp; i < size; i++)
            //    {
            //        arr01[i] = -1;
            //    }

            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine(arr01[i]);
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}
            #endregion

            

        }
        #region Add Array
        public static int[] AddArray()
        {
            Console.Write("Enter a Size Of Array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter Index {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        #endregion

        #region Print Array
        public static void PrintArray(int[] arr)
        {
            int size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        #endregion

        #region Sort
        public static void Sort(int[] nums)
        {
            int n = nums.Length;
            int[] numbers = nums;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

        }


        #endregion
    }
}
