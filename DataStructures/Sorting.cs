using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Sorting
    {
        //int[] ints = { 8,10,4,12};
        public static void BubbleSort(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }

            foreach(int x in array)
            {
                Console.WriteLine(x);
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int largestAt = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (array[j] > array[largestAt])
                    {
                        largestAt = j;
                    }
                }
                Swap(array, largestAt, i);
            }

            foreach (int x in array)
            {
                Console.WriteLine(x);
            }
        }

        public static void InsertionSort(int[] array)
        {
            //10,8,5,12
            for (int i = 1; i < array.Length; i++)
            {
                int curUnsorted = array[i];
                int j = 0;
                for (j = i; j > 0 && array[j - 1] > curUnsorted; j--)
                {
                    array[j] = array[j - 1];
                }

                array[j] = curUnsorted;
            
            }
            foreach (int x in array)
            {
                Console.WriteLine(x);
            }
        }


        private static void Swap(int[] array, int j, int k)
        {
            if (j == k)
                return;
            int temp = array[j];
            array[j] = array[k];
            array[k] = temp;
        }

        //public static void ShellSort(int[] array)
        //{
        //    int gap = 1;
        //    while (gap < array.Length / 3)
        //        gap = 3 * gap + 1;

        //    while (gap >= 1)
        //    {
        //        for (int i = gap; i < array.Length; i++)
        //        {
        //            for (int k = i; k >= gap && array[k] < array[k - gap]; k -= gap)
        //            {
        //                Swap(array, k, k - gap);
        //            }

        //        }
        //        gap /= 3;
        //    }
        //}

        //public static void MergeSort(int[] array)
        //{
        //    int[] aux = new int[array.Length];
        //    Sort(0, array.Length - 1);

        //    void Sort(int low, int high)
        //    {
        //        if (high <= low)
        //            return;

        //        int mid = (high + low) / 2;
        //        Sort(low, mid);
        //        Sort(mid + 1, high);
        //        Merge(low, mid, high);
        //    }

        //    void Merge(int low, int mid, int high)
        //    {
        //        if (array[mid] <= array[mid + 1])
        //            return;

        //        int i = low;
        //        int k = mid + 1;

        //        Array.Copy(array, low, aux, low, high - low + 1);

        //        for (int k = low; l <= high; l++)
        //        {
        //            if (i > mid) array[l] = aux[k++];
        //            else if (k > high)
        //                array[l] = aux[i++];
        //            else if (aux[k] < aux[i])
        //                array[l] = aux[k++];
        //            else
        //                array[l] = aux[i++];
        //        }
        //    }
        //}

        public static void quicksort(int[] array)
        {
            sort(0, array.Length - 1);

            void sort(int low, int high)
            {
                if (high <= low)
                    return;
                int k = partition(low, high);
                sort(low, k - 1);
                sort(k + 1, high);
            }

            int partition(int low, int high)
            {
                int i = low;
                int k = high + 1;

                int pivot = array[low];
                while (true)
                {
                    while (array[++i] < pivot)
                    {
                        if (i == high)
                            break;
                    }

                    while (pivot < array[--k])
                    {
                        if (k == low)
                            break;
                    }

                    if (i >= k)
                        break;

                    Swap(array, i, k);
                }
                Swap(array, low, k);
                return k;
            }
        }

    }
}
