using System;

namespace UniqueElements
{
    class Program
    {
        static void Main()
        {
            int[] arraycopy = new int[5];
            Console.WriteLine("Please Enter an Array Values:");
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
                array[i] = Convert.ToInt32(Console.In.ReadLine());
            Console.WriteLine("Array elements:");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            if (arraycopy.Length == array.Length)
            {
                Console.WriteLine("Copy of Array elements:");
                for (int i = 0; i < arraycopy.Length; i++)
                {
                    arraycopy[i] = array[i];
                    Console.WriteLine(array[i]);
                }
            }
    }
}
