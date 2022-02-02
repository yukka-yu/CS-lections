// Показать числа от -N до N
Console.WriteLine("Введите целое число");
int N = int.Parse(Console.ReadLine());
int [] array = new int[2 * N + 1];

int index = 0;
while (index <= 2 * N)
{
              array[index] = -1 * N + index;
              Console.Write(array[index]+", ");
              index ++;
}



