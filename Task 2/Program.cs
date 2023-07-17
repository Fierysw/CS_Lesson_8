// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

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
    Console.WriteLine();
    for (j = 0; j < n; j++)
    {
      randomArray[i, j] = rand.Next(1, 9);
      Console.Write($"{randomArray[i, j]} ");
    }
  }
  Console.WriteLine();
}

int sumRow(int[,] array, int i)
{
  int sum = array[i, 0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i, j];
  }
  return sum;
}

int minSum = 1;
int sum = sumRow(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
  if (sum > sumRow(randomArray, i))
  {
    sum = sumRow(randomArray, i);
    minSum = i + 1;
  }
}

Console.WriteLine("\nСозданный массив: ");
createRandomArray(m, n);
Console.WriteLine($"\nНаименьшая сумма элементов находится в {minSum} строке");