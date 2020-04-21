using System;

namespace MaximumandMinimumElement
{
    class Program
    {
        static void Main()
        {
            //int i, MaximumElement = 0, MinimumElement = 0;
            int i;
            Console.WriteLine("Howmany Elements You Want to Enter");

            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter an Array Values:");

            int[] array = new int[size];

            for (i = 0; i < size; i++)
            { 
                array[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            int max = array[0];
            int min = array[0];
            for (i = 0; i < size; i++)
            {
                if(array[i] >max)
                {
                    max = array[i];
                }
                
                if(array[i]<min)
                {
                    min = array[i];
                }
                
            }

            //for (i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    { 
            //        if (array[i] > array[j])
            //        { 
            //        MaximumElement = array[i];
            //        MinimumElement = array[j];
            //        }
            //        else
            //        { 
            //        MaximumElement = array[j];
            //        MinimumElement = array[i];
            //        }

            //    }
            //}
            

            Console.WriteLine("Maximum Element is" + max);
            Console.WriteLine("Minimum Element is" + min);
            Console.ReadLine();
        }
    }
}
