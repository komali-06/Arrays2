using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter an array Values:");
                int[] array = new int[10];
                for (int i = 0; i < array.Length; i++)
                {
                array[i] = Convert.ToInt32(Console.In.ReadLine());
                }
                Console.WriteLine("Array Values are:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
              Console.ReadLine();

        }
    }
}
