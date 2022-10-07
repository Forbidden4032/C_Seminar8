//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

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

int[,] massive = new int[4, 4];

int count = 0;
int i = 0;
int j = 0;

for (j = 0; j < massive.GetLength(1); j++)
{
    massive[i, j] = count + 1;
    count++;
}

j = massive.GetLength(1) - 1;

for (i = 1; i < massive.GetLength(0); i++)
{
    massive[i, j] = count + 1;
    count++;
}

i = massive.GetLength(0) - 1;

for (j = massive.GetLength(1) - 2; j >= 0; j--)
{
    massive[i, j] = count + 1;
    count++;
}

j = 0;

for (i = massive.GetLength(0) - 2; i > 0; i--)
{
    massive[i, j] = count + 1;
    count++;
}

i = 1;

for (j = 1; j < massive.GetLength(1) - 1; j++)
{
    massive[i, j] = count + 1;
    count++;
}

i = 2;

for (j = 2; j > 0; j--)
{
    massive[i, j] = count + 1;
    count++;
}
Print(massive);
