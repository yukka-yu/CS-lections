// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число");
int x = int.Parse(Console.ReadLine());
int x1 = x / 100; 
int x2 = x / 10 - 10 * (x / 100);
int x3 = x % 10;
Console.WriteLine("Удалив второй знак, получим число " + x1 + x3);