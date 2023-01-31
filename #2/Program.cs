/*  Задача 50: Напишите программу, которая на вход принимает
  позиции элемента в двумерном массиве, и возвращает значение
   этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */
Console.Clear();
Console.Write("From which row (1-5) you need value?  ");
int row = int.Parse(Console.ReadLine());

Console.Write("From which column(1-5) you need value?  ");
int column = int.Parse(Console.ReadLine());

double[,] array = GetArray(5, 5, -10, 10);
Console.WriteLine();
Console.WriteLine("Your random array is: ");
PrintArray(array);
Console.WriteLine();
DesiredValue(array);
void DesiredValue(double[,] inArray)
{
    if (row > inArray.GetLength(0) || column > inArray.GetLength(1))
    {
        Console.WriteLine($"Out of array's size. Try again!");
    }
    else
    {
        Console.Write($"Your desired value is {array[row - 1, column - 1]:f2}");
    }
}


void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f2}\t");
        }
        Console.WriteLine();
    }
}
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()* (minValue - maxValue) + minValue;
            if (result[i, j] > maxValue) result[i, j] = maxValue;
        }
    }
    return result;
} 