class ex09
{
    public void resposta()
    {
        float[] num = { 78, 55, 45, 98, 13, 40, 1, 100, 90, 12, 22, 45, 79, 35, 300, 1000, 3012};
        bucketSort(num, num.Length);
    }

        static void bucketSort(float []arr, int n)
    {
        if (n <= 0)
        return;
    
        // 1) Create n empty buckets
        List<float>[] buckets = new List<float>[n];
    
        for (int i = 0; i < n; i++) {
        buckets[i] = new List<float>();
        }
    
        // 2) Put array elements in different buckets
        for (int i = 0; i < n; i++) {
        float idx = arr[i] * n;
        buckets[(int)idx].Add(arr[i]);
        }
    
        // 3) Sort individual buckets
        for (int i = 0; i < n; i++) {
        buckets[i].Sort();
        }
    
        // 4) Concatenate all buckets into arr[]
        int index = 0;
        for (int i = 0; i < n; i++) {
        for (int j = 0; j < buckets[i].Count; j++) {
            arr[index++] = buckets[i][j];
        }
        }
    }
}