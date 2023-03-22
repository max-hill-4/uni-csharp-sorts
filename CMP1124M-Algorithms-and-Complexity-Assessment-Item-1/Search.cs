using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1124M_Algorithms_and_Complexity_Assessment_Item_1
{
    class Search
    {
        public static List<int> linearSearch(int[] data, int x)
        {
            List<int> locations = new List<int>();
            int length = data.Length;
            for (int i = 0; i < length; i++)
                if (data[i] == x)
                    locations.Add(i);
            return locations;

        }
        public static List<int> binarySearch(int[] data, int x) 
        {
            // It doesnt check for duplicates
            List<int> locations = new List<int>();
            int length = data.Length;
            int low = 0;
            int high = length - 1 ;
            int location = 0;
            
            while (low != high)
            {
                int mid = (low + high) / 2 ;
                if (data[mid] == x)
                {
                    location = mid;
                    locations.Add(mid);
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

            int left = location - 1;
            int right = location + 1;
            while (left == location)
            {
                locations.Add(left);
                left--;
            }
            while (right == location)
            {
                locations.Add(right);
                right++;
            }
            return locations;
        }
    }
}
