class ex01
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
        int[] testQuick = quickSort(numList);
        int[] testHeap = numList;
        int[] testMerge = numList;
        int[] testInsertion = numList;
        int[] testbubble = numList;
        testbubble = bubbleSort(testbubble);
        testMerge = MergeSort(testMerge, 0 , testMerge.Length - 1);
        testHeap = heapSort(testHeap, testHeap.Length);
        testInsertion = InsertionSort(testInsertion);
        Console.WriteLine("Merge Sort:");
        for (int index = 0; index < testQuick.Length; index++)
        {
            Console.Write(testMerge[index] + ", ");
            
        }
        Console.WriteLine("");
        Console.WriteLine("Heap Sort:");
        

        for (int index = 0; index < testQuick.Length; index++)
        {
            Console.Write(testHeap[index] + ", ");
            
        }
        Console.WriteLine("");
        Console.WriteLine("Quick Sort:");
        for (int index = 0; index < testQuick.Length; index++)
        {
            Console.Write(testQuick[index] + ", ");
            
        }
        Console.WriteLine("");
        Console.WriteLine("Bubble Sort:");
        for (int index = 0; index < testQuick.Length; index++)
        {
            Console.Write(testInsertion[index] + ", ");
            
        }
        for (int index = 0; index < testQuick.Length; index++)
        {
            Console.Write(testbubble[index] + ", ");
            
        }

    }





    static void bubbleSort(int []arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    // swap temp and arr[i]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }
 
    /* Prints the array */
    static void printArray(int []arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    //---------------------------------QUICK SORT-------------------------------------------------------------

    public static int[] quickSort(int[] vetor)
    {
        int inicio = 0;
        int fim = vetor.Length - 1;

        quickSort(vetor, inicio, fim);

        return vetor;
    }

    private static void quickSort(int[] vetor, int inicio, int fim)
    {
        if (inicio < fim)
        {
            int p = vetor[inicio];
            int i = inicio + 1;
            int f = fim;

            while (i <= f)
            {
                if (vetor[i] <= p)
                {
                    i++;
                }
                else if (p < vetor[f])
                {
                    f--;
                }
                else
                {
                    int troca = vetor[i];
                    vetor[i] = vetor[f];
                    vetor[f] = troca;
                    i++;
                    f--;
                }
            }

            vetor[inicio] = vetor[f];
            vetor[f] = p;

            quickSort(vetor, inicio, f - 1);
            quickSort(vetor, f + 1, fim);


        }
    }


    class InsertionSort {
 
    // Function to sort array
    // using insertion sort
    void sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i) {
            int key = arr[i];
            int j = i - 1;
 
            // Move elements of arr[0..i-1],
            // that are greater than key,
            // to one position ahead of
            // their current position
            while (j >= 0 && arr[j] > key) {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }
 
    // A utility function to print
    // array of size n
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
 
        Console.Write("\n");
    }
    //-----------------------------------------------------------------------------------------------------
    //-------------------------------------------HEAP SORT----------------------------------------------------------

    static int[] heapSort(int[] arr, int n)
    {
        for (int i = n / 2 - 1; i >= 0; i--)
            heapify(arr, n, i);
        for (int i = n - 1; i >= 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
            heapify(arr, i, 0);
        }
        return arr;
    }
    static void heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        if (left < n && arr[left] > arr[largest])
            largest = left;
        if (right < n && arr[right] > arr[largest])
            largest = right;
        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;
            heapify(arr, n, largest);
        }
    }

    //-----------------------------------------------------------------------------------------------------
    //---------------------------------------MERGE SORT--------------------------------------------------------------
    private void Merge(int[] input, int left, int middle, int right)
    {
        int[] leftArray = new int[middle - left + 1];
        int[] rightArray = new int[right - middle];

        Array.Copy(input, left, leftArray, 0, middle - left + 1);
        Array.Copy(input, middle + 1, rightArray, 0, right - middle);

        int i = 0;
        int j = 0;
        for (int k = left; k < right + 1; k++)
        {
            if (i == leftArray.Length)
            {
                input[k] = rightArray[j];
                j++;
            }
            else if (j == rightArray.Length)
            {
                input[k] = leftArray[i];
                i++;
            }
            else if (leftArray[i] <= rightArray[j])
            {
                input[k] = leftArray[i];
                i++;
            }
            else
            {
                input[k] = rightArray[j];
                j++;
            }
        }
       
    }

    private int[] MergeSort(int[] input, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(input, left, middle);
            MergeSort(input, middle + 1, right);

            Merge(input, left, middle, right);
        }
        return input;
    }
    //-----------------------------------------------------------------------------------------------------
}
