﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a, b;
        Console.Write("Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
            Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", a, b);
        else Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", b, a);