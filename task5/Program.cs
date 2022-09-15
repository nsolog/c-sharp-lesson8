// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] array = new int[4, 4];

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        }

        Console.WriteLine();
    }
}

void FillArray(int[,] arr)
{
    int x = 0, y = 0;
    int fillOffset = 0;


    for (int i = 1; i <= arr.GetLength(0) * arr.GetLength(1); i++)
    {
        if (arr[x, y] == 0)
        {
            arr[x, y] = i;
            if (y < arr.GetLength(0) - 1 - fillOffset && x == fillOffset) y++;
            else if (x < arr.GetLength(1) - 1 - fillOffset && y == arr.GetLength(1) - 1 - fillOffset) x++;
            else if (y > fillOffset) y--;
            else x--;

            if (x == 1 && y == 0)fillOffset++;
        }
        
    }
}

FillArray(array);
PrintArray(array);