static int[] KataCubes(int[] initialDat, char direction)
{
    int width = initialDat.Length;
    int height = initialDat.Max();
    int[,] matrix = new int [width, height];
    int[] result = new int[width];
    for(int i = 0; i < width; i++)
    {
        for(int j = height - initialDat[i]; j < height; j++)
        {
            matrix[i, j] = 1;
        }
    }
    DrawMatrix(matrix);
    return result;
};


static void DrawMatrix(int[,] check)

{
    int width = check.GetLength(0);
    int height = check.GetLength(1);

    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            Console.Write(check[i, j]);
        }
        Console.WriteLine();
    }
}

int[] example = new int[] { 3, 2, 3, 1, 2 };
KataCubes(example, 'R');
