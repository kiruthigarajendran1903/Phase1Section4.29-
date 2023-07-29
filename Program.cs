using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._29
{
    internal class Program
    {
        public static void runApp(int[]arr)
        {
            int i, j, gap;
          int temp;
            gap = 3;
            while (gap > 0)
            {
                for (i = 0; i < arr.Length; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= gap) && (arr[j - gap] > temp))
                    {
                        arr[j] = arr[j - gap];
                        j = j - gap;
                    }
                    arr[j] = temp;
                }
                if (gap / 2 != 0)
                    gap = gap / 2;
                else if (gap == 1)
                    gap = 0;
                else
                    gap = 1;
            }
            Console.WriteLine("After Shell Sort");
            for (int z = 0; z < arr.Length; z++)
            {
                Console.WriteLine(arr[z]);
            }
        }


    


        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No of Elements");
            int n = int.Parse(Console.ReadLine());
            int[] Arr = new int[n];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < n; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Array Elements are");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Arr[i]);
            }

            runApp(Arr);
            Console.ReadKey();
        }
    }
}
