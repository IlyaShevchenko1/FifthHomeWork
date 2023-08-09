// Home work 5.

// Task 34. Задайте массив, заполненный случайными положительными трехзначными
// числами. Напишите программу, которая покажет количество четных чисел в массиве.

/*

int[] CreateRandomArray (int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);

    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

int CountOfEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    
    return count;
}

Console.Write("Input a lenght of array: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m);
WriteArray(myArray);

Console.WriteLine($"Quantity of even numbers in array is {CountOfEvenNumbers(myArray)}");

*/

// Task 36. Задайте одномерный массив, заполненный случайными числами. Найдите
// сумму элементов, стоящих на нечетных позициях.

/*


int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

int SumOfOddElements(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i+=2)
        sum = sum + array[i];
    
    return sum;
}

Console.Write("Input a lenght of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value of array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value of array: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
Console.Write("Your array is: ");
WriteArray(myArray);

if (m <= 1) Console.WriteLine("There are no odd elements in the massive");
else Console.WriteLine($"Sum of odd elements of array is: {SumOfOddElements(myArray)}");

*/


// Task 38. Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементом массива.

/*

double[] CreateAnArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i} number of massive: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }

    return array;
}

void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double FindMax(double[] array)
{
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    
    return min;
}

Console.Write("Input a lenght of array: ");
int m = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateAnArray(m);
Console.Write("Your array is: ");
WriteArray(myArray);
Console.WriteLine($"Max number of array is {FindMax(myArray)}");
Console.WriteLine($"Min number of array is {FindMin(myArray)}");
Console.WriteLine($"Difference between Max and Min numbers of array is {FindMax(myArray) - FindMin(myArray)}");

*/