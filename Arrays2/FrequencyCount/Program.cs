using System;

namespace FrequencyCount
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10];
            int[] array2 = new int[10];
            int count ;
            Console.WriteLine("How many Values You Want to Enter ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter array Values:");
            

            for (int i = 0; i < length; i++) //user inputs to array
            {
                array[i] = Convert.ToInt32(Console.In.ReadLine());
                array2[i] = -1;
            }

            for (int i = 0; i < length; i++)
            {
                count = 1;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        array2[j] = 0;                        
                    } 
                }

                if (array2[i] != 0)
                {
                    array2[i] = count;
                }                
            }
            
            for (int i =0; i<length;i++)
            {
                if (array2[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", array[i], array2[i]);
                }
            }
            Console.ReadLine(); 
        }
    }
}
