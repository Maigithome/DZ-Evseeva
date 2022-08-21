// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] array = { 0, 7, 8, -2, -2 };
int j = 0;
int arraySize = array.Length;
int count = 0;
Console.WriteLine($"Array: [ {String.Join("; ", array)} ]");
for (j = 0; j < arraySize; j++)
{
    if (array[j] > 0) count++;
}
Console.WriteLine($"Чисел больше нуля - {count}");