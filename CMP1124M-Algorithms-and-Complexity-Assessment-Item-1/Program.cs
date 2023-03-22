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

            
            Menu menu = new Menu();
            Sort sort = new Sort(Road_1, menu.sortInput, menu.ascInput);
            foreach (int i in Search.linearSearch(Road_1, 5))
            {
                Console.WriteLine(i);
            }
            //Data.outputIncrement(Road_1, 10);
        }
        


    }

}