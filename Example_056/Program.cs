// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

void SortRows(int [,] arr)
{
    int tmp = 0;
    int m = arr.GetLength(0);
    int n = arr.GetLength(1);
    int max = 0;
    int max_j = 0;

    for (int i=0;i<m;i++)
    {
        for (int index1 = 0; index1 < n-1; index1++)
        {
            max = arr[i,index1];
            max_j = index1;

            for (int index2 = index1+1; index2 < n; index2++)
            {
                if (arr[i,index2]>max)
                {
                    max = arr[i, index2];
                    max_j = index2;
                }
            }
            
            tmp=arr[i, index1];
            arr[i, index1] = arr[i, max_j];
            arr[i, max_j] = tmp;
        }
    }
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
        Console.Write(arr[i]+"\t");
    }
}

void PrintArrayLine(int[] arr)
{
    for (int i=0;i<arr.Length;i++)
    {
        Console.WriteLine($"[{i}] {arr[i]}");
    }
}

int[] SumOfElementsInRow(int [,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);

    int[] arraySumRow = new int[m];

    int rowSum;

    for (int i=0;i<m;i++)
    {
        rowSum = 0;
        for (int j=0;j<n;j++)
        {
            rowSum += matrix[i,j];
        }
        arraySumRow[i] = rowSum;
    }

    return arraySumRow;
}

int getRowIndexWithMinSum(int [] arr)
{
    int result = 0;

    int min=arr[0];
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            result = i;
        }
    }

    return result;
}

void PrintOneLineFromMatrix(int [,] matrix, int rowIndexWithMinSum)
{
    for (int j=0;j<matrix.GetLength(1); j++)
    {
        Console.Write(matrix[rowIndexWithMinSum, j]+ "\t");
    }
    Console.WriteLine();
}

Random random = new Random();
int m = random.Next(3,6);
int n;
/* make NOT square matrix */
do
{
    n = random.Next(3,6);
} while (n == m);

int[,] array = new int[m,n];
FillMatrix(array);
Console.WriteLine($"Двумерный НЕКВАДРАТНЫЙ массив [{m},{n}]:");
PrintMatrix(array);

int[] arraySumOfElementsInRow = new int[m];
arraySumOfElementsInRow = SumOfElementsInRow(array);
Console.WriteLine($"Суммы элементов каждой строки: ");
PrintArrayLine(arraySumOfElementsInRow);

int rowIndexWithMinSum = 0;
rowIndexWithMinSum = getRowIndexWithMinSum(arraySumOfElementsInRow);
Console.WriteLine($"Индекс строки с минимальной суммой элементов = " + rowIndexWithMinSum);

Console.WriteLine($"Строка с минимальной суммой элементов : ");
PrintOneLineFromMatrix(array, rowIndexWithMinSum);


