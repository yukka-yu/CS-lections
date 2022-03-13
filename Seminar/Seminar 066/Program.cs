// 66. Показать натуральные числа от 1 до N, N задано

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

string Print(int k)
{
    if(k<1) return string.Empty;
    return Print(k-1)+ " "+k.ToString();
}
Console.WriteLine(Print(n));