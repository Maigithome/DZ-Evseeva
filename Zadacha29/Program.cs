// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int length = 8;

int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0,10);
}   

 Console.WriteLine($"Результат: [ {String.Join("; ", array)} ]");