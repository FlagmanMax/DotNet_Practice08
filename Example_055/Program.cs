// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

void TransposeArray(int [,] arr)
{
    //int[,] arrayT = new int[arr.GetLength(1),arr.GetLength(0)];
    int temp = 0;
    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=i;j<arr.GetLength(1);j++)
        {
            temp = arr[i,j];
            arr[i,j] = arr[j,i];
            arr[j,i] = temp;
        }
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

if (m != n)
{
    Console.WriteLine($"Невозможно транспонировать матрицу");
}
else
{
    Console.WriteLine($"Транспонированная матрица:");
    TransposeArray(array);
    PrintArray(array);
}
