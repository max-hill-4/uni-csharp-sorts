using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I should probably have pick array as a serperate fcuntion!!!! in menu pick so
//thati can have merge work cleaner! fix TD::

namespace CMP1124M_Algorithms_and_Complexity_Assessment_Item_1
{
    class Menu
    {
        int[] array;
        public Menu()
        {
            try
            {
                Console.WriteLine("Welcome to my A%C Assesment! \r\n ");

                Console.WriteLine("Select an Array to use \r\n " +
                                    "1. Road_1_256 \r\n " +
                                    "2. Road_2_256\r\n " +
                                    "3. Road_3_256\r\n\r\n " +
                                    "4. Road_1_2048\r\n " +
                                    "5. Road_2_2048\r\n " +
                                    "6. Road_3_2048");


                int arrayInput = Convert.ToInt32(Console.ReadLine());
                array = Data.pickArray(arrayInput);
                Console.WriteLine("Choose functionality \r\n " +
                                    "1. Sort \r\n " +
                                    "2. Search\r\n " +
                                    "3. Output increments of n\r\n " +
                                    "4. Merge\r\n " +
                                    "5. Quit");
                
                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        menuSort();
                        break;
                    case 2:
                        menuSearch();
                        break;
                    case 3:
                        menuOutput();
                        break;
                    case 4:
                        menuMerge();
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Somethings gone wrong. Try Again.");
            }
            Console.WriteLine("Operation has been completed");
            new Menu();
        }
        private void menuSort()
        {
            Console.WriteLine("Pick a sort \r\n " +
                            "1. Bubble Sort \r\n " +
                            "2. Selection Sort \r\n " +
                            "3. Insertion Sort");

            int sortInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ascending or Decending \r\n " +
                            "1. Ascending Sort \r\n " +
                            "2. Decending Sort \r\n ");

            bool ascInput = (Console.ReadLine() == "1");
            Sort sort = new Sort(array, sortInput, ascInput);
        }

        private void menuSearch()
        {
            Console.WriteLine("Pick a search \r\n " +
                                   "1. Linear \r\n " +
                                   "2. Binary \r\n ");

            int searchtypeInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("For what Value \r\n ");

            int searchInput = Convert.ToInt32(Console.ReadLine());
            List<int> results = Search.linearSearch(array, searchInput);
            if (results != null)
            {
                Console.WriteLine("Value not found, Found closest Integer \r\n ");
                results = Search.findClosest(array, searchInput);
            }
      
            foreach (int i in results)
            {
                Console.WriteLine("Found Integer "+ array[i] + " at index: " + i);
            }
            
        }

        private void menuOutput() 
        {
            Console.WriteLine("Pick an increment");

            int sortInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Values:\r\n");
            Data.outputIncrement(array, sortInput);
        }

        private void menuMerge()
        {
            Console.WriteLine("Select an Array to merge with \r\n " +
                                    "1. Road_1_256 \r\n " +
                                    "2. Road_2_256\r\n " +
                                    "3. Road_3_256\r\n\r\n " +
                                    "4. Road_1_2048\r\n " +
                                    "5. Road_2_2048\r\n " +
                                    "6. Road_3_2048");


            int arrayInput = Convert.ToInt32(Console.ReadLine());
            array = array.Concat(Data.pickArray(arrayInput)).ToArray();
            menuOutput();

        }
    }
}

