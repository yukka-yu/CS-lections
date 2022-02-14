// 31. Задать массив из 8 элементов и вывести их на экран
double[] Arr = new double[8];
for (int index = 0; index < 8; index ++)
{
              Arr[index] = new Random().Next(1,100);
              Console.Write(Arr[index]+" ");
}