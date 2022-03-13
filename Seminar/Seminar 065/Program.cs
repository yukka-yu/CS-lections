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


int N = 4;
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

int iStep = 0; int jStep = 1;
int i = iCenter; int j = jCenter + 1;
int StepsInSerie = 1;
int SerieNo = 1;
int StepNo = 0;

A[iCenter, jCenter] = N * N;

for (int k = N * N - 1; k > 0; k --)
{
              
              A[i,j] = k;
              StepNo += 1;
              if (StepNo == StepsInSerie)
              {
                            if (jStep ==1)
                                          {iStep = -1; jStep = 0;}
                            else if (iStep == -1)
                                          {iStep = 0; jStep = -1;}
                            else if (jStep == -1)
                                          {iStep = 1; jStep = 0;}
                            else if (iStep == 1)
                                          {iStep = 0; jStep = 1;}

                            if (SerieNo == 2)
                                          {StepsInSerie += 1; SerieNo = 1;}
                            else 
                                          {SerieNo = 2;} 
                            StepNo = 0;
              }
              i += iStep; j+= jStep;

}

PrintArray(A);

