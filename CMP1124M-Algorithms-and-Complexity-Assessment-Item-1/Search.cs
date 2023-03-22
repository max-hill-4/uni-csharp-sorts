using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1124M_Algorithms_and_Complexity_Assessment_Item_1
{
    class Search
    {
        public static int linearSearch(int[] data, int x)
        {
            int length = data.Length;
            for (int i = 0; i < length; i++)
                if (data[i] == x)
                    return i;
            return -1;

        }
        public static int binarySearch(int[] data, int x) 
        {
            int length = data.Length;
            int low = 0;
            int high = length - 1 ;
            
            
            while (low != high)
            {
                int mid = (low + high) / 2 ;
                if (data[mid] == x)
                {
                    return mid;
                }
                else if (x > data[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
                
            }
            return -1;
        }
    }
}
