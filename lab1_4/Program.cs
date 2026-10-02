//bool A = true;
//bool b = false;
//bool c = false;
//Console.WriteLine(!A || A && (b||c));

try
{
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите y:");
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine(x * x + y * y <= 4);
    Console.WriteLine((x ))
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

