using System;

namespace Arrays2
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please Enter an Array Values:");
                int[] array = new int[5];
                for (int i = 0; i < array.Length; i++)
                array[i] = Convert.ToInt32(Console.In.ReadLine());
                Console.WriteLine("Array Values are:");
                for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
