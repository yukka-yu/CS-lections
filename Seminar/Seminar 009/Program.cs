// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Последняя цифра введённого числа " + number % 10);

// и то же самое через функцию

int ThirdSign(int arg1)
{
              return arg1 % 10;
}

Console.WriteLine("Последняя цифра введённого числа " + ThirdSign(number));