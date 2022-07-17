/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n, int min, int max)
{
int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) // Строчки
    {
        for (int j = 0; j < n; j++) // Столбцы
        {
            result[i, j] = new Random().Next(min, max + 1); // [min,max]
        }
    }
    return result;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t"); // tab - "\t"
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int result = int.MaxValue;
int lineNumber = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int lineSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        lineSum += array[i,j]; 
    }
    if ( lineSum < result)
    {
        result = lineSum;
        lineNumber = i;
    }
}
System.Console.WriteLine($"минимальная сумма элементов : {result} находится в {lineNumber} строке ");