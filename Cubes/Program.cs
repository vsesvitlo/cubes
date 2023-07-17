
static int[] Flip(/*char dir,*/ int[] arr)
{
    int[] countsAfterFlip = new int[arr.Length];
    //Create a matrix with boxes
    int biggestCollumn = arr.Max();
   bool[,] matrix = new bool[ arr.Length, biggestCollumn];
    // int[,] matrix = new int[biggestCollumn, arr.Length];
    //TODO: fill matrix
    for (int i = 0; i <= arr.Length - 1 ; i++)
    {
            for (int j = biggestCollumn - arr[i]; j <= biggestCollumn - 1; j++)
        {
            matrix[i, j] = true;
            Console.WriteLine(matrix[i, j] + "\t");
        }
            Console.WriteLine();
    }

    //TODO: perform flip L/R

    //TODO: count boxes in matrix after flip

    return countsAfterFlip;

}

int[] counts = Flip(/*'R',*/ new[] { 3, 2, 1, 2 });

Console.WriteLine(counts);

