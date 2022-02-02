// Показать чётные числа от 1 до N
Console.WriteLine("Введите целое число");
int N = int.Parse(Console.ReadLine());

int i = 1;
while (i < N / 2 + 1) 
{
              Console.Write(i * 2 + ", ");
              i ++;
}
