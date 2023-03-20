using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1124M_Algorithms_and_Complexity_Assessment_Item_1
{

    class Data
    {

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
