// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// var m = int.Parse(Console.ReadLine());
// Console.WriteLine(string.Format("Число в 10-й системе = {0} ", m));

// string tmp = "";
// while (m > 0)
// {
//     tmp += m & 1;
//     m /= 2;
// }

// for (int i = tmp.Length - 1; i >= 0; i--)
// {
//     Console.Write(tmp[i]);
// }

// Console.WriteLine();

int m = int.Parse(Console.ReadLine());
Console.WriteLine(string.Join("", Convert.ToString(m, 2).Reverse()));
