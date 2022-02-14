// Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());

if (x % (7*23) == 0) Console.WriteLine("число кратно и 7, и 23");
else if (x % 23 == 0) Console.WriteLine("Число кратно 23 и не кратно 7");
else if (x % 7 == 0) Console.WriteLine("Число кратно 7 и не кратно 23");
else Console.WriteLine("Число не кратно ни 7, ни 23");