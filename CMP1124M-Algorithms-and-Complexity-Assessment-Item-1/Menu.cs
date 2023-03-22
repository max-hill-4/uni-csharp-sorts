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
        public int searchInput;
        public int menu;
        public Menu()
        {
            try
            {
                Console.WriteLine("Welcome to my A%C Assesment! \r\n ");

                Console.WriteLine("Select an Array to use \r\n " +
                                    "1. Road_1_256 \r\n " +
                                    "2. Road_2_256\r\n " +
                                    "3. Road_3_256");

                arrayInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose functionality \r\n " +
                                    "1. Sort \r\n " +
                                    "2. Search\r\n " +
                                    "3. Output increments of n");
                menu = Convert.ToInt32(Console.ReadLine());

                switch(menu)
                {
                    case 1:
                        Console.WriteLine("Pick a sort \r\n " +
                                    "1. Bubble Sort \r\n " +
                                    "2. Selection Sort \r\n " +
                                    "3. Insertion Sort");

                        sortInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ascending or Decending \r\n " +
                                    "1. Ascending Sort \r\n " +
                                    "2. Decending Sort \r\n ");

                        ascInput = (Console.ReadLine() == "1");
                        break;
                    
                    case 2:
                        Console.WriteLine("Pick a search \r\n " +
                                    "1. Linear \r\n " +
                                    "2. Binary \r\n ");

                        searchInput = Convert.ToInt32(Console.ReadLine());
                        break;

                }

                

                
                

                
            
            }
            catch
            {
                Console.WriteLine("Somethings gone wrong. Try Again.");
                new Menu();
            }
            

        }
    }
}
