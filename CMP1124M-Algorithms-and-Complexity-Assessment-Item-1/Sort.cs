﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1124M_Algorithms_and_Complexity_Assessment_Item_1
{
    class Sort
    {
        public static int[] bubbleSort(int[] data, bool asc)
        {
            int length = data.Length;
            // Iterate for each element in the array
            for (int i = 0; i < length - 1; i++)
                // Prev elements for 'i' are correct
                for (int j = 0; j < length - i - 1; j++)
                    
                    // There must be a nicer way to do this!
                    if (asc){

                        if (data[j] > data[j + 1])
                        {
                            (data[j], data[j + 1]) = (data[j + 1], data[j]);
                        }
                    else
                    { 
                        if (data[j] < data[j + 1])
                        {
                            (data[j], data[j + 1]) = (data[j + 1], data[j]);
                        }
                    }
                    }
            return data;
        }
        public static int[] selectionSort(int[] data, bool asc) 
        {
            int length = data.Length;

            for (int i = 0; i < length - 1; i++)
            {
                int smallest = i;
                for (int y = i + 1; y < length; y++)
                {
                    //If current data is less than smallest update
                    if (asc)
                    {
                        if (data[y] < data[smallest])
                        {
                            smallest = y;
                        }
                    }
                    else
                    {
                        if (data[y] > data[smallest])
                        {
                            smallest = y;
                        }

                    }
                }
                // Swap values
                (data[smallest], data[i]) = (data[i], data[smallest]);
            }

            return data;
        }

    }
}
