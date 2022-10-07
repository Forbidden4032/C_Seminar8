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

int[,] matrica1 = new int[3, 2];
int[,] matrica2 = new int[2, 3];
int[,] matrica3 = new int[Math.Max(matrica1.GetLength(0), matrica2.GetLength(0)),
                         Math.Max(matrica1.GetLength(1), matrica2.GetLength(1))];
Array(matrica1);
Array(matrica2);
Print(matrica1);
Console.WriteLine();
Print(matrica2);
Console.WriteLine();

if (matrica1.GetLength(1) != matrica2.GetLength(0))
{
    Console.WriteLine("Матрицы не перемножаются!");
}
else
{
    for (int i = 0; i < matrica3.GetLength(0); i++)
    {
        for (int j = 0; j < matrica3.GetLength(1); j++)
        {
            for (int k = 0; k < matrica1.GetLength(1); k++)
            {
                matrica3[i,j] += matrica1[i, k] * matrica2[k, j];
            }
        }
    }
    Print(matrica3);
}