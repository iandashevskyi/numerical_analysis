using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СД_1._1
{
    public class Comb
    {
        public static int[] Sort(int[] array)
        {
            double shrinkFactor = 1.247;
            int step = array.Length - 1;
            while (step >= 1)
            {
                for (int i = 0; i + step < array.Length; i++)
                {
                    if (array[i] > array[i + step])
                    {
                        int temporary = array[i];
                        array[i] = array[i + step];
                        array[i + step] = temporary;
                    }
                }
                step = (int)(step / shrinkFactor);
            }
            return array;
        }

    }
}
