using System;

namespace duplicateValuesCount
{
    class Program
    {
        static void Main()
        {
            try
            {
                int count = 0;
                int[] array = new int[100];
                int[] array1 = new int[100];
                int[] array2 = new int[100];
                int mark = 1;

                Console.WriteLine("How many Values You Want to Enter ");
                int length = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please Enter array Values:");
                                                                  

                for (int i = 0; i < length; i++) //user inputs to array
                array[i] = Convert.ToInt32(Console.In.ReadLine());

                for (int i = 0; i < length; i++)
                {
                    array1[i] = array[i];
                    array2[i] = 0;
                }

                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (array[i] == array1[j])
                        {
                           array2[j] = mark;
                            mark++;
                        }
                        
                    }
                    mark = 1;
                }
                for (int i = 0; i <length; i++)
                {
                    if (array2[i] == 2)
                    {
                        count++;
                    }
                }
                Console.WriteLine("duplicate values count =" + count);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
