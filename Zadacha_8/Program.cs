﻿/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int a = 1;

while (a <= N) {
    Console.Write($"{a}, ");
    a++;
}
Console.WriteLine();