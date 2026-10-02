//try
//{
//    Console.Write("Введите a");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("Введите b:");
//    double b = double.Parse(Console.ReadLine());
//    Console.Write("Введите c:");
//    double c = double.Parse(Console.ReadLine());
//    if ((a < b) && (b < c)) Console.WriteLine($"{a}<{b}<{c}");
//    else Console.WriteLine("не выполняется")
//            }
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//try
//{
//    Console.Write("Введите m:");
//    int m = int.Parse(Console.ReadLine());
//    int a = m / 100
//        int b = m / 10 % 10;
//    int c = m % 10;
//    if ((a == 4 || b == 4 || c == 4) || (a == 7 || b == 7 || c == 7))
//        Console.Writeline("Да");
//    else Console.WriteLine("Нет");
//    if((a==3 || b==3 || c==3)) || (a == 6 ||  b == 6 || c == 6)||
//            (a == 9 ||  b == 9 || c == 9) Console.WriteLine("Да");
//    else Console.WriteLine("Нет");
//}
//catch (Expection e)
//{
//    Console.WriteLine(e.Message);
//}
try
{
    Console.Write("Введите a:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите b:");
int b = int.Parse(Console.ReadLine());
if (a * a + b * b > (a + b) * (a + b)) Console.WriteLine("Сумма квадратов больше");
else if ((a + b) * (a + b) > a * a + b * b) Console.WriteLine("Квадрат суммы больше");
else Console.WriteLine("Они равны");
}
catch (Exception e)
{ 
    Console.WriteLine(e.Message);
}

