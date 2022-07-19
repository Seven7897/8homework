Console.Write("Введите количество массивов: ");
int page = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,,] GetArray(int m, int n,int x, int min, int max)
{
int[,,] result = new int[m, n , x];
    for (int i = 0; i < m; i++)
    {          
        for (int j = 0; j < n; j++) 
        {
            for (int z = 0; z < x; z++) 
            {
                result[ i, j , z] = new Random().Next(min, max + 1); 

            }
        }
    }
    return result;
}

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

int[,,] array = GetArray(page ,rows , columns,  0, 10);
bool  Result = false;
{
    while (Result != true)
    {
        for (int s = 0; s < array.GetLength(0); s++)
        {
            for (int w = 0; w < array.GetLength(1); w++)
            {
                for (int t = 0; t < array.GetLength(2); t++)
                {
                    if (array[s,w,t] == array[s,w,t+1])
                    {
                        array[s,w,t] = new Random().Next(0, 11);
                        s=0;
                        w=0;
                        t=0;
                    }                                   
                }
            }
        }
        return ;
    }
}
PrintArray(array);
