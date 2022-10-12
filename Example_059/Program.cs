// Задача 59: Задайтедвумерный массив из целых чисел. Напишите
// программу, которая удалит строку и столбец, на пересечении которых
// расположен наименьший элемент массива.

int[,] DeleteMinElement(int [,] arr)
{
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);

    int[,] resultArray = new int[m-1,n-1];
    
    int min = arr[0,0];
    int min_i = 0;
    int min_j = 0;

    for (int i=0;i<m;i++)
    {
        for (int j=0;j<n;j++)
        {
           if (arr[i,j]<min)
           {
                min = arr[i,j];
                min_i = i;
                min_j = j;
           }
        }
    }

    Console.WriteLine($"Минимальный элемент A[{min_i},{min_j}] == {min}");

    int bias_i = 0;
    int bias_j = 0;
    for (int i=0;i<m-1;i++)
    {
        if (i == min_i)
        {
            bias_i = 1;
        }
        bias_j = 0;
        for (int j=0;j<n-1;j++)
        {
            if (j == min_j)
            {
                bias_j = 1;
            }
           resultArray[i,j] = arr[i+bias_i,j+bias_j];
        }
        
    }

    return resultArray;
}

void FillMatrix(int[,] arr)
{
    Random random = new Random();

    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            arr[i,j] = random.Next(0,101);
        }
    }
}

void PrintMatrix(int[,] arr)
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

void PrintArray(int[] arr)
{
    for (int i=0;i<arr.Length;i++)
    {
        Console.Write($"{i} встечается {arr[i]}");
        if ((arr[i]==2)||(arr[i]==3)||(arr[i]==4))
        {
            Console.Write(" раза \n");
        }
        else
        {
            Console.Write(" раз \n");
        }
    }
}

Random random = new Random();
int m = random.Next(3,6);
int n = random.Next(3,6);

Console.WriteLine($"Двумерный массив [{m},{n}]:");
int[,] array = new int[m,n];
FillMatrix(array);
PrintMatrix(array);

int[,] resultArray = new int[m-1,n-1];
resultArray = DeleteMinElement(array);
Console.WriteLine($"Матрица без минимального элемента [{m-1},{n-1}]:");
PrintMatrix(resultArray);


