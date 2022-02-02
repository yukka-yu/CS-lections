// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число от 10 до 99");
int x = int.Parse(Console.ReadLine());
int a = x / 10;
int b = x % 10;
if (a > b) Console.WriteLine("Наибольшая цифра числа - " + a);
else if (a < b) Console.WriteLine("Наибольшая цифра числа - " + b);
else Console.WriteLine("Обе цифры числа равны " + a);