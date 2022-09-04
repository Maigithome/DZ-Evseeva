// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

int Sum(int m, int n)
{
    if (m == n) return n;
    return m + Sum(m + 1, n);
}
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N}: {Sum(M, N)}");


