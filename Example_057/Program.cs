// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int[] FreqAnalyse(int [,] arr)
{
    int[] resultArray = new int[11];
    
    int lenM = arr.GetLength(0);
    int lenN = arr.GetLength(1);
    for (int i=0;i<lenM;i++)
    {
        for (int j=0;j<lenN;j++)
        {
            resultArray[arr[i,j]]++;
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
            arr[i,j] = random.Next(0,11);
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
int m = random.Next(2,6);
int n = random.Next(2,6);

Console.WriteLine($"Двумерный массив [{m},{n}]:");
int[,] array = new int[m,n];
FillMatrix(array);
PrintMatrix(array);
Console.WriteLine($"Частотный словарь:");

int[] resultArray = new int[11];
resultArray = FreqAnalyse(array);
PrintArray(resultArray);