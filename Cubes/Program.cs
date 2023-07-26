
static int[] Flip(/*char dir,*/ int[] arr)
{
    int[] countsAfterFlip = new int[arr.Length];
    //Create a matrix with boxes
    //int biggestCollumn = arr.Max();
    //int[,] matrix = new int[arr.Length, biggestCollumn];
    int[,] matrix = new int[arr.Length, arr.Length];
    int countCollumns = 0;
    int countRows = 0;
    //int biggestRow = arr.Max();
   // int[,] matrixCount = new int[biggestCollumn, horizontalCount.Length];
    //TODO: fill matrix
    /*for (int i = 0; i < arr.Length; i++)
    {
        for (int j = arr.Length - arr[i]; j < arr.Length; j++)
        {
            matrix[i, j] = 1;
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }*/
    for (int i = 0; i < arr.Length; i++)
    {
        
        for (int j = arr.Length - arr[i]; j < arr.Length; j++)
        {
            matrix[i, j] = 1;
            Console.Write(matrix[i+1, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
   /* int[] horizontalCount = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            horizontalCount[i] += matrix[i, j];
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
        
    }
    Console.WriteLine();

   int[] toRowCount = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = arr.Length -1; j >= 0; j--)
        {
            toRowCount[i] += matrix[j, i];
            Console.Write(matrix[j, i]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    int[] toRowCountReverse = new int[arr.Length];
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        for (int j = arr.Length - 1; j >= 0; j--)
        {
            toRowCountReverse[i] += matrix[j, i];
            Console.Write(matrix[j, i]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    int[] toRowCountReverseOne = new int[arr.Length];
    for (int i = arr.Length - 1; i >= 0; i--)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            toRowCountReverseOne[i] += matrix[j, i];
            Console.Write(matrix[j, i]);
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    int[] toRowCountReverseOneMore = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = arr.Length - 1; j >= 0; j--)
        {
            toRowCountReverseOneMore[i] += matrix[j, i];
            Console.Write(matrix[j, i]);
        }
        Console.WriteLine();
    }*/
    Console.WriteLine();

    int[] horizontalCount1 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
                horizontalCount1[j] = matrix[i, j];
                Console.Write(matrix[i, j]);

        }
        Console.WriteLine();

    }
    Console.WriteLine();
    //TODO: perform flip L/R
    //TODO: count boxes in matrix after flip
    return countsAfterFlip;
}

//int[] counts = Flip(/*'R',*/ new[] { 4, 3, 2, 1 });
Console.WriteLine();
//int[] counts1 = Flip(/*'R',*/ new[] { 1, 2, 3, 4 });
Console.WriteLine();
//int[] counts2 = Flip(/*'R',*/ new[] { 0, 3, 3, 3 });
Console.WriteLine();
int[] counts3 = Flip(/*'R',*/ new[] { 1, 1, 1, 1 });

//Console.WriteLine(counts);

/*  for (int j = biggestCollumn - arr[i]; j <= biggestCollumn - 1; j++)
      {
          matrix[i, j] = true;
          Console.Write(matrix[i, j]);   
      }
      Console.WriteLine();*/