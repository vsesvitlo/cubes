
static int[] Flip(/*char dir,*/ int[] arr)
{
    int[] countsAfterFlip = new int[arr.Length];
    //Create a matrix with boxes
    int biggestCollumn = arr.Max();
   
    bool[,] matrix = new bool[ arr.Length, biggestCollumn];
    int[] horizontalCount = new int[arr.Length];
    
    int countCollumns = 0;
    int countRows = 0;
    int count = 0;
    int biggestRow = arr.Max();
    int[,] matrixCount = new int[biggestCollumn, horizontalCount.Length];
    //TODO: fill matrix

    for (int i = 0; i <= arr.Length - 1; i++)
    {
        //countRows = arr[i];
        /*  for (int j = biggestCollumn - arr[i]; j <= biggestCollumn - 1; j++)
          {
              matrix[i, j] = true;
              Console.Write(matrix[i, j]);   
          }
          Console.WriteLine();*/
        //Console.WriteLine(countRows);
        countCollumns += 1;
        //Console.WriteLine(countCollumns);
        for (int k = biggestRow - arr[i]; k <= biggestRow - 1; k++)
        {

            for (int m = 0; m <= k; m++)
            {
                matrixCount[m, i] = 1;
            }
                countRows = k;
            for (int x = countRows; x >=0 ; x--)
            {

            }
                //matrixCount[k, i] = 1;
                Console.Write(matrixCount[k, i]);
            Console.WriteLine(countRows);
        }
        Console.WriteLine();
        /*int[] internalCount = new int[biggestRow - arr[i]];
        for (int m = 0; m <= biggestRow; m++)
        {
            horizontalCount[i] = m;
            for (int n = 0; n <= m - 1; n++)
            {
                internalCount[n] = 1;
            }
            Console.WriteLine(internalCount);
            //countRows += 1;
            //Console.WriteLine(countRows);
        }*/
    }

    //TODO: perform flip L/R


    //TODO: count boxes in matrix after flip

    return countsAfterFlip;

}

int[] counts = Flip(/*'R',*/ new[] { 5, 3, 1, 2 });

Console.WriteLine(counts);

