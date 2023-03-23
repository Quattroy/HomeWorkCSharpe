// Задача 62: Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

Console.Clear();

int n = 4;
int[,] matrix = new int[n, n];

int num = 1;
int i = 0;
int j = 0;

while (num <= matrix.GetLength(0) * matrix.GetLength(1))
{
  matrix[i, j] = num;
  num++;
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(matrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($" {array[i,j]}\t ");
    }
    Console.WriteLine();
  }
}