// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];

int i = 0;
int count =0;
int arraySize = array.Length; 
while (i < arraySize)
{
    array[i] = new Random().Next(100, 1000);
    i++;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

for (i = 0; i < arraySize; i++)
{
    if (array[i]%2==0) count++;
}
Console.WriteLine($" {count}");