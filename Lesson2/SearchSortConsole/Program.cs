using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SearchSortConsole;

namespace SearchSortConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = { 7, 19, 5, -6, 0, 7, 3, 12, 11, -3 };
            Console.WriteLine("the initial array");
            Tools.PrintAllInArray(Tools.InsertSort(myIntArray));
            Console.WriteLine(Tools.BubbleSort(myIntArray));
            Console.WriteLine(Tools.SelectionSort(myIntArray));

        }
    }
}
