using System;
namespace ConsoleApp39
{
    class Program
    {
        static void Main()
        {
            int n=0, m=0;
            try
            {
                Console.WriteLine("введите кол-во строк ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 1)
                {
                    throw new Exception("не корректно введены данные строк матрицы");
                }
                Console.WriteLine("введите кол-во столбцов ");
                m = Convert.ToInt32(Console.ReadLine());
                if ( m <= 1 || n != m)
                {
                    throw new Exception("не корректно введены данные столбцов матрицы или матрица должна быть квадратной");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                p();
                return;
            }
            int[,] array = new int[n, m];//а если 2*2
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == j)
                        array[i, j] = i;
                    else if ((i + j + 1) == n)
                        array[i, j] = j;

                    else array[i, j] = 0;
                    Console.Write(array[i, j] + "    ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();




            void p()
            {
                Console.WriteLine("повторить ввод если да то 1 нет то 0");
                string y = Convert.ToString(Console.ReadLine());
                if (y == "1")
                    Main();
                else
                    return;
            }
            p();
            return;
        }
    }
}



