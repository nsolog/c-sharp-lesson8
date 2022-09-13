// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

int [,] array = new int[6,4];

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

string GetSmallestAmountRow(int[,] arr)
{
    int[] sumsArray = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumsArray[i] += arr[i, j];
        }
    }

    int index_min = 0;
    int min = sumsArray[0];
    for (int i = 1; i < sumsArray.Length; i++)
    {
        if (min > sumsArray[i])
        {
            min = sumsArray[i];
            index_min = i;
        }
    }
    
    return $"Номер строки с наименьшей суммой элементов: {index_min + 1}";
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write(GetSmallestAmountRow(array));