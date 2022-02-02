// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Последняя цифра введённого числа " + number % 10);
