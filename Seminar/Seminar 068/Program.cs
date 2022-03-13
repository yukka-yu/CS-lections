// 68. Показать натуральные числа от M до N, N и M заданы
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

string Print(int k)
{
    if(k<m) return string.Empty;
    //string s = k.ToString();
    //s = Print(k-1)+s;
    return Print(k-1)+ " "+k.ToString();
}
Console.WriteLine(Print(n));