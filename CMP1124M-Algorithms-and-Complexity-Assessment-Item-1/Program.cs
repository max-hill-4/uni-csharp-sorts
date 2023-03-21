using CMP1124M_Algorithms_and_Complexity_Assessment_Item_1;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace CMP1124M
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Road_1 = Data.readFile("Road_1_256.txt");
            int[] Road_2 = Data.readFile("Road_2_256.txt");
            int[] Road_3 = Data.readFile("Road_3_256.txt");


            Console.WriteLine("Pick a sort \r\n " +
                                "1. Bubble Sort \r\n " +
                                "2. Selection Sort");
            int userInput = Convert.ToInt32(Console.ReadLine());


            try
            {
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Bubble Sort picked!");
                        Sort.bubbleSort(Road_1, false);
                        break;
                    case 2:
                        Console.WriteLine("Selection Sort picked");
                        Sort.selectionSort(Road_1, false);
                        break;
                }

            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
        }
        


    }

}