class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размерность массива");

        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Введены неверные данные! Вы должны ввести число");
            return;
        }

        int[,] f = new int[n, n];

        int[] columnMin = new int[n];

        Random rand = new Random();

        for (int i = 0; i < f.GetLength(0); i++)
        {
            for (int j = 0; j < f.GetLength(1); j++)
            {                
                f[i, j] = rand.Next(1, 100);

                Console.Write("{0} ", f[i, j]);

                if (i == 0 || f[i, j] < columnMin[j])
                {
                    columnMin[j] = f[i, j];
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("Наименьшие элементы в столбцах");

        for (int i = 0; i < columnMin.GetLength(0); i++)
        {
            Console.Write("{0} ", columnMin[i]);
        }
    }
}


