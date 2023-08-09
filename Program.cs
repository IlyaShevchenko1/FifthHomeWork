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


// Task 38. Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементом массива.
