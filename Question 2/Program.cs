using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<int[], int> indexOfMin = (array) =>
            {
                if (array == null || array.Length == 0)
                    return -1; 

                int minIndex = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[minIndex])
                        minIndex = i;
                }
                return minIndex;
            };

            
            int[] array1 = new int[] { 12, 35, 10, 250, 12, -77, 35, 7, 9, 10 };
            int[] array2 = new int[] { 12, -5, 250, 17, 12, -5, 250, 35, 10 };

          
            int minIndex1 = indexOfMin(array1);
            int minIndex2 = indexOfMin(array2);

            Console.WriteLine("Index of the smallest element in array1: " + minIndex1);
            Console.WriteLine("Index of the smallest element in array2: " + minIndex2);
        }
    }
}
