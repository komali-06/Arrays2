using System;

namespace Sum
{
    class Program
    {
        static void Main()
        {
            try
            { 
            int sum = 0;
            Console.WriteLine("Please Enter an Array Values:");
            int[] array = new int[5];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(Console.In.ReadLine());
                }

                Console.WriteLine("Sum of an array elements:");
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            Console.WriteLine(sum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
