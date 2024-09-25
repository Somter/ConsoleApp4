using System;

namespace CSharpApplication.one_dimensional_array
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                Random random = new Random();
                int rows = 5;
                int cols = 5;
                int[,] arr = new int[rows, cols];

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = random.Next(0, 100);
                    }
                }


                Console.WriteLine("Исходный массив: ");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write("{0,4}", arr[i, j]);
                    }
                    Console.WriteLine();
                }


                Console.WriteLine("Введите количество столбцов для сдвига:");
                int shift = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите направление сдвига (влево или вправо):");
                string dir = Console.ReadLine().ToLower();

                shift = shift % cols;

                if (dir == "влево")
                {
                    for (int i = 0; i < rows; i++)
                    {
                        int[] rowTm = new int[cols];

                        for (int j = 0; j < cols; j++)
                        {
                            rowTm[j] = arr[i, (j + shift) % cols];
                        }

                        for (int j = 0; j < cols; j++)
                        {
                            arr[i, j] = rowTm[j];
                        }
                    }
                }
                else if (dir == "вправо")
                {
                    for (int i = 0; i < rows; i++)
                    {

                        int[] rowTm = new int[cols];


                        for (int j = 0; j < cols; j++)
                        {
                            rowTm[(j + shift) % cols] = arr[i, j];
                        }

                        for (int j = 0; j < cols; j++)
                        {
                            arr[i, j] = rowTm[j];
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Написано же ВЛЕВО или ВПРАВО!.");
                    return;
                }

                Console.WriteLine("\nРезульт: ");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write("{0,4}", arr[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.ToString()); 
            }

        }
    }
}
