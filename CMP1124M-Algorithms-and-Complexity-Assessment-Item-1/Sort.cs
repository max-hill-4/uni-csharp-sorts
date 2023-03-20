using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1124M_Algorithms_and_Complexity_Assessment_Item_1
{
    class Sort
    {
        public static int[] bubbleSort(int[] newData)
        {
            int[] data = newData;
            int length = data.Length;
            for (int i = 0; i < length - 1; i++)
                for (int j = 0; j < length - i - 1; j++)
                    if (data[j] > data[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
            return data;
        }


    }
}
