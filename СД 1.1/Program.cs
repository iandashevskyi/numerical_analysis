using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СД_1._1
{
    public class Program
    {
        public static int arrayLength = 20;
        public static int[] array = Generate(arrayLength);
        public static void Main(string[] args)
        {
            Console.WriteLine("1 = comb\n2 = quick\n3 = selection");
            string choice = Console.ReadLine();

            Console.WriteLine("Исходный массив(расческа):");
            Output(array);

            switch (choice)
            {
                case "1":
                    array = Comb.Sort(array);
                    Console.WriteLine("Отсортированный массив(расческа):");
                    Output(array);
                    break;
                case "2":
                    array = Quick.Sort(array, Quick.low, Quick.high);
                    Console.WriteLine("Отсортированный массив(быстрая):");
                    Output(array);
                    break;
                case "3":
                    array = Selection.Sort(array);
                    Console.WriteLine("Отсортированный массив(выбором)");
                    Output(array);
                    break;
            }         

            
        }
        public static int[] Output(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            return array;
        }
        public static int[] Generate(int arrayLength)
        {
            Random rnd = new Random();
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                int j = rnd.Next((int)(Math.Pow(10, 6)) / 2);
                array[i] = j;                
            }
            return array;
        }

    }
}
