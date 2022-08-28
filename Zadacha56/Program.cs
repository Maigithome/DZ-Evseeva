// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 10));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}

Console.WriteLine();

int[] sum = new int[m];
int index = 0;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sum[i] += array[i, j];
    }
}

int temp = int.MaxValue;

for (int i = 0; i < n; i++)
{
    if (temp > sum[i])
    {
        temp = sum[i];
        index = i;
    }
    
}
Console.Write($"Минимальная сумма элементов строк {temp}, номер строки {index + 1}");
