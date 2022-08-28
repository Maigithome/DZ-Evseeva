// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

for (var i = 0; i < array.GetLength(0); i++)
    for (var j = 0; j < array.GetLength(1); j++)
        for (var k = 0; k < array.GetLength(1); k++)
        {
            if (array[i, j] <= array[i, k]) continue;
            var temp = array[i, j];
            array[i, j] = array[i, k];
            array[i, k] = temp;
        }

for (var i = 0; i < array.GetLength(0); i++, Console.WriteLine())
    for (var j = 0; j < array.GetLength(1); j++)
    {
        Console.Write("{0,5}", array[i, j]);
    }

