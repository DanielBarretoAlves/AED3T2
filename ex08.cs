class ex08
{
    public void resposta()
    {
        int[] num = { 78, 55, 45, 98, 13, 40, 1, 100, 90, 12, 22, 45, 79, 35, 300, 1000, 3012};
        countsort(num);
        printArray(num);

        

    }


    static void countSort(int[] arr)
  {
    int max = arr.Max();
    int min = arr.Min();
    int range = max - min + 1;
    int []count = new int[range];
    int []output = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++) {
      count[arr[i] - min]++;
    }
    for (int i = 1; i < count.Length; i++) {
      count[i] += count[i - 1];
    }
    for (int i = arr.Length - 1; i >= 0; i--) {
      output[count[arr[i] - min] - 1] = arr[i];
      count[arr[i] - min]--;
    }
    for (int i = 0; i < arr.Length; i++) {
      arr[i] = output[i];
    }
  }
  static void printArray(int[] arr)
  {
    for (int i = 0; i < arr.Length; i++)
    {
      Console.Write(arr[i] + " ");
    }
    Console.WriteLine("");
  }

    
}