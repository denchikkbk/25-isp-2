try
{
    Random rnd = new Random();
    Console.Write("Введите количество строк: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите k: ");
    int k = int.Parse(Console.ReadLine());

    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = rnd.Next(1, 10);
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int i = 0; i < n; i++)
    {
        int[] row = new int[m + 1];
        for (int j = 0; j < m; j++)
        {
            row[j] = mas[i, j];
        }
        row[m] = k;

        int p = 0;
        while (row[p] != k)
        {
            p++;
        }

        if (p < m)
        {
            Console.WriteLine($"В строке {i} элемент {k} найден на позиции {p}");
        }
        else
        {
            Console.WriteLine($"В строке {i} элемент {k} не найден");
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}