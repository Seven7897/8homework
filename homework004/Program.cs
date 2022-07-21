Console.Write("Введите количество массивов: ");
int page = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());


void PrintArray(int[,,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            for (int z = 0; z < inputArray.GetLength(2); z++)
            {
                Console.Write($"{inputArray[i, j , z]} ({i},{j},{z}) \t"); 
            }
            Console.WriteLine();
        }
        System.Console.WriteLine();
    }    
}


System.Console.WriteLine();
int[,,] GetArray(int m, int n,int x)
{
int number = 10;
int[,,] result = new int[m, n , x];
    for (int i = 0; i < m; i++)
    {          
        for (int j = 0; j < n; j++) 
        {
            for (int z = 0; z < x; z++) 
            {
                result[ i, j , z] = number;                
                number += 1;
            }                
        }
    }
    return result;
}
    

int[,,] array = GetArray(page ,rows , columns);
PrintArray(array);