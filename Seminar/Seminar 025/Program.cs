﻿// Найти сумму чисел от 1 до А
Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());

int S = (A * (A + 1)) / 2;
Console.WriteLine($"Сумма чисел от 1 до {A} равна {S}");