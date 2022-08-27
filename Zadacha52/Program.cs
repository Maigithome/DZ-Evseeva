// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
int [,]array=new int [m, n];
double []sum=new double [n];

for (int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
        array[i, j] = new Random().Next(0, 10);

        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        sum[i] += array[j, i];
    }
}

for (int i=0; i<n; i++)
{
    Console.Write(Convert.ToDouble(Math.Round(sum[i] / m,2))  + "; ");
}
Console.ReadLine();

