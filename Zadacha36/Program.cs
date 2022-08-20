// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[5];
int i = 0;
int arraySize = array.Length; 
while (i < arraySize)
{
    array[i] = new Random().Next(-99, 100);
    i++;
}
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");

int sum = 0;

for (int j = 0; j < arraySize; j++)
        {
            if (j % 2 != 0)
            sum = sum + array[j];
                
        }
Console.WriteLine($"Сумма элементов с нечетными номерами: {sum}");