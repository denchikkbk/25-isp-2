try
{
    Console.Write("Введите A: ");
    int A = int.Parse(Console.ReadLine());
    Console.Write("Введите B: ");
    int B = int.Parse(Console.ReadLine());
    Console.Write("Введите C: ");
    int C = int.Parse(Console.ReadLine());

    bool a = (A % 2 == 0) != (B % 2 == 0);
    bool b = (A % 3 == 0) && (B % 3 == 0) && (C % 3 == 0);

    Console.WriteLine($"а) Только одно из A и B чётное: {a}");
    Console.WriteLine($"б) Каждое из A, B, C кратно трём: {b}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}