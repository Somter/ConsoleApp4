using System;

namespace CSharpApplication.one_dimensional_array
{
    class MainClass
    {
        static void Main()
        {

            try
            {
                Random rand = new();
                int[] arr = new int[10];

                Console.Write("Исходный массив: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(0, 5);
                    Console.Write("{0,2}", arr[i]);
                }
                Console.WriteLine();

                int newSize = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != 0)
                    {
                        arr[newSize] = arr[i];
                        newSize++;
                    }
                }

                for (int i = newSize; i < arr.Length; i++)
                {
                    arr[i] = -1;
                }

                Console.Write("Вывод: ");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0, 2}", arr[i]);
                }

            }
            catch (Exception ex) 
            {
               Console.WriteLine(ex.Message);
            }




        }
    }
}

