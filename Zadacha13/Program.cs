﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string inputNumber = Console.ReadLine();

var number = int.Parse(inputNumber);

double digit = number/100;

if (digit < 1) Console.WriteLine("Третьей цифры нет");

else Console.WriteLine($"Третья цифра числа {inputNumber[2]}");


