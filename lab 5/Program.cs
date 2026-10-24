try
{
    char[] mas = new char[15];
    Console.WriteLine("Введите 15 символов:");
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = char.Parse(Console.ReadLine());
        Console.Write($"{mas[i]} ");
    }
    Console.WriteLine();

    int count = 0;
    string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";

    for (int i = 0; i < mas.Length; i++)
    {
        if (vowels.Contains(mas[i]))
        {
            count++;
        }
    }

    Console.WriteLine($"Количество гласных: {count}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}