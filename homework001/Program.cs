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

int[,] array = GetArray(rows, columns, 1, 25);
PrintArray(array);


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) ; j++)
    {
        int minNumber = j;
        for (int k = j + 1; k < array.GetLength(1) ; k++)
        {
            
            if ( array[ i,minNumber ] > array[i,k])
            {
                minNumber = k;
            }
        }
        int temp = array[i,minNumber];
        array[ i,minNumber ] = array[i,j];
        array[i,j] = temp;
    }
    
}
System.Console.WriteLine();
System.Console.WriteLine("Упорядоченный массив");
System.Console.WriteLine();
PrintArray(array);
