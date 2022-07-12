/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int num1, num2;

  Console.Write("Введите первое число: ");
  num1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите второе число: ");
  num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine(num1 + "max");
    Console.WriteLine(num2 + "min");
}

else if (num1 < num2)
{
    Console.WriteLine(num1 + " min");
    Console.WriteLine(num2 + " max");
} 

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a, b, c;

  Console.Write("Введите первое число: ");
  a = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите второе число: ");
  b = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите третье число: ");
  c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);

*/

/*
//Задача 6:Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

bool delenie(int num)
{
    if(num % 2 == 0) return true;
    else return false;
}

Console.Write("input number ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = delenie(number);

Console.WriteLine(result);
*/

/*
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("input number ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;
while (current <= num)
{
    if(current % 2 == 0)
    Console.Write(current + " ");
    current++;
}
*/


