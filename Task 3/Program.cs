// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите число строк 1-й матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов 2-й матрицы: ");
int p = int.Parse(Console.ReadLine()!);

int[,] firstMartrix = new int[m, n];
createRandomArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
printArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
createRandomArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
printArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

multiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
printArray(resultMatrix);

void multiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void createRandomArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(9);
    }
  }
}

void printArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}