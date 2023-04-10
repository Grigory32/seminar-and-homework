// seminar 3. 
// task 1. Напишите программу,которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*

int GetSum(int num)
{
    int sum = 0;
    
    for(int current = 1; current <= num; current++)
        sum = sum + current;
    
    return sum;
}

Console.Write("input a numder: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine($"Sum of numbers from 1 to {a} is {result}");

*/

// Массивы 

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;        
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

Console.WriteLine("input a size for array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max); 
ShowArray(newArray);

*/

