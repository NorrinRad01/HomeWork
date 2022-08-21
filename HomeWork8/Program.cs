/*
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array); 

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0,10);
    }
  }
}
void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

Console.WriteLine("Отсортированный массив: ");
OrderArrayLines(array);
WriteArray(array);
void OrderArrayLines(int[,] array)
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
*/
/*
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int m = InputNumbers("Введите количество строк: ");
int n = InputNumbers("Введите количество столбцов: ");
int range = InputNumbers("Введите диапазон чисел: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int rows = 0;
int minSumm = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array, i);
    if (minSumm > tempSumLine)
    {
        minSumm = tempSumLine;
        rows = i;
    }
}
int SumLineElements(int[,] array, int i)
{
    int minSumm = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        minSumm += array[i, j];
    }
    return minSumm;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine($"Наименьшая сумма: {minSumm}");
Console.WriteLine($"Номер строки: {rows}");


//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Write("Введите количество строк 1 массива: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 массива: ");
int columnsB = Convert.ToInt32(Console.ReadLine());

int[,] A = GetArray(rowsA, columnsB);
int[,] B = GetArray(rowsA, columnsB);
Console.WriteLine("Первая матрица");
PrintArray(A);
Console.WriteLine("Вторая матрица");
PrintArray(B);
Console.WriteLine("Произведение 2х матриц");
PrintArray(GetMultiplicationMatrix(A, B));

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0,10);
        }

    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
      int sum = 0;
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                sum += arrayA[i, k] * arrayB[j, k];
            }
            arrayC[i,j] = sum;
        }
    }
    return arrayC;
}
*/
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Console.Clear();
Console.WriteLine($"Введите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
int range = InputNumbers("Введите диапазон чисел: от 1 до ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"({i}, {j}, {k}){array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(range);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(range);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
*/

//Заполните спирально массив 4 на 4.
/*
int n = 4;
int[,] SpiralMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= SpiralMatrix.GetLength(0) * SpiralMatrix.GetLength(1))
{
    SpiralMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < SpiralMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= SpiralMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > SpiralMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(SpiralMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/