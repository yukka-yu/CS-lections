// 43. Написать программу преобразования десятичного числа в двоичное
Console.WriteLine("Введите положительное число");
int Num = int.Parse(Console.ReadLine());

string S = "";

//Console.WriteLine(Convert.ToString(Num, 2));

while (Num > 0)
{
              S += Convert.ToString(Num%2, 10);
              Num = Num / 2;
}
 for (int i = S.Length - 1; i > -1; i --)
              Console.Write(S[i]);