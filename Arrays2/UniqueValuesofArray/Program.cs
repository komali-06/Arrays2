using System;

namespace UniqueValuesofArray
{
    class Program
    {
        static void Main()
        {
            try
            {
                int[] array = new int[10];
                int i, count = 0;
                Console.WriteLine("Howmany Elements you want to Enter");
                int length = Convert.ToInt32(Console.ReadLine());              
                
                Console.WriteLine("Please Enter an Array Values:");
                for (i = 0; i < length; i++) // User input Values to array
                {
                    array[i] = Convert.ToInt32(Console.In.ReadLine());                    
                }

                Console.WriteLine("Unique values are:");
                for (i = 0; i < length; i++)
                {
                    count = 0;
                    for (int j = 0; j < i - 1; j++)
                    {
                        if (array[i] == array[j])
                        {
                            count++;                                                         
                        }
                    }
                    for (int k = i + 1; k < length; k++)
                    {
                        if (array[i] == array[k])
                        {
                            count++;
                        }

                        if(array[i] == array[i + 1])
                        {
                            i++;
                        }
                    }  
                    
                   if (count == 0)
                    {
                        Console.WriteLine("{0}", array[i]);
                    }
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
