using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class Program
    {
        
        static Random randomGenerator = new Random();
        static List<double> listOfDoubles = new List<double>();
        static void Main(string[] args)
        {
            MenuSystem mainmenu = new MenuSystem("Program");

            mainmenu.AddMenuItem("Randomise List of Doubles (10 values)", "TenDoubles", typeof(Program));
            mainmenu.AddMenuItem("Print List of Doubles", "PrintListOfDoubles", typeof(Program));
            mainmenu.AddMenuItem("Perform a bubble sort", "PerformBubble", typeof(Program));

            mainmenu.RunForever();
            Console.ReadKey();
        }

        public static void PerformBubble()
        {
            Console.WriteLine("Performing Bubble Sort...");
            MergeSort.Sort(listOfDoubles);
            Console.WriteLine("Sort Completed");
        }

        public static void TenDoubles()
        {
            Console.WriteLine("Populating list with random numbers ...");
            PopulateListWithRandomDoubles(10);
            Console.WriteLine("List populated");

        }

        static void PopulateListWithRandomDoubles(int size)
        {
            listOfDoubles.Clear();

            for (int i = 0; i < size; i++)
            {
                double twoDigItDouble = Double.Parse(randomGenerator.NextDouble().ToString("0.00000"));
                listOfDoubles.Add(twoDigItDouble);
            }
        }

        public static void PrintListOfDoubles()
        {
            Console.WriteLine("\n\nLIST PRINT: \n");

            for (int i = 0; i < listOfDoubles.Count;i++)
            {
                Console.WriteLine(" " + i + " " + listOfDoubles[i].ToString());
            }

            Console.WriteLine("\nEND \n");
        }
    }
}
