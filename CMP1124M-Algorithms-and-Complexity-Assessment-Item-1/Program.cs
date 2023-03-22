using CMP1124M_Algorithms_and_Complexity_Assessment_Item_1;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace CMP1124M
{
    class Program
    {
        static void Main(string[] args)
        {
            // could i store the roads as objects and use a design pattern?
            // optimise by using params keyword? store as 2d list ?? 
            int[] Road_1 = Data.readFile("Road_1_256.txt");
            int[] Road_2 = Data.readFile("Road_2_256.txt");
            int[] Road_3 = Data.readFile("Road_3_256.txt");


            Console.WriteLine("Select Array \r\n " +
                                "1. Road_1_256 \r\n " +
                                "2. Road_2_256\r\n " +
                                "3. Road_3_256");
            
            int arrayInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick a sort \r\n " +
                                "1. Bubble Sort \r\n " +
                                "2. Selection Sort \r\n " +
                                "3. Insertion Sort");
            
            int sortInput = Convert.ToInt32(Console.ReadLine());


            try
            {
                switch (sortInput)
                {
                    case 1:
                        Console.WriteLine("Bubble Sort picked!");
                        Sort.bubbleSort(Road_1, true);

                        
                        break;
                    case 2:
                        Console.WriteLine("Selection Sort picked");
                        Sort.selectionSort(Road_1, true);

                        break;
                    case 3:
                        Console.WriteLine("Insertion Sort picked");
                        Sort.insertionSort(Road_1, true);
                        break;
                }
                
                
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }

            Data.outputIncrement(Road_1, 10);
        }
        


    }

}