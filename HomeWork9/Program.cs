/*
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine());
if (M>N)
for (int i = N; i <= M; i++)
    Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write($" {i}");
        

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введи M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи N: ");
int n = Convert.ToInt32(Console.ReadLine());
int temp = m;

if (m > n){
    m = n; n = temp;
}

PrintSumm(m, n, temp = 0);
void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
Console.Write("Введи M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman = function(m, n);
Console.Write($"Функция Аккермана = {Akkerman} ");

int function(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return function(m - 1, 1);
  else return function(m - 1, function(m, n - 1));
}
*/
