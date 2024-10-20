using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СД_1._1
{
    public class Quick
    {
        public static int low = 0;
        int[] array = Program.Generate(Program.arrayLength);
        public static int high = Program.arrayLength - 1;
        public static int[] Sort(int[] array, int low, int high) 
        {


            if (low < high)
            {
                int p = Partiation(array, low, high);
                Sort(array, low, p - 1);
                Sort(array, p + 1, high);
            }
            return array;
        }

        public static int Partiation(int [] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;
            
            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }

            }
            Swap(array, i + 1, high);
            return i + 1;
        }
        public static void Swap(int[] array, int p1, int p2)
        {
            int temp = array[p1];
            array[p1] = array[p2];
            array[p2] = temp;
        }

    }
}
