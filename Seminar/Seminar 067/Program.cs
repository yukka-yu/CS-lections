// 67. Показать натуральные числа от N до 1, N задано
string Method(int N)
{
             if (N < 1) return (String.Empty);
              return N+" "+ Method(N-1);
}
Console.WriteLine (Method(5));