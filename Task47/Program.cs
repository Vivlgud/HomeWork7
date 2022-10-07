// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.Write("Введите количество столбцов ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк ");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[,] array=new double[m,n];
int rnd;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        //реализация отрицательных и положительных результатов
        rnd=new Random().Next(-1,2)*10+1; 
        
        array[i,j]=Math.Round(new Random().NextDouble()*rnd,1);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i,j]}  ");
    }
    Console.WriteLine();
}