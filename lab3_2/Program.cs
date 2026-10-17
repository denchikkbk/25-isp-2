try
{
    Console.Write("Введите m: ");
    int m = int.Parse(Console.ReadLine());
    int i = 1;
    while (i <= 10)
    {
        int sotka = i * 100;
        if (i % 2 != 0)
        {
            Console.WriteLine($"{sotka} / {m} = {sotka / m}");
        }
        i++;
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
