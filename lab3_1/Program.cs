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

//int s = 0;
//int i = 1;
//while (i <= 100)
//{
//    if (i % 5 == 0) continue;
//    s += i;
//    i++;
//    Console.WriteLine($"S={s}");
//}


//Console.Write("Введите число:");
//int n = int.Parse(Console.ReadLine());
//int k3 = 0;
//int klast = 0;
//int kOdd = 0;
//int sumGreater5 = 0;
//long multGreater7 = 0;
//int k05 = 0;
//int last = n % 10;
//while (n !=0)
//{
//    int temp = n % 10;
//    if (temp == 3) k3++;
//    if (temp == last) klast++;
//    if (temp > 5) sumGreater5 += temp;
//    if (temp > 7) multGreater7 *= temp;
//    if(temp == 0 || temp == 5) k05++;
//    n/= 10;
//}
//Console.WriteLine($"Количество 3:{k3}");
//Console.WriteLine($"Последняя цифра встречается:{klast}");
//Console.WriteLine($"Количество четных:{kOdd}");
//Console.WriteLine($"Сумма больше 5:{sumGreater5}");
//Console.WriteLine($"произведение его цифр больших семи:{multGreater7}");
//Console.WriteLine($"встречаются цифры 0 и 5:{k05}");

//for (int i = 1; i <= 9; i++)
//{
//    for(int j= 1; j <=9; j++)
//    {
//        Console.Write($"{i} * {j}= {i * j}");
//    }
//    Console.WriteLine();
//}

int n = 5;
int s = 0;
int stepen = 1;
int i = 0;
while (i <= n)
{
    s += stepen;
    stepen *= 2;
    i++;
}
Console.WriteLine($"Сумма = {s}");

long p = 1;
i = 2;
while (i <= 10)
{
    s = 0;
    for (int j = 1; j <= i; j++)
    {
        s += j;
    }
    p *= s;
    i++;
}
Console.WriteLine($"Произведение = {p}");