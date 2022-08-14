// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int n = Convert.ToInt32(Console.ReadLine());

int res = 1;
for (int i = 1; i <= n; i++)
{
    res *= number;
}
// return res;

Console.WriteLine($"Результат возведения числа {number} в степень {n} равен {res}");