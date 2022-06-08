//Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

void Print(double[,] arr)
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

double[,] MassNum (int row, int column, double from, double to)
{
    double [,] arr = new double[row, column];
    Random n_arr = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i,j] = Math.Round(n_arr.NextDouble()*(10+12)-10, 2);
        }
    }
    return arr;
    Console.Write(arr);

}

double [,] arr_1 = MassNum (4, 4, -9 , 10);
Print(arr_1);
