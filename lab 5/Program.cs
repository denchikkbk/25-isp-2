try
{
    Console.WriteLine("Введите строку из 15 символов:");
    string input = Console.ReadLine();
    char[] mas = input.ToCharArray();

    for (int i = 0; i < mas.Length; i++)
    {
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
