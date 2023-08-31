/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12]-> 19
[-4, -6, 89, 6]-> 0
*/
Random arrLength = new Random();
int[] arrayNumbers = new int[arrLength.Next(5, 8)];

void Initialization(int[] array)
{
    Random number = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = number.Next(10);
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + String.Join(", ", array) + "]");
}

Initialization(arrayNumbers);
PrintArray(arrayNumbers);

void PrintSumElementsArrayInOddIndexes(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        if (i % 2 != 0)
            sum += array[i];
    }

    Console.WriteLine(sum);
}

PrintSumElementsArrayInOddIndexes(arrayNumbers);
