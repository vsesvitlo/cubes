static int[] KataCubes(int[] initialDat, char direction)
{
    int width = initialDat.Length;
    int height = Max(initialDat);
    int[,] matrix = new int[width, height];
    int[,] resultMatrix = new int[width, height];
    int[] countHorizontal = new int[height];
    int[] countResult = new int [width];
    for (int i = 0; i < width; i++)
    {
        for (int j = height - initialDat[i]; j < height; j++)
        {
            
            matrix[i, j] = 1;
            countHorizontal[j] += 1;
            if (direction == 'L')
            {
                for (int k = 0; k < countHorizontal[j] ; k++)
                {
                    resultMatrix[k, j] = 1;
                }
            }
            if (direction == 'R')
            {
                for (int k = width - countHorizontal[j]; k < width ; k++)
                {
                    resultMatrix[k, j] = 1;
                }
            }
        }
    }
  
    for (int b = 0; b < width; b++)
    {
        for (int v = 0; v < height; v++)
        {
            if (resultMatrix[b, v] == 1)
            {
                countResult[b] += 1;
            }
        }
            
    }


    //DrawMatrix(matrix);
    WriteArray(countResult);
    //ResultArray(count);
    //DrawMatrix(matrixLeft);
    //DrawMatrix(matrixRight);
    DrawMatrix(resultMatrix);
    return countResult;
}

static int Max(int[] arr)
{
    int max = int.MinValue;
    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[k] > max)
        {
            max = arr[k];
        }
    }
    return max;
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


//int[] right = KataCubes(example, 'R');
//int[] left = KataCubes(example, 'L');
int max1 = Max(new int[] { });
int max2 = Max(Enumerable.Range(15, 1000).ToArray());
//Left(horizontal);

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
/*
public class Kata
{
    public static int[] Flip(char dir, int[] arr)
    {

        static int[] KataCubes(int[] initialDat, char direction)
        {
            static int Max(int[] arr)
            {
                int max = arr[0];
                for (int k = 0; k < arr.Length; k++)
                {
                    if (arr[k] > max)
                    {
                        max = arr[k];
                    }
                }
                return max;
            }

            int width = initialDat.Length;
            int height = Max(initialDat);
            int[,] matrix = new int[width, height];
            int[,] resultMatrix = new int[width, height];
            int[] countHorizontal = new int[height];
            int[] countResult = new int[width];
            for (int i = 0; i < width; i++)
            {
                for (int j = height - initialDat[i]; j < height; j++)
                {

                    matrix[i, j] = 1;
                    countHorizontal[j] += 1;
                    if (direction == 'L')
                    {
                        for (int k = 0; k < countHorizontal[j]; k++)
                        {
                            resultMatrix[k, j] = 1;
                        }
                    }
                    if (direction == 'R')
                    {
                        for (int k = width - countHorizontal[j]; k < width; k++)
                        {
                            resultMatrix[k, j] = 1;
                        }
                    }
                }
            }

            for (int b = 0; b < width; b++)
            {
                for (int v = 0; v < height; v++)
                {
                    if (resultMatrix[b, v] == 1)
                    {
                        countResult[b] += 1;
                    }
                }

            }

            return countResult;
        }
    }
}

*/