// 72. Написать программу возведения числа А в целую стень B
int Power(int a, int b)
{
    if(b<1) return 1;
    return a*Power(a, b-1);
}

Console.WriteLine("Введите число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Power(m,n));