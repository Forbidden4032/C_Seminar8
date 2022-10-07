// Задача 60: ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


void Array(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[x, y, z]} ({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] massive = new int[3, 4, 5];
int value = 10;

if (massive.Length>(99-10))
{
    Console.WriteLine("неповторяющимися двузначными числами невозможно заполнить массив");
}
else
{
    for (int x = 0; x < massive.GetLength(0); x++)
    {
        for (int y = 0; y < massive.GetLength(1); y++)
        {
            for (int z = 0; z < massive.GetLength(2); z++)
            {
                massive[x, y, z] = value;
                value++;
            }
        }
    }
    Array(massive);
}
