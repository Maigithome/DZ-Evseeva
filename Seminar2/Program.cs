//  Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10,100);//[10;100) -> [10;99]
Console.WriteLine("Рандомное число: " + number);
// "/" - деление без остатка; "%" - взятие остатка
int firstDigit = number / 10;   // Первая цифра моего числа: 78 -> 7
int secondDigit = number % 10;  // Вторая цифра моего числа: 78 -> 8
int maximum = firstDigit;       // пусть максимум - первая цифра моего числа
if (maximum < secondDigit) maximum = secondDigit;

Console.WriteLine($"Максимальная цифра в числе {number} - это {maximum}" ); //Интерполяция



// int number = new Random().Next(100,1000);
// Console.WriteLine("Рандомное число: " + number);

// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру 
int firstDigit = number / 100; //firstDigit-первая цифра числа: 78-7
int secondDigit = number % 10; //secondDigit-вторая цифра числа:78-8
int digit = firstDigit * 10 + secondDigit;
Console.WriteLine(digit);

//1. String

string inputNumber = Console.ReadLine(); //"456"
Console.WriteLine(inputNumber[0]+ inputNumber[2]);

int number = new Random().Next(100, 1000); // [0;999]
int result = ((number/100) * 10) + number % 10;//456 -> 4, 456 % 10 -> 6

Console.WriteLine($"Исходное число: {number}, результат: {result}");




//Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 2 не кратно числу 1, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0) Console.WriteLine("кратно");
else Console.WriteLine("не кратно, остаток от деления равен: " + (number1 % number2));

int firstNumber = Convert.ToInt32(Console.ReadLine());   
int secondNumber = Convert.ToInt32(Console.ReadLine());  

if (firstNumber % secondNumber == 0) // остаток от деления = 0, числа кратные
{
    Console.WriteLine("кратно");
}
else Console.WriteLine($"Не кратно, остаток: {firstNumber % secondNumber}");



// /Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно");

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2 || number2 == number1 * number1) Console.WriteLine("Одно число является квадратом другого");
else Console.WriteLine("Ни одно из чисел не является квадратом другого");

int number = Convert.ToInt32(Console.ReadLine());   
// && - "И"
// or - "||" 
if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Кратно 7 и 23");
else Console.WriteLine("Не кратно 7 и 23");
