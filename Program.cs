using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 100];
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int y = 10 * i + 1 + j;
                    array[j, i] = y;
                }
            }

            int[,] newArray = new int[250, 4];
            int k = 0;
            int newIndex = 0;
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 100; i++)
                {
                    newArray[newIndex, k] = array[j, i];
                    k++;
                    if ((i + 1) % 4 == 0)
                    {
                        k = 0;
                        newIndex++;
                    }
                }
            }

            SortedList sl = new SortedList();

            for (int n = 0; n < newIndex; n++)
            {
                string temp = "";
                string sortedTemp = "";
                for (int m = 0; m < 4; m++)
                {
                    temp += newArray[n, m].ToString("d4") + " ";
                    if (m == 0)
                        sortedTemp = newArray[n, m].ToString("d4") + " ";
                }
                sl.Add(sortedTemp, temp);

                temp = "";
                sortedTemp = "";
            }

            ICollection key = sl.Keys;
            foreach (string s in key)
            {
                Console.WriteLine(s + ": " + sl[s]);
            }
        }
    }
}
