using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Algorithms.Algorithms
{
    internal class BinarySearch
    { 
        // this is recursive method (yinelemeli method)
        public static int Search(int[] array, int searchValue,int low,int high)
        {
            int median = (low + high) / 2;

            if (array[median] == searchValue)
            {
                return median;
            }
            else if (array[median] < searchValue)
            {
                return Search(array,searchValue, median + 1,high);
            }
            else if (array[median] > searchValue)
            {
                return Search(array, searchValue, median, high -1 );
            }

            return -1;
        }
    }
}
