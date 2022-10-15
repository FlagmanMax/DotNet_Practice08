// Задача 58: Заполните спирально массив 4 на 4 числами
// от 1 до 16.

// Алгоритм основан на принципе заполнения данными верхней строки матрицы 
// и последующего переворота матрицы на 90 градусов в сторону против часовой стрелки.
// После 4 переворотов у матрицы оказываются проинициализироваными внешние строки/ряды, переходим к следующему внутреннему "кругу". 
// Если внутренний круг состоит из 1 ячейки - заполняем только ее.
//
// Программа применима для квадратной матрицы любого размера

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
    Console.WriteLine();
}

int fillMatrixRow(int[,] matr, int i_min, int i_max, int count)
{
    int j = i_min;
    do
    {
        matr[i_min,j] = count;
        count++;
        j++;
    } while (j<i_max);

    return count;
}

void RotateMatrix90ccw(int[,] matr)
{
    int n = matr.GetLength(0);
    int[,] matrixR = new int[n,n];

    for (int i=0;i<matr.GetLength(0);i++)
    {
        for (int j=0;j<matr.GetLength(0);j++)
        {
            matrixR[i,j] = matr[j,n-i-1];
        }
    }

    for (int i=0;i<matr.GetLength(0);i++)
    {
        for (int j=0;j<matr.GetLength(0);j++)
        {
            matr[i,j] = matrixR[i,j];
        }
    }
}

void FillMatrix(int[,] matr)
{
    int value = 1;
    int n = matr.GetLength(0);
    int maxValue =  n*n;
    int rotateCounter = 0;
    int i_min = 0;
    int i_max = n-1;

    while (value <= maxValue)
    {
        
        if ((rotateCounter % 4 == 0)&&(rotateCounter > 0))
        {
            i_min++;
            i_max--; 
        }

        if (i_min == i_max)
        {
            matr[i_min,i_min] = value;
            value++;
        }
        else
        {
            value = fillMatrixRow(matr, i_min, i_max, value);
            RotateMatrix90ccw(matr);
        }
        
        rotateCounter++;

        PrintMatrix(matr);
    }
}

Random random = new Random();
int n = random.Next(3,7);
int[,] matrix = new int[n,n];

PrintMatrix(matrix);
FillMatrix(matrix);
