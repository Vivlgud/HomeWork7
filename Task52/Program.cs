// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

    int[,] FillArray(int rows, int columns, int min, int max)
    {
        int[,] array=new int[rows,columns];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j]=new Random().Next(min,max);
                }
        }
        return array;
    }

    void PrintArray(int[,] array)
    {
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]}  ");
            }
            Console.WriteLine();
        }
    }

int[,] arr=FillArray(4,10,1,10);

PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Средннее арифметическое каждого столбца ");
double mean=0;
for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
           mean+=arr[i,j];
        }
        mean=Math.Round(mean/arr.GetLength(0),1);
        Console.Write(mean+"; ");
        mean=0;
    }

