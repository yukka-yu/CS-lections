// 65. Спирально заполнить двумерный массив:
// 1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7 

void PrintArray(int[,] matrix) 
{ 
              for (int i = 0; i < matrix.GetLength(0); i++) 
              { 
                            for (int j = 0; j < matrix.GetLength(1); j++)
              
                            {
                                          Console.Write(matrix[i, j] + " "); 
                            }
                            Console.WriteLine(); 
              }
}

int N = 7;
int iCenter = 0; 
int jCenter = 0;
int[,] A = new int[N, N];

if (N % 2 == 0)                                //Определяем позицию самого большого числа N^2
{
              iCenter = N/2; 
              jCenter =  N/2 - 1;
}
else
{
              iCenter = N/2; 
              jCenter =  N/2;
}

A[iCenter, jCenter] = N * N;

int jRightBorder = jCenter + 1;
int jLeftBorder = jCenter - 1;
int iUpBorder = iCenter - 1;
int iDownBorder = iCenter + 1;
//Console.WriteLine(jLeftBorder);

int iStep = 0;
int jStep = 1;
int i = iCenter;
int j = jCenter;

for (int k = N * N - 1; k > 0; k --)
{
              i = i + iStep;
              j = j + jStep;

              //Console.WriteLine(i + " " + j);

              A[i,j] = k;

              if (i == iUpBorder)
              {
                            iStep = 0; 
                            jStep = -1;
                            iUpBorder -= 1;
                            //Console.WriteLine("Up Border");
              }

              else if (i == iDownBorder)
              {
                            iStep = 0; 
                            jStep = 1;
                            iDownBorder += 1;
                            //Console.WriteLine("Down Border");
              }

              else if (j == jRightBorder)
              {
                            iStep = -1; 
                            jStep = 0;
                            jRightBorder += 1;
                            //Console.WriteLine("Right Border");
              }

              else if (j == jLeftBorder)
              {
                            iStep = 1; 
                            jStep = 0;
                            jLeftBorder -= 1;
                            //Console.WriteLine("Left Border");
              }
}

PrintArray(A);