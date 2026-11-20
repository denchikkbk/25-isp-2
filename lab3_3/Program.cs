try
{
    Console.Write("Введите x: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите n: ");
    int n = int.Parse(Console.ReadLine());
    double s = 0;
    int i = 1;
    while (i <= n)
    {
        s += Math.Pow(-1, i) * Math.Cos(i * x) / (i * i);
        i++;
    }
    Console.WriteLine($"S = {s:F4}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}