try
{
    Random random = new Random();
    double[] Z = new double[16];

    for (int i = 0; i < Z.Length; i++)
    {
        Z[i] = random.NextDouble() * 100;
        Console.Write($"{Z[i]:F2} ");
    }
    Console.WriteLine();

    double sEven = 0; 
    double sMult3 = 0;

    for (int i = 0; i < Z.Length; i++)
    {
        if (i % 2 == 0)
        {
            sEven += Z[i];
        }

        if (i != 0 && i % 3 == 0)
        {
            sMult3 += Z[i];
        }
    }

    double raznost = sEven - sMult3;
    Console.WriteLine($"Разность: {raznost:F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}