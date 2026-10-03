//try
//    int n = int.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1:
//        Console.WriteLine("понедельник");
//        break;
//    case 2:
//        Console.WriteLine("вторник");
//        break;
//    case 3:
//        Console.WriteLine("среда");
//        break;
//    case 4:
//        Console.WriteLine("четверг");
//        break;
//    case 5:
//        Console.WriteLine("пятница");
//        break;
//    case 6:
//        Console.WriteLine("суббота");
//        break;
//    case 7:
//        Console.WriteLine("воскресенье");
//        break;
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//try
//{
//    Console.Write("Введите номер месяца:");
//    int n = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 12: case 1: case 2:
//            Console.WriteLine("Зима");
//            break;
//        case 3: case 4: case 5:
//            Console.WriteLine("Весна");
//            break;
//        case 6: case 7: case 8:
//            Console.WriteLine("Лето");
//        case 9: case 10: case 11:
//            Console.WriteLine("Осень");
//           break ;
//        default:
//            Console.WriteLine("Нет такого месяца");
//            break;
//    }
//}
//try 
//{
//    Console.Write("Запишите номер карты");
//    Console.Write("Запишите масть");
//    int n = int.Parse(Console.ReadLine());
//    int m = int.Parse(Console.ReadLine());
//}
//switch (n)
//{ 

//        case 6:
//        Console.WriteLine("шестерка");
//        break;
//    case 7:
//        Console.WriteLine("Семерка");
//        break;
//    case 8:
//        Console.WriteLine("восьмерка");
//        break;
//    case 9:
//        Console.WriteLine("девятка");
//        break;
//    case 10:
//        Console.WriteLine("десятка");
//        break;
//    case 11:
//        Console.WriteLine("валет");
//        break;
//    case 12:
//        Console.WriteLine("дама");
//        break;
//        case 13:
//        Console.WriteLine("король");
//        break;
//    case 14:
//        Console.WriteLine("туз");
//        break;
//    default:
//        Console.WriteLine("Нет такой карты");
//        break;
//    }
//switch (m)
//{
//    case 1:
//        Console.WriteLine("пик");
//        break
//        case 2:
//        Console.WriteLine("треф");
//        break
//        case 3:
//        Console.WriteLine("бубен");
//        break
//        case 4:
//        Console.WriteLine("червей");
//        break;
//    default:
//        Console.WriteLine("Нет такой масти");
//        break;
//} 
//}
//catch (Exception e)
//    {
//    Console.WriteLine(e.Message);
//}
try
{
    Console.Write("Введите номер варианта:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double u = 0, y = 0;
    switch (n)
    {
        case 1:
            {
                u = Math.Sin(x);
                break;
            }
        case 2:
            {
                u = Math.Cos(x);
                break;
            }
        case 3:
            {
                u = Math.Tan(x);
                break;
            }
        default: break;
    }
    if (u + x > Math.Pow(10, -3))
    {
        y = Math.Log10(u + x) - Math.Exp(x) / (3.5 * x);
    }
    else if (u + x >= -0.5)
    {
        y = Math.Pow(Math.Cos(u), 2) - Math.Sin(u / 3);
    }
    else
    {
        y = Math.Pow(2 * u + 1, 2) / (7 * Math.PI + x);
    }
    Console.WriteLine($"y = {y:F2}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}



