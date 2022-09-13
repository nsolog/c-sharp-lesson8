// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] matrix1 = new int[2,2];
int[,] matrix2 = new int[2,2];

void FillMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] arr)
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

int[,] MatrixMultiplication(int[,] matr1, int[,] matr2)
{
    int[,] matrix3 = new int[matr1.GetLength(0), matr2.GetLength(1)];

    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                matrix3[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    
    return matrix3;
}

FillMatrix(matrix1);
FillMatrix(matrix2);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
PrintMatrix(MatrixMultiplication(matrix1, matrix2));
