using System;

namespace ReverseOrder
{
    class Program
    {
        static void Main()
        {
            try
            { 
                int i;
                Console.WriteLine("How many Elements You Want to Enter");
                int size = Convert.ToInt32(Console.ReadLine()); 

                Console.WriteLine("Please Enter an Array Values:");
                int[] array = new int[size];

                for (i = 0; i < size; i++)
                { 
                array[i] = Convert.ToInt32(Console.In.ReadLine());
                }

                Console.WriteLine("Reverse order of array:");

                for (i = size - 1; i >= 0; i--)
                {
                    Console.WriteLine(array[i]);
                    size--;
                }

                //Array.Reverse(array);
                for (i = 0; i < size; i++)
                { 
                Console.WriteLine(array[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
