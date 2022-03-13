// 45. Показать числа Фибоначчи
void PrintArray(int[] massive)
{
              for (int i = 0; i < massive.Length; i ++)
              {
                            Console.Write(massive[i] + " ");
              }
}
Console.WriteLine("Введите номер последнего необходимого числа Фибоначчи");
int N = int.Parse(Console.ReadLine());

int[] fibonacci = new int[N];
fibonacci[0] = 1;
fibonacci[1] = 1;

for (int i = 2; i < N; i ++)
{
              fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
              
}

PrintArray(fibonacci);
