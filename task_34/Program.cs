/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234]-> 2
*/

Random arrLength = new Random();
int[] arrThreeDigitNumbers = new int[arrLength.Next(5, 21)];
void Initialization(int[] array)
{
    Random numbersForArr = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = numbersForArr.Next(100, 1000);
}

void PrintArr(int[] array)
{
    Console.WriteLine("[" + String.Join((", "), array) + "]");
}
void CountOfEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

Initialization(arrThreeDigitNumbers);
PrintArr(arrThreeDigitNumbers);
CountOfEvenNumbers(arrThreeDigitNumbers);
