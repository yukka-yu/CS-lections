// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число N");
string A = int.Parse(Console.ReadLine()).ToString();

int i = 0;
int Sum = 0;
while (i < A.Length)
{
              Sum = Sum + int.Parse(A[i].ToString());
              i ++;
}
Console.WriteLine("Сумма цифр вашего числа - " + Sum);