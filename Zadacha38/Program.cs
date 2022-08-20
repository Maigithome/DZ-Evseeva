// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = new double[5];
int i = 0;
int arraySize = array.Length;
while (i < arraySize)
{
    array[i] = new Random().NextDouble();
    i++;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

double max = array[0];
double min = array[0];

for (int j = 0; j < arraySize; j++)
{
    if (array[j] > max) max = array[j];
    if (array[j] < min) min = array[j];
}
Console.WriteLine($"Максимальное чило {max}, минимальное число {min}, разница {max-min}");