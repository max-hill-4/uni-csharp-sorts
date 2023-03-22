using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1124M_Algorithms_and_Complexity_Assessment_Item_1
{

    class Data
    {
        public static int[] Road_1 = readFile("Road_1_256.txt");
        public static int[] Road_2 = readFile("Road_2_256.txt");
        public static int[] Road_3 = readFile("Road_3_256.txt");

        public static int[] Road_1_2048 = readFile("Road_1_2048.txt");
        public static int[] Road_2_2048 = readFile("Road_2_2048.txt");
        public static int[] Road_3_2048 = readFile("Road_3_2048.txt");

        public static int[] pickArray(int array)
        {
            try
            {

                switch (array)
                {
                    case 1: return Road_1;
                    case 2: return Road_2;
                    case 3: return Road_3;
                    case 4: return Road_1_2048;
                    case 5: return Road_2_2048;
                    case 6: return Road_3_2048;
                }
            }
            catch
            {
                Console.WriteLine("File not found, picking Road_1");
            }
            // If an array is not picked, Road 1 will be picked by defualt.
            return Road_1;
        }
        public static void outputIncrement(int[] data,int x)
        {
            int length = data.Length;
            // I dont like how it newlines.
            for (int i = 0; i < length - 1; i++)
            {
                if ((i != 0 ) && (i % x == 0))
                {
                    Console.WriteLine(data[i-1]);
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
