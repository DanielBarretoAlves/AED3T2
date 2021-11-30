class ex02
{
    public void resposta()
    {
        int[] numList = new int[16];
        numList[0] = 3;
        numList[1] = 4;
        numList[2] = 9;
        numList[3] = 2;
        numList[4] = 5;
        numList[5] = 8;
        numList[6] = 2;
        numList[7] = 1;
        numList[8] = 7;
        numList[9] = 4;
        numList[10] = 6;
        numList[11] = 2;
        numList[12] = 9;
        numList[13] = 8;
        numList[14] = 5;
        numList[15] = 1;

    }

    private static void MergeSortNumbers(int[] B, int iStart, int iEnd, int[] A)
    {
        if ((iEnd - iStart) < 2) return;

        int iMiddle = (iStart + iEnd) / 2;
        MergeSortNumbers(A, iStart, iMiddle, B); // Do Not decrement iMiddle
        MergeSortNumbers(A, iMiddle, iEnd, B);
        Merge(B, iStart, iMiddle, iEnd, A);
    }

    private static void Merge(int[] A, int iStart, int iMiddle, int iEnd, int[] B)
    {
        int i = iStart;
        int j = iMiddle;

        for (int k = iStart; k < iEnd; k++)
        {
            if (i < iMiddle && (j >= iEnd || A[i] <= A[j]))
            {
                B[k] = A[i++];
            }
            else
            {
                B[k] = A[j++];
            }
        }
    }
}