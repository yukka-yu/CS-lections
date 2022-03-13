// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
//Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита
string alph = "аисв";
int n = 3;

string[] Words(string a, int num)
{

              if(num == 0) return new string[]{""}; 

              string[] w = Words(a, num - 1);  // слова, которые у нас были на предыдущем шаге
              string[] result = new string[w.Length * a.Length];
              int k = 0;
              for (int i = 0; i < w.Length; i ++)
              {
                            for (int j = 0; j < a.Length; j ++)
                            {
                                          result[k] = w[i] + a[j];
                                          k ++;
                            }
              }
              return result;
}

string[] res = Words(alph, n);

for (int i = 0; i < res.Length; i ++)
{
              Console.WriteLine(res[i] + " ");
}