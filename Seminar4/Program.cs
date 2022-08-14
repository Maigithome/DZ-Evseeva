// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0; // sum = 0, тк суммы изначально нет
// // for(начало; условие; увеличение счетчика)
// for (int i = 1; i <= A; i++)
// {
//     sum += i; //sum = sum + i
// }

// Console.WriteLine($"Сумма элементов от 1 до {A} = {sum}");

// // или
// // 2. Через метод и цикл while
// int A = Convert.ToInt32(Console.ReadLine());
// // Метод - функция, которая создается собственноручно
// // тип_возращаемого_значения(int,string,double) NameOfMethod (params)
// // GetSumNumbers - PascalCase - только для методов
// int GetSumNumbers(int number)
// {
//     int sum = 0;
//     int start = 1;
//     while(start <= number)
//     {
//         sum += start;
//         start++;
//     }
//     return sum;
// }
// Console.WriteLine($"Сумма чисел от 1 до {A} = {GetSumNumbers(A)}");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. 456 -> 3 78 -> 2 89126 -> 5 
Console.Write("Введите любое число: ");
string inputNumber = Console.ReadLine(); 
Console.Write("В числе " + inputNumber.Length + " цифры");

// или
int number = Convert.ToInt32(Console.ReadLine());

int GetCountNumbers(int digit)
{
    int count = 0; // чисел 0
    while (digit > 0)
    {
        count++;
        digit /= 10;
    }
    return count;
}

Console.WriteLine(GetCountNumbers(number));


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 4 -> 24  5 -> 120 
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int N= A;

for (int i = 1; i <= A-1; i++ ) N=N*i;

Console.WriteLine($"Фаториал числа {A} = {N}");

// или

int number = Convert.ToInt32(Console.ReadLine());

int GetMultiply(int num)
{
    // [1;N]
    int result = 1; //умножение на 0 даст вам 0
    // 5! = 1*2*3*4*5
    for (int i = 2; i <= num; i++) // 1! = 1,
    {
        result *= i;
    }
    return result;
}
Console.WriteLine($"Произведение чисел от 1 до {number} = {GetMultiply(number)}");


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]
int length = 8;

int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0,2);
    Console.Write(array[i]);
}

// или

int[] GetBinaryArray(int size)
{
    int[] result = new int[size]; // size = 5; result = [0,0,0,0,0]
    for (int i = 0; i < result.Length; i++) // size = result.Length
    {
        //[min; max+1);
        result[i] = new Random().Next(2); //Если указано одно число, то вы идете от 0 до этого числа
    }
    return result;
}

int [] testArray = GetBinaryArray(8);
Console.WriteLine($"Результат: [ {String.Join("; ", testArray)} ]");

