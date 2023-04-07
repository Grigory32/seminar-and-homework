// seminar 2 
// task 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int CutNumber(int num) // CutNumber это метод к которому в дальнейшем обращается программа
// {
//     int hundreds = num / 100;
//     int units = num % 10; 

//     int result = hundreds * 10 + units;
//     return result; 
// }
//  после того как мы описали метод его нужно вызвать

// int randNumber = new Random().Next(100, 1000);

// int newNumber = CutNumber(randNumber);

// Console.WriteLine($"New version of {randNumber} is {newNumber} ");


// task 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int MaxDiget(int num)
// {
//     int firstnum = num / 10;
//     int secondnum = num % 10;
//     int max = firstnum;

//     if (secondnum > max)
//     {
//         max = secondnum;
//     } 
   
//     else
//     {
//         max = firstnum;
//     } 
   

//     return max;
// }

// int randNumber = new Random().Next(10, 100);

// int newNumber = MaxDiget(randNumber);

// Console.WriteLine(randNumber);
// Console.WriteLine(newNumber);


// task 2. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

// bool ModNumber(int num, int a, int b)
// {
//   if (num % a == 0 && num % b == 0)
//   {
//     return true;
//   }
  
//   else
//   {
//     return false;
//   }
 
// }
// Console.WriteLine("input 3 numbers: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// bool answer = ModNumber(num, a , b);
// Console.WriteLine(answer);       как написал изначально

//  Console.WriteLine(ModNumber(num, a , b)); ещё один способ вывести ответ не вводя доп переменные и не усложняя программу


// task 3. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


// bool Quad(int a, int b)
// {
//     if(a == b * b || b == a * a)
//     return true;

//     else
//     return false; 
// }

// Console.Write("введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Quad(a, b));

