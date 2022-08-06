// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a, b, c;
        Console.Write("Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите третье число: ");
        c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("Максимальное число = ");
Console.WriteLine(max);
