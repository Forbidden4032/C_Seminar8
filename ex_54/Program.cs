// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 400);
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] massive = new int[4, 10];

Array(massive);
Print(massive);
Console.WriteLine();

int min1 = 0;
int tmp = 0;
int min2 = 0;

for (int l = 0; l < massive.GetLength(1); l++)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        min1 = massive[i, 0];
        for (int j = 0; j < massive.GetLength(1) - l; j++)
        {
            if (massive[i, j] <= min1)
            {
                min1 = massive[i, j];
                min2 = j;
            }
        }
        tmp = massive[i, massive.GetLength(1) - 1 - l];
        massive[i, massive.GetLength(1) - 1 - l] = massive[i, min2];
        massive[i, min2] = tmp;
    }
} 
Print(massive);