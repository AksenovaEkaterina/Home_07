// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNum(int row, int column, int from, int to)
{
    int [,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i,j] = new Random().Next(from, to);
        }
    }
    return arr;
}

void SumCoumnNun (int [,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int sum = 0;
    int j = 0;
    for (j = 0; j < column_size; j++)
    {
        for (int i = 0; i < row_size; i++)
        {
            
            sum = sum + arr[i,j];
        }
        Console.WriteLine($"Sum column_{j+1} = {sum} ");
        sum = 0;
    
    }   
}
int [,] new_arr = MassNum(5, 5, 0, 11);
Print(new_arr);
SumCoumnNun(new_arr);
