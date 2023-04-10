// task 1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void ShowRange(int quadrant)
// {
//     if(quadrant == 1) Console.WriteLine("x > 0 and y > 0 ");
//     else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
//     else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
//     else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
//     else Console.WriteLine("Quadrant doesnt exist!");
// }


// Console.Write("input a number of quadrant: ");
// int quadrant = Convert.ToInt32(Console.ReadLine());

// ShowRange(quadrant);

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
void Div (int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("1");
    else if(x < 0 && y > 0) Console.WriteLine("2");
    else if(x < 0 && y < 0) Console.WriteLine("3");
    else if(x > 0 && y < 0) Console.WriteLine("4");
    else Console.WriteLine("-1");
}

Console.Write("input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("input y: ");
int y = Convert.ToInt32(Console.ReadLine());

Div(x, y);

*/
// через возвратную функцию 
/*
  int Div (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    
    return -1;
}

Console.Write("input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("input y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Div(x, y));
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*

double Coord(double x1, double y1, double x2, double y2)
{
    double newx = x2 - x1;
    double newy = y2 - y1;

    double newcoord = Math.Sqrt(newx * newx + newy * newy);

    return newcoord;
    
}

Console.Write("input x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(Math.Round(Coord(x1, y1, x2, y2), 2));

*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*

double Duad(double n)
{
   double newn = Math.Pow(n, 2);
   return newn;
}

Console.Write("input n: ");
double n = Convert.ToInt32(Console.ReadLine());



Console.WriteLine(Duad(n));

*/

/*

void Div(int num)
{
    for(int i = 1; i <= num; i++)
        Console.WriteLine($"{i} - {i * i}");
}

Console.Write("input num: ");
int num = Convert.ToInt32(Console.ReadLine());

Div(num);

*/
