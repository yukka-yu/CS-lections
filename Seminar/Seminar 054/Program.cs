// 54. В матрице чисел найти сумму элементов главной диагонали
int[,] array = new int [4,5];
Console.WriteLine("Исходный массив");
for(int i=0; i<array.GetLength(0); i++)
{ 
              for(int j=0; j<array.GetLength(1); j++) 
              { 
                            array[i,j] = new Random().Next(0,100);
                            Console.Write(array[i,j] + " ");
              }
              Console.WriteLine();
}
int Sum = 0;
for(int i=0; i<array.GetLength(0); i++)
{
              for(int j=0; j<array.GetLength(1); j++)
              {
                            if(i == j) Sum += array[i,j];
              }
}

Console.WriteLine("Сумма чисел главной диагонали = " + Sum); 
