using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonAlgorithms
{
    public class BinarySearch
    {
        public static int IndexOf(int[] collection, int target)
        {
            int low = 0, high = collection.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (target == collection[mid]) return mid;

                else if (target < collection[mid])
                {
                    high = mid - 1;
                }

                else
                {
                    low = mid + 1;
                }
            }

            // target doesn't exist in the array
            return -1;
        }
    }
}
