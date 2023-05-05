using System;

namespace bubblesort
{
    class program
    {
        static void Main(string[] args)
        {

            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int g = 0; g < arr.Length - 1; g++)
                {
                    if (arr[g] > arr[g + 1])
                    {
                        temp = arr[g];
                        arr[g] = arr[g+1];
                        arr[g+1] = temp;
                    }
                }
                Console.Write("{0} ", arr[i]);
            }
             Console.ReadKey();
        }
    }
}