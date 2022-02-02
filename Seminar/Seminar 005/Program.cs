// Написать программу вычисления значения функции y = a^3 + sin(a) + 4*a^2
Console.WriteLine("Введите значение переменной а");
double a = double.Parse(Console.ReadLine());

double F(double arg1)
{
              double result = Math.Pow(arg1, 3) + Math.Sin(arg1) + 4 * Math.Pow(arg1, 2);
              
              return result;
}

Console.WriteLine("Значение у при введённом вами а примерно равно " + F(a));