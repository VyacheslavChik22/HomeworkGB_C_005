/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12]-> 19
[-4, -6, 89, 6]-> 0
*/
Random arrLength = new Random();
double[] arrayNumbers = new double[arrLength.Next(5, 16)];

void Initialization(double[] array)
{
    Random number = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(number.NextDouble(), 2);
}

void PrintArray(double[] array)
{
    Console.WriteLine("[" + String.Join(", ", array) + "]");
}

Initialization(arrayNumbers);
PrintArray(arrayNumbers);

void PrintSumElementsArrayInOddIndexes(double[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 1 || i % 2 != 0)
            sum += array[i];
    }

    Console.WriteLine(Math.Round(sum, 2));
}

PrintSumElementsArrayInOddIndexes(arrayNumbers);
