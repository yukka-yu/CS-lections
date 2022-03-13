// 69. Найти сумму элементов от M до N с помощью рекурсии, N и M заданы
int Sum(int M, int N)
{
              if(N < M) return 0;
              return N + Sum(M, N - 1); 
}

Console.WriteLine(Sum(3, 5));