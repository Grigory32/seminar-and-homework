//  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Coord(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double newx = x2 - x1; 
    double newy = y2 - y1;
    double newz = z2 - z1;

    double newcoord = Math.Sqrt(newx * newx + newy * newy + newz * newz);

    return newcoord; 
}

Console.Write("input a coord x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input a coord y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input a coord z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("input a coord x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("input a coord y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("input a coord z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(Coord(x1, y1, z1, x2, y2, z2),2));
*/


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int n)
{
    for(int i = 1; i <= n; i++)
        Console.WriteLine($"for {i} - {i * i * i}");
}   

Console.Write("input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

Cube(n);
*/

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// bool Palindrome(int num)
// {
//     int tempNum = num;
//     int reversNum = 0;
//     int lastDigit = 0;
//     while (tempNum > 0)
//     {
//      lastDigit = tempNum % 10;
//      reversNum = reversNum * 10 + lastDigit;
//      tempNum /= 10;
//     }

//     if (reversNum == num) return true;
//     return false;
// }

// Console.Write("Input you number please: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Is your number {num} palindrome? Resuit: {Palindrome(num)}");
