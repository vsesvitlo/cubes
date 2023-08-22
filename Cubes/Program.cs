static int[,] CreateDiagonalMatrix(int n)
{

    int[,] matrix = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        matrix[i, i] = 1;
    }
    return matrix;
}
static int[,] CreateReverseTriangleMatrix(int n)
{

    int[,] matrix = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = n - i - 1; j >= 0; j--)
        {
            matrix[i, j] = 1;
        }
    }
    return matrix;
}
static int[,] CreateDecreasingTriangleMatrix(int n)
{
    int[,] matrix = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = n - i - 1; j < n; j++)
        {
            matrix[i, j] = 1;
        }
    }
    return matrix;
}
static int[,] CreateDecreasingTriangleMirrorMatrix(int n)
{
    int[,] matrix = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = n - 1; j >= i; j--)
        {
            matrix[i, j] = 1;
        }
    }
    return matrix;
}
static int[,] CreateCentreBlockMatrix(int n)
{

    int[,] matrix = new int[n, n];

    for (int i = 1; i < n - 1; i++)
    {
        for (int j = n - 2; j >= 1; j--)
        {
            matrix[j, i] = 1;
        }
    }
    return matrix;
}
static int[,] CreateAngleMatrix(int n)
{

    int[,] matrix = new int[n, n];

    for (int i = 1; i < n; i++)
    {
        for (int j = n - 1; j >= 1; j--)
        {
            matrix[j, i] = 1;
        }
    }
    return matrix;
}
static int[,] CreateTriangleMatrix(int n)
{

    int[,] matrix = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = n - i - 1; j < n; j++)
        {
            matrix[i, j] = 1;
        }
    }
    return matrix;
}
static int[,] CreateIncreasingTriangleMatrix(int n)
{

    int[,] matrix = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = n - i - 1; j < n; j++)
        {
            matrix[j, i] = 1;
        }
    }
    return matrix;
}
static int[,] CreateDiagonalReverseMatrix(int n)
{

    int[,] matrix = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        int j = n - i - 1;
        matrix[i, j] = 1;
    }
    return matrix;
}
static int[,] CreateXMatrix(int n)
{
    int[,] matrix = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        int j = n - i - 1;
        matrix[i, j] = 1;
        matrix[i, i] = 1;
    }
    return matrix;
}

static void DrawMatrix(int[,] check)

{
    int length = check.GetLength(0);

    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            Console.Write(check[i, j]);
        }
        Console.WriteLine();
    }
}


int[,] triangleDecreasing = CreateDecreasingTriangleMatrix(5);

DrawMatrix(triangleDecreasing);

int[,] triangleMirror = CreateDecreasingTriangleMirrorMatrix(5);
DrawMatrix(triangleMirror);
int[,] centreBlock = CreateCentreBlockMatrix(5);

DrawMatrix(centreBlock);

int[,] angle = CreateAngleMatrix(5);

DrawMatrix(angle);

int[,] triangleIncreasing = CreateIncreasingTriangleMatrix(5);

DrawMatrix(triangleIncreasing);

int[,] diagonalReverseTwice = CreateXMatrix(5);

DrawMatrix(diagonalReverseTwice);

int[,] diagonalReverse = CreateDiagonalReverseMatrix(5);

DrawMatrix(diagonalReverse);

int[,] triangleReverse = CreateTriangleMatrix(5);

DrawMatrix(triangleReverse);

int[,] triangle = CreateReverseTriangleMatrix(5);

DrawMatrix(triangle);

int[,] diagonal = CreateDiagonalMatrix(5);

DrawMatrix(diagonal);
Thread.Sleep(500);
Console.ReadKey();