// Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void SearchNum (int [,] arr)
{
    Console.Write("введите номер строки ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("введите номер столбца ");
    int b = int.Parse(Console.ReadLine());
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    if (a>row_size | b>column_size) 
    {
        Console.WriteLine($"Такого элемента нет");
        
    }
    else for (int i = 0; i <row_size; i++)
    {
        for (int j = 0; j <column_size; j++)
        {
            
            if (arr[i,j]== arr[a-1, b-1]) 
             {
              Console.WriteLine($"{a}{b} -> {arr[i,j]}");
             }
            
        }
    }

    
}

int [,] new_arr = MassNum(5, 5, 10, 100);
Print(new_arr);
SearchNum (new_arr);