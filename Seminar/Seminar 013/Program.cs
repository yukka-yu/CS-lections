// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите первое число");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int a = int.Parse(Console.ReadLine());

if (x % a == 0) Console.WriteLine("Первое число кратно второму");
else Console.WriteLine("Первое число делится на второе с остатком " + (x % a));