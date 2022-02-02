// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая цифра введённого числа - "+ (number/10 - 10*(number/100)));