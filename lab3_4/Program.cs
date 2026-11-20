try
{
    Console.Write("Введите площадь квадрата S1: ");
    double S1 = double.Parse(Console.ReadLine());
    double a = Math.Sqrt(S1);
    double r = a / 2;
    double b = r * Math.Sqrt(2);
    double S2 = b * b;
    double k = S1 / S2;
    Console.WriteLine($"Площадь вписанного квадрата: {S2:F4}");
    Console.WriteLine($"Площадь меньше в {k:F0} раз(а)");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}