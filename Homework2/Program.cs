/*
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Ввдите трехзначное Число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 99)
{
    Console.WriteLine((num / 100) % 10);
}
else{
    Console.WriteLine("третьего число нет");
}
*/

/*
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Lesson(int num)
{
    int one = num / 10 % 10;
    return one;
}

int number = new Random().Next(100,1000);
int chislo = Lesson(number);
Console.WriteLine($" {number} is {chislo}");
*/


/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Ведите день недели от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 7 || num < 1) 
{
    Console.Write("Такого дня не существует");
}
else
{
    if (num == 1) Console.Write("Понедельник: " + "Работа");
    if (num == 2) Console.Write("Вторник: " + "Работа");
    if (num == 3) Console.Write("Среда: " + "Работа");
    if (num == 4) Console.Write("Четверг: " + "Работа");
    if (num == 5) Console.Write("Пятница: " + "работа");
    if (num == 6) Console.Write("Суббота: " + "Выходной");
    if (num == 7) Console.Write("Воскресенье: " + "Выходной");
}
*/