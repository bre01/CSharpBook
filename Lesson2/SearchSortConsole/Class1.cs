using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchSortConsole
{
    public static class Tools
    {
        public static void PrintAllInArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
        public static int Search(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (target == array[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public static int[] InsertSort(int[] array)
        {
            //sort args and return the sorted array

            {
                //insertion sort
                int[] sortedArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    sortedArray[i] = array[i];
                }
                int j = 0;
                for (int i = 1; i < sortedArray.Length; i++)
                {
                    j = i;
                    while (j > 0 && sortedArray[j - 1] > sortedArray[j])
                    {
                        int temp = sortedArray[j];
                        sortedArray[j] = sortedArray[j - 1];
                        sortedArray[j - 1] = temp;
                        j--;
                    }
                }
                return sortedArray;
            }
        }
            public static int[] SelectionSort(int[] array)
            {
                //selection sort
                int[] sortedArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    sortedArray[i] = array[i];
                }
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    int min = sortedArray[i];
                    int minIndex = i;
                    for (int j = i + 1; j < sortedArray.Length; j++)
                    {
                        if (sortedArray[j] < min)
                        {
                            min = sortedArray[j];
                            minIndex = j;
                        }
                    }
                    int temp = sortedArray[i];
                    sortedArray[i] = min;
                    sortedArray[minIndex] = temp;
                }
                return sortedArray;
            }
            public static int[] BubbleSort(int[] array)
            {
                //bubble sort
                int[] sortedArray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    sortedArray[i] = array[i];
                }
                bool swapped = true;
                while (swapped)
                {
                    swapped = false;
                    for (int i = 0; i < sortedArray.Length - 1; i++)
                    {
                        if (sortedArray[i] > sortedArray[i + 1])
                        {
                            int temp = sortedArray[i];
                            sortedArray[i] = sortedArray[i + 1];
                            sortedArray[i + 1] = temp;
                            swapped = true;
                        }
                    }
                }
                return sortedArray;
            }
            public static int BinSearch(int[] array,int target)
        {
            //use binary search to search target in array

        }
        }
}
