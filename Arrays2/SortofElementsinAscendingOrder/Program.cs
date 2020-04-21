using System;

namespace SortofElementsinAscendingOrder
{
    class Program
    {
        static void Main()
        {
            try
            {
                int[] array = new int[10];
                int i , temp = 0;
                Console.WriteLine("How many Elements You Want to Enter");
                int length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter an Array Values:");
                                       

                for (i = 0; i < length; i++)
                {
                    array[i] = Convert.ToInt32(Console.In.ReadLine());                                                
                }

                 Console.WriteLine("Sort of Elements in Ascending Order");
                for (i = 0; i < length; i++)
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
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
