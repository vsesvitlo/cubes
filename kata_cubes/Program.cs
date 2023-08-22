/*static int[] KataCubes(int[] initialDat, char direction)
{
    int width = initialDat.Length;
    int height = initialDat.Max();
    int[,] matrix = new int[width, height];
    int[] result = new int[width];
    for (int i = 0; i < width; i++)
    {
        for (int j = height - initialDat[i]; j < height; j++)
        {
            matrix[i, j] = 1;
        }
    }
    DrawMatrix(matrix);
    return result;
};*/

static int[] KataCubes(int[] initialDat, char direction)
{
    int width = initialDat.Length;
    int height = initialDat.Max();
    int[,] matrix = new int[width, height];
    // int[,] matrixLeft = new int[width, height];
    //int[,] matrixRight = new int[width, height];
    //int[] resultForLeft = new int[height];

    int[] count = new int[height];
    for (int i = 0; i < width; i++)
    {
        for (int j = height - initialDat[i]; j < height; j++)
        {
            count[j] += 1;
            matrix[i, j] = 1;
            if (direction == 'L')
            {
                for (int k = 0; k < count[j]; k++)
                {
                    matrix[k, j] = 1;
                }
            }
            if (direction == 'R')
            {
                for (int k = width - count[j]; k < width; k++)
                {
                    matrix[k, j] = 1;
                }
            }
        }
    }
    DrawMatrix(matrix);
    WriteArray(count);
    // DrawMatrix(matrixLeft);
    // DrawMatrix(matrixRight);
    return count;
}

static void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}

static void DrawMatrix(int[,] check)

{
    int width = check.GetLength(0);
    int height = check.GetLength(1);

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write(check[j, i]);
        }
        Console.WriteLine();
    }
}

int[] example = new int[] { 3, 2, 3, 1, 2 };

//KataCubes(example, 'R');
int[] horizontal = KataCubes(example, 'L');
//Left(horizontal);

