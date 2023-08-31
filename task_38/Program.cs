/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
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

void DifferentMaxMinNumbers(double[] array)
{
    double result = 0;
    double min = array[0];
    double max = array[0];
   for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    result = max - min;

    Console.WriteLine($"{max} - {min} = {Math.Round((result), 2)}");
}

DifferentMaxMinNumbers(arrayNumbers);


