// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] array = new int[,,]
{
    {{10, 11}, {12, 13}},
    {{14, 15}, {16, 17}}
};

for(int i = 0; i < array.GetLength(0); i++) {

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}