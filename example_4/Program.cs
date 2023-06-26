/* Задача №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Введи число a: ");
string a1 = Console.ReadLine();
int a = Convert.ToInt32(a1);
Console.Write("Введи число b: ");
string b1 = Console.ReadLine();
int b = Convert.ToInt32(b1);
Console.Write("Введи число c: ");
string c1 = Console.ReadLine();
int c = Convert.ToInt32(c1);
if (a > b && a > c) Console.WriteLine(a);
if (b > a && b > c) Console.WriteLine(b);
if (c > a && c > b) Console.WriteLine(c);
