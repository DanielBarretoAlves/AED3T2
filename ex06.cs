class ex06
{
    public void resposta()
    {
        int[] num = { 1, 1, 2, 2, 2, 3, 4, 4, 5, 5, 6, 7, 8, 8, 9, 9 };
        findRepeatedNumbers(num);


    }


    private void findRepeatedNumbers(int[] num)
    {

        int winner = 0;
        int suport = 0;
        int count = 0;

        for (int i = 0; i < num.Length; i++)
        {
            suport = num[i];
            count = 0;
            for (int j = 0; j < num.Length; j++)
            {
                if (suport == num[j])
                {

                    count++;
                }
                


            }
            if (count == 3)
            {
                winner = suport;
                Console.WriteLine("O Num que repete: " + suport);
                break;
            }
        }

    }
}