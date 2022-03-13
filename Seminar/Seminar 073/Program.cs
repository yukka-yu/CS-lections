// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме
//двух предыдущих. Первые два элемента последовательности задаются пользователем

int N = 7, a = 3, b = 5;

int Metod(int x, int y, int num)
{
              if (num == 1) return x;
              if (num ==2) return y;
              return Metod(x, y, num-1) + Metod(x, y, num - 2);
}

for (int i = 1; i < N + 1; i ++)
{
              Console.WriteLine(Metod(a, b, i));
}
