
static int[] Flip(char dir, int[] arr)
{
    int[] countsAfterFlip = new int[arr.Length];

    //Create a matrix with boxes
    int biggestCollumn = arr.Max();
    bool[,] matrix = new bool[biggestCollumn, arr.Length];
    //int check = 0;
    //TODO: fill matrix
    for (int i = 0; i <= arr.Length - 1; i++)
    {// arr[i] = 1;
        if (true)
        {
            for (int j = 0; j <= biggestCollumn - 1; j++)
            {
                if (true)
                {
                    countsAfterFlip[j] = 0;
                }
            }
        }

    }

    //TODO: perform flip L/R

    //TODO: count boxes in matrix after flip

    return countsAfterFlip;

}

int[] counts = Flip('R', new[] { 3, 2, 1, 2 });

Console.WriteLine(counts);

