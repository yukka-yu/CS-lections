// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

if (a == b * b) Console.WriteLine("Первое число - квадрат второго");
else if (b == a * a) Console.WriteLine("Второе число - квадрат первого");
else Console.WriteLine("Ни одно из чисел не является квадратом другого");

