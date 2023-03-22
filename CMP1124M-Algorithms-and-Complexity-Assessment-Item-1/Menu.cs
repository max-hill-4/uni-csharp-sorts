using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1124M_Algorithms_and_Complexity_Assessment_Item_1
{
    class Menu
    {
        public int arrayInput;
        public int sortInput;
        public bool ascInput;

        public Menu()
        {
            try
            {

                Console.WriteLine("Select Array \r\n " +
                                    "1. Road_1_256 \r\n " +
                                    "2. Road_2_256\r\n " +
                                    "3. Road_3_256");

                arrayInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pick a sort \r\n " +
                                    "1. Bubble Sort \r\n " +
                                    "2. Selection Sort \r\n " +
                                    "3. Insertion Sort");

                sortInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a sort \r\n " +
                                    "1. Ascending Sort \r\n " +
                                    "2. Decending Sort \r\n ");

                ascInput = (Console.ReadLine() == "1");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
