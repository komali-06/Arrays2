using System;

namespace CopyofArrayElements
{
    class Program
    {
        static void Main()
        {
            try
            { 
            int[] arraycopy = new int[5]; 
            Console.WriteLine("Please Enter an Array Values:");
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)         // user inputs to array
                array[i] = Convert.ToInt32(Console.In.ReadLine());
                if (arraycopy.Length == array.Length)
                {
                    Console.WriteLine("Copy of Array elements:");
                    for (int i = 0; i < arraycopy.Length; i++)
                    {
                        arraycopy[i] = array[i];
                        Console.WriteLine(array[i]);
                    }
                }
                else
                    Console.WriteLine("Lengths of arraycopy and array are not Equal");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
