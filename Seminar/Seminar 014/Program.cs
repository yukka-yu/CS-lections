// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());

if (x < 100) Console.WriteLine("У числа " + x + ", увы, нет третьего знака");
else
{
              while (x > 999)
              {
                            x = x / 10;
              }
              Console.WriteLine("Третий знак исходного числа  - это " + x % 10);

}
