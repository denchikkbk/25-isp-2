//try
//{
//    Console.Write("Введите первую переменную");
//        double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите вторую переменную");
//        double y = double.Parse(Console.ReadLine());
//    double avg = (Math.Pow(x, 3) + Math.Pow(y, 3)) / 2
//        Console.WriteLine($"Среднее арифмитическое):{avg:"F2"}");
//}
//    catch(Exception ex)
//    {
//    Console.WriteLine(Exception.Message);
//}*/

try
{
    Console.Write("Введите Массу (m):");
    double m = double.Parse(Console.ReadLine());
    double k = 100;
    double T = 2 * Math.PI * Math.Sqrt(m / k);
    Console.WriteLine($"Период колебаний");
    { T: string v = "F2"; }
  

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}