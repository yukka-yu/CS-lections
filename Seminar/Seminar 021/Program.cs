// Программа проверяет пятизначное число (num = a1 b1 c b2 a2) на палиндром
Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());
int a1 = num/10000, a2 = num%10, b1 = num/1000 - 10*a1, b2 = (num%100 - a2)/10;
if (a1 == a2 && b1 == b2) Console.WriteLine($"Число {num} - палиндром");
else Console.WriteLine($"Число {num} - не палиндром");