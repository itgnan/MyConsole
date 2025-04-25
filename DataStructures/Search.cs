using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Search
    {

       public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                // Check if target is present at mid
                if (arr[mid] == target)
                    return mid;
                // If target is greater, ignore left half
                if (arr[mid] < target)
                    left = mid + 1;
                // If target is smaller, ignore right half
                else
                    right = mid - 1;
            }
            // If target is not found in array
            return -1;
        }

       public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i; // Return the index if target found
            }
            return -1; // Return -1 if target not found
        }

    }
}
