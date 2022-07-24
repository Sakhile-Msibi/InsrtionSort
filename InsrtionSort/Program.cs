using System;

namespace InsrtionSort
{
    class Program
    {
        public static int[] insertionSort(int[] A)
        {
            for(int j = 1; j < A.Length; j++)
            {
                int key = A[j];
                int i = j - 1;
                while(i >= 0 && A[i] > key)
                {
                    A[i + 1] = A[i];
                    i--;
                }
                A[i + 1] = key;
            }
            return A;
        }
        static void Main(string[] args)
        {
            int[] A = { 5, 2, 4, 6, 1, 3 };
            A = insertionSort(A);
            foreach(int item in A)
            {
                Console.WriteLine(item);
            }
        }
    }
}
