﻿/*
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

CreateArray(array);
WriteArray(array);

void CreateArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double alignNumber = Math.Round(array[i, j], 1);
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}


//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,10));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
}
 
 Console.Write("Введите координаты строк: ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите координаты столбцов: ");
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>m && b>n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine($"ваше число -> {c}");
 }
 
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк:");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:");
int M = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[N, M];
Random rand = new Random();
int[] summ = new int[M];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        array[i, j] = rand.Next(0,10); 
    }
}
Console.WriteLine();
Console.WriteLine("двумерный массив из целых чисел");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {

        Console.Write(array[i, j] + " ");
        summ[i] += array[i, j];      
    }
    Console.WriteLine();
}
Console.WriteLine();
foreach (double elem in summ)
{
  Console.WriteLine(elem / M); 
}
*/