// Найти сумму цифр числа
int Sum(int num)
{
    if(num==0) return num;
    return num%10 + Sum(num/10);
}

Console.WriteLine("Введите число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine(Sum(m));
