/*Задание №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Введи число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int count = 1;
if (number > 1) {
while (count <= number) {
    if (count % 2 == 0) Console.Write(count);
    if (count % 2 != 0 && count != 1 && count < number) Console.Write(", ");
    count++;
}
} else {
    Console.WriteLine("Необходимо ввести число больше 0!");
}