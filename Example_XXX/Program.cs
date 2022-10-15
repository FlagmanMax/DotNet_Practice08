// Проверить можно ли пройти по элементам "1" матрицы A[5,5] от ячейки [0,0] до ячейки [4,4]

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

bool FindPath(int[,] map, int i, int j, int i_max, int j_max)
{
    bool result = false;
    if (
        (i < 0) ||
        (i > i_max) ||
        (j < 0) ||
        (j > j_max) ||
        (map[i,j] == 0) ||
        (map[i,j] == 2))
    {
        result = false;
        return result;
    }

    map[i,j] = 2;

    if ((i == i_max) && (j == j_max))
    {
        result = true;
        //return result;
    }


    result = result || FindPath(map, i+1, j, i_max, j_max);
    result = result || FindPath(map, i-1, j, i_max, j_max);
    result = result || FindPath(map, i, j+1, i_max, j_max);
    result = result || FindPath(map, i, j-1, i_max, j_max);

    //result = result || FindPath(map, i+1, j+1, i_max, j_max);
    //result = result || FindPath(map, i-1, j-1, i_max, j_max);

    return result;
}

Random random = new Random();
//int m = random.Next(3,7);
//int n = random.Next(3,7);
int m = 7;
int n = 7;
int i_max = m-1;
int j_max = n-1;

int[,] matrix = new int[m,n];


bool result = false;
while(!result)
{
    FillMatrix(matrix, 0,2);
    matrix[0,0] = 1;
    matrix[i_max,j_max] = 1;
    result = FindPath(matrix, 0, 0, i_max, j_max);
}

Console.WriteLine($"Матрица [{m},{n}]:");
PrintMatrix(matrix);

if (result)
{
    Console.WriteLine("Выход есть");
}
else
{
    Console.WriteLine("Выхода нет");
}

PrintMatrix(matrix);
