// 64. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
// Сразу оговорим, что имеем дело с квадратной матрицей

int[,] C = new int[5, 5];
for(int i = 0; i < C.GetLength(0); i ++)
{
              C[i,0] = 1;
              C[0,i] = 1;
}

for(int i = 1; i < C.GetLength(0); i ++)
{ 
             for(int j = 1; j < C.GetLength(1); j ++)
              {
                            C[i,j] = C[i-1,j] + C[i,j-1]; 
              }
              Console.WriteLine("");
}

for(int i = 0; i < C.GetLength(0); i ++)
{ 
             for(int j = 0; j < C.GetLength(1); j ++)
              {
                            Console.Write(C[i,j] + "  ");
              }
              Console.WriteLine("");
}