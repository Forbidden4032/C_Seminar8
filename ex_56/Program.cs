// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

int[,] massive = new int[6, 8];

Array(massive);
Print(massive);
Console.WriteLine();

int[] Sum = new int[massive.GetLength(0)];

// Расчёт построчных сумм

for (int i = 0; i < massive.GetLength(0); i++)
{
    Sum[i] = 0;
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        Sum[i] += massive[i, j];
    }
}

int min = Sum[0];
int minElements = 0;

for (int l = 0; l < Sum.Length; l++)
{
    if (Sum[l] < min)
    {
        min = Sum[l];
        minElements = l;
    }
}

Console.WriteLine($"Наименьшая сумма элементов в строке №{minElements}");