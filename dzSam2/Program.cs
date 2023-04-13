// Task 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// void APowerB(int a, int b)
// {
//     int result = a;
//     for (int i = 1; i < b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine($"The number {a} in the power {b} is equal {result}");
// }

// System.Console.Write("Input number <A>: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input the power <B> of the number <A>");
// int b = Convert.ToInt32(Console.ReadLine());

// APowerB(a, b);

// Task 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumOfNum(int num)
// {
//     int result = 0;
//     for(int i = 0; num > 0; i++)
//     {
//         result += num % 10;
//         num /= 10;
        
//     }
//     return result;
// }

// System.Console.Write("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(SumOfNum(num));


// Task 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



// int[] GetRandomArray(int lenArray)
// {
//     int[] array = new int[lenArray];
//      for (int i = 0; i < lenArray; i++)
//          array[i] = new Random().Next(1, 100);
//     
//      return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// PrintArray(GetRandomArray(8));
