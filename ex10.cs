class ex10

{
    public void resposta()
    {
        int aux = 0;
        Console.WriteLine("A - Todos os Elementos Estejam Ordenados");
        int[] num = { 78, 55, 45, 98, 13, 40, 1, 100, 90, 12, 22, 45, 79, 35, 300, 1000, 3012};
        int n = num.Length;
        oddEvenSort(num, n);
        Console.WriteLine("C - N²");
        
      
    }    

    public static void oddEvenSort(int []arr, int n)
    {
        // Initially array is unsorted
        bool isSorted = false;
 
        while (!isSorted)
        {
            isSorted = true;
            int temp =0;
 
            // Perform Bubble sort on
            // odd indexed element
            for (int i = 1; i <= n - 2; i = i + 2)
            {
                if (arr[i] > arr[i+1])
                {
                    temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = temp;
                    isSorted = false;
                }
            }
 
            // Perform Bubble sort on
            // even indexed element
            for (int i = 0; i <= n - 2; i = i + 2)
            {
                if (arr[i] > arr[i+1])
                {
                    temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = temp;
                    isSorted = false;
                }
            }
        }
        return;
    }
}