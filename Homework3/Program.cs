// 1:Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
       void palindrom()
        {
        Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine()); 
        int num1 = number / 10000 % 10;
        int num2 = number / 1000 % 10;
        int rev1 = number / 10 % 10;
        int rev2 = number % 10;
        int nul = number / 10000;
        
            if (nul < 1 || nul > 9){
            Console.WriteLine(number + " -> " + "Ввели не пятизначное число");
            }
            else if  (num1 == rev2 && num2 == rev1){
            Console.WriteLine(number + " -> Палиндром");
            }
            else{
            Console.WriteLine(number + " -> Извините, но это не палиндром");
            }
        }
 
            palindrom();
*/


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
Double Lenth(double xa, double ya, double xb, double yb, double za, double zb)
{
    double lenth = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
    return lenth;   
}
    Console.Write("Введите знаение координат х точки А: ");
    int xa = Convert.ToInt32(Console.ReadLine()); 
    Console.Write("Введите знаение координат y точки А: ");
    int ya = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите знаение координат z точки А: ");
    int za = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите знаение координат х точки B: ");
    int xb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите знаение координат y точки B: ");
    int yb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите знаение координат z точки B: ");
    int zb = Convert.ToInt32(Console.ReadLine());
           
double lenth = Lenth(xa, ya, xb, yb, za, zb);
Console.Write($"рассстояние между точками А и Б ровно: {lenth}");
*/


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
void Numbers(int num)
{
    int current = 1;
while (current <= num)
    {
        Console.Write(current*current*current + " ");
        current++;
    }
}
Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Numbers(number);
*/
