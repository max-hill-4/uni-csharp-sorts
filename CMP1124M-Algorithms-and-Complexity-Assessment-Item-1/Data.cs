﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1124M_Algorithms_and_Complexity_Assessment_Item_1
{

    class Data
    {


        public static void outputIncrement(int[] data,int x)
        {
            int length = data.Length;
            // I dont like how it newlines.
            for (int i = 0; i < length - 1; i++)
            {
                if ((i != 0 ) && i % x == 0)
                {
                    Console.WriteLine(data[i]);
                }


            }



        }
        public static int[] readFile(string file)
        {
            List<int> list = new List<int>();
            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(Int32.Parse(line));
                }
                return list.ToArray();
            }


        }
    }
}