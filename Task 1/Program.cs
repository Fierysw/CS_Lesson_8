// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите размерность m массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите размерность n массива: ");
int n = int.Parse(Console.ReadLine()!);
int[,] randomArray = new int[m, n];

void createRandomArray(int m, int n)
{
  int i, j;
  Random rand = new Random();
  for (i = 0; i < m; i++)
  {
    for (j = 0; j < n; j++)
    {
      randomArray[i, j] = rand.Next(1, 9);
    }
  }
}

void printArray(int[,] array)
{
  int i, j;
  for (i = 0; i < array.GetLength(0); i++)
  {
    Console.WriteLine();
    for (j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
  }
  Console.WriteLine();
}

createRandomArray(m, n);
Console.WriteLine("\nНачальный массив: ");
printArray(randomArray);

void sortArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

sortArray(randomArray);
Console.WriteLine("\nОтсортированный массив: ");
printArray(randomArray);