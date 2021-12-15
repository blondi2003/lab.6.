class Program
{
    static void Main()
    {
        int[] numbers = new int[] { 1, 3, 5, 7, 9, 15, 17, 20, 25, 19, 30, 44, 70 };

        int sum = 0;

        foreach (int number in numbers)
        {            
            if (number % 5 == 0)
            {
                sum += number;
            }
        }

        Console.WriteLine("Сумма равна: {0}", sum);
    }
}

