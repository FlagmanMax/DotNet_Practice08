
// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

void ExchangeRows(int [,] arr, int r1,int r2)
{
    int temp;
    for (int j=0;j<arr.GetLength(1);j++)
    {
        temp = arr[r1,j];
        arr[r1,j] = arr[r2,j];
        arr[r2,j] = temp;
    }
}

void FillArray(int[,] arr)
{
    Random random = new Random();

    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            arr[i,j] = random.Next(-100,101);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            Console.Write(arr[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

Random random = new Random();
int m = random.Next(2,6);
int n = random.Next(2,6);

Console.WriteLine($"Двумерный массив [{m},{n}]:");
int[,] array = new int[m,n];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Измененный массив:");
ExchangeRows(array, 0, m-1);
PrintArray(array);