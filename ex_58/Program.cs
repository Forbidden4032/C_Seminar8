
// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

void Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

int[,] mat1 = new int[3, 2];
int[,] mat2 = new int[2, 3];
int[,] mat3 = new int[Math.Max(mat1.GetLength(0), mat2.GetLength(0)),
                         Math.Max(mat1.GetLength(1), mat2.GetLength(1))];
Array(mat1);
Array(mat2);
Print(mat1);
Console.WriteLine();
Print(mat2);
Console.WriteLine();

if (mat1.GetLength(1) != mat2.GetLength(0))
{
    Console.WriteLine("Матрицы нельзя перемножить");
}
else
{
    for (int i = 0; i < mat3.GetLength(0); i++)
    {
        for (int j = 0; j < mat3.GetLength(1); j++)
        {
            for (int k = 0; k < mat1.GetLength(1); k++)
            {
                mat3[i,j] += mat1[i, k] * mat2[k, j];
            }
        }
    }
    Print(mat3);
}