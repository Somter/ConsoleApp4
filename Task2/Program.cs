using System;

namespace CSharpApplication.one_dimensional_array
{
    class MainClass
    {
        static void Main()  
        {
            try
            {


                int N = 7;
                int[,] arr = new int[N, N];
                int count = 1;

                int steps = 1;
                int y = N / 2;
                int x = N / 2;
                arr[y, x] = count++;

                while (steps < N)
                {
                    for (int i = 0; i < steps; i++)
                    {
                        x--;
                        arr[y, x] = count++;
                    }

                    for (int i = 0; i < steps; i++)
                    {
                        y++;
                        arr[y, x] = count++;
                    }

                    steps++;

                    for (int i = 0; i < steps; i++)
                    {
                        x++;
                        arr[y, x] = count++;
                    }

                    for (int i = 0; i < steps; i++)
                    {
                        y--;
                        arr[y, x] = count++;
                    }

                    steps++;
                }

                for (int i = 0; i < steps - 1; i++)
                {
                    x--;
                    arr[y, x] = count++;
                }
                Console.WriteLine("Результат: ");
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        Console.Write("{0, 4}", arr[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
