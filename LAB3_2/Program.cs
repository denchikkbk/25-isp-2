//int s = 0;
//int k = 0;
//int n;
//do
//{
//    try
//    {
//        n = int.Parse(Console.ReadLine());
//        s = s + n;
//        k++;
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}
//while (n != 0) ;
//k--;
//Console.WriteLine($"Сумма чисел : {s}, количество: {k}");

//int k = 6;
//Console.WriteLine(++k);
//Console.WriteLine(k);

//double s = 0;
//int k  = 0;
//do
//{
//    try
//    {
//        int n = int.Parse(Console.ReadLine());
//        if (n < 0) break;
//        s += n;
//        k++;

//    }
//    catch(Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}
//while (true);
//Console.WriteLine($"Среднее арифметическое:{s / k:F2}");

int s = 0;
int i = 1;
while(i<=100)
{
    if (i % 5 == 0) continue;
    s += i;
    i++;
    Console.WriteLine($"S={s}");
}