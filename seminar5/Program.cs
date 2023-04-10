// Seminar 5 

// task Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

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

int GetNegativeSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i]; // += то же самое, что и sum = sum + array[i]; читается как summ увеличить на array[i];
    
    return sum;
}


Console.WriteLine("input a size for array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max); 
ShowArray(newArray);

int result = GetNegativeSum(newArray);
Console.WriteLine("sum of negative elements is " + result);

*/



// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;


int ChangeNegativeElements(int[] array)
{
    int numbers = 0;

    for(int i = 0; i < array.Length; i++)
        array[i] *= -1; 
                
    return array;
}


Console.WriteLine("input a size for array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max); 
ShowArray(newArray);

int result = GetNegativeSum(newArray);
Console.WriteLine("sum of negative elements is " + result);

*/

// Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;


bool FoundNum(int[] array, int num)
{
    int num = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] == num)
            return true;

    return false;        
}


Console.WriteLine("input a size for array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max); 
ShowArray(newArray);

bool result = FoundNum(newArray);
Console.WriteLine("sum of negative elements is " + result);

*/

// Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

int FoundNum(int[] array, int num, int numA, int numB)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >=numA && array[i] <= numB)
        count++;
        
            return count;
            
}


Console.WriteLine("input a size for array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max); 
ShowArray(newArray, numA, numB);

int result = FoundNum(newArray);
Console.WriteLine(result);

*/