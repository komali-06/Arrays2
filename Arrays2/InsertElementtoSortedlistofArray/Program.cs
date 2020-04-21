using System;
using System.Collections;

namespace InsertElementtoSortedlistofArray
{
    class Program
    {
        static void Main()
        {
            try
            {
                int[] array = new int[10];
                int i, position = 0;
                Console.WriteLine("How many Elements You Want to Enter");
                int length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter an Array Values:");
                

                for (i = 0; i < length; i++)
                {
                    array[i] = Convert.ToInt32(Console.In.ReadLine());
                }

                Console.WriteLine("which element you want to enter");
                int inputvalue = Convert.ToInt32(Console.ReadLine());

                for (i = 0; i < length; i++)
                { 
                    if (inputvalue < array[i])
                    {
                        position = i;
                        break;
                    }
                }

                for (i = length; i >= position; i--)
                {      
                    array[i] = array[i - 1];
                }
                array[position] = inputvalue;
                      
                        
                Console.WriteLine("After inserting Element into an array:");

                for (i = 0; i <= length; i++)
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
