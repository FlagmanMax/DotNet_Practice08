// Задача 61: Задайте две матрицы. Напишите
// программу, которая будет находить произведение
// двух матриц.

void FillMatrix(int[,] arr, int min=-20, int max=21)
{
    Random random = new Random();

    for (int i=0;i<arr.GetLength(0);i++)
    {
        for (int j=0;j<arr.GetLength(1);j++)
        {
            arr[i,j] = random.Next(min,max);
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

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int matrix1Size1 = matrix1.GetLength(0);
    int matrix1Size2 = matrix1.GetLength(1);
    int matrix2Size2 = matrix2.GetLength(1);

    int[,] matrixResult = new int[matrix1Size1,matrix2Size2];

    for(int i = 0; i < matrix1Size1; i++)
    {
        for(int j = 0; j < matrix2Size2; j++)
        {
            matrixResult[i,j] = 0;
            for(int k = 0; k < matrix1Size2; k++)
                matrixResult[i,j] += matrix1[i,k] * matrix2[k,j];
        }
    }
    return matrixResult;
}


Random random = new Random();
int m = random.Next(3,7);
int n = random.Next(3,7);
int k = random.Next(3,7);
int[,] matrix1 = new int[m,n];
int[,] matrix2 = new int[n,k];
int[,] matrixProduct = new int[m,k];

FillMatrix(matrix1, -5,6);
Console.WriteLine($"Матрица A[{m},{n}] :");
PrintMatrix(matrix1);

FillMatrix(matrix2,-5,6);
Console.WriteLine($"Матрица B[{n},{k}] :");
PrintMatrix(matrix2);

Console.WriteLine($"Результат умножения матриц = С[{m},{k}] :");
matrixProduct = ProductMatrix(matrix1,matrix2);
PrintMatrix(matrixProduct);






