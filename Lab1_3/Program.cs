//////Console.WriteLine($"{Math.PI:F2}");
////Console.WriteLine($"{Math.E:F1}");
////int a = int.Parse(Console.ReadLine());
////Console.WriteLine($"Вы ввели число {a}");

//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"вот такое число вы ввели {a}");

//Console.WriteLine("1 13 49");
//Console.WriteLine("7  15  100");


//try
//{
//    Console.Write("Введите радиус: ");
//    double R = double.Parse(Console.ReadLine());
//    Double D = 2 * R;
//    Console.WriteLine($"Диаметр окружности:{D:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    double z = (x + ((2 + y) / x * x)) / (y + (1 / Math.Sqrt(x * x * 10)));
//    Console.WriteLine($":{D:F2}");
//try
//{
//    Console.Write("vvedite colvo cm:");
//    int sm = int.Parse(Console.ReadLine());
//    int m = sm / 100;
//    Console.WriteLine($"Polnix metrov {m}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Vvedite colvo kg:");
//    int kg = int.Parse(Console.ReadLine());
//    int cent = kg / 100;
//    Console.WriteLine($"Polnie centneri {cent}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Vvedit colvo kg:");
//    int kg = int.Parse(Console.ReadLine());
//    int tonna = kg / 1000;
//        Console.WriteLine($"Polnie tonni {tonna}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите четырехзначное число:");
//    int n = int.Parse(Console.ReadLine());
//    int a = n % 10;
//    int b = n % 100 / 10;
//    int c = n % 1000 / 100;
//    int d = n / 1000;
//    int s = a + b + c + d;
//    Console.WriteLine(s);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);

//}

try
{
    Console.Write("Введите трехзначное число:");
    int n = int.Parse(Console.ReadLine());
    int a = n / 100;
    int b = n / 10 % 10;
    int c = n % 10;
    int s = c * 100 + b * 10 + a; 
        Console.WriteLine(s);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

   

