// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
double[] Arr = new double[8];
for (int index = 0; index < 8; index ++)
{
              Arr[index] = new Random().Next(0, 2);
              Console.Write(Arr[index]+" ");
}
