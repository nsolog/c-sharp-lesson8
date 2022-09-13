// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = new int[5,5];

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] >= arr[i, k])
                {
                    (arr[i, j], arr[i, k]) = (arr[i, k], arr[i, j]);
                }
            }
        }
    }
}

FillArray(array);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);