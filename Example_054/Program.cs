// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива

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


Random random = new Random();
int m = random.Next(3,6);
int n = random.Next(3,6);

int[,] array = new int[m,n];
FillMatrix(array);
Console.WriteLine($"Двумерный массив [{m},{n}]:");
PrintMatrix(array);

SortRows(array);
Console.WriteLine($"Матрица с отсортированными строками:");
PrintMatrix(array);



