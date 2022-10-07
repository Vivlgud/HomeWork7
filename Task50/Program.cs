// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int[,] arr=FillArray(3,4,1,10);

Console.Write("Введите число для поиска в массиве ");
int foundNumber=Convert.ToInt32(Console.ReadLine());
int marker=0;
for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           if (foundNumber==arr[i,j])
           {
            Console.WriteLine($"Число {foundNumber} на ходится в элементе [{i},{j}]");
            marker=1;
           } 
        }
    }
if (marker==0) Console.WriteLine($"Число {foundNumber} нет в массиве");
PrintArray(arr);


