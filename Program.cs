using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива A[n]: ");
            int n = Convert.ToInt32(Console.ReadLine()), counter = 0, index = -1;
            int[] array_n = new int[n];
            
            Console.WriteLine("Вводите элементы массива (несколько элементов должны быть одинаковые): ");
            for (int i = 0; i < n; i++)
            {
                array_n[i] = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    if ((array_n[i] == array_n[j]) && (i != j))
                    {
                        counter++;
                        array_n[i] = 0;
                    }
                }
            }       
            if (counter == 0)
            {
                Console.WriteLine("Ошибка! В массиве нет одинаковых элементов!");
                Environment.Exit(0);
            }
            counter = 0;
            for (int i = 0; i < n; i++) if (array_n[i] != 0) counter++;
            int[] array_p = new int[counter];

            Console.Write("Массив A[p] состоящий из различных элементов массива A[n]: \n|");
            for (int i = 0; i < n; i++)
            {
                if (array_n[i] != 0)
                {
                    index++;
                    array_p[index] = array_n[i];
                    Console.Write(" " + array_p[index] + " |");
                }
            }
        }
    }
}