//using System.Text.RegularExpressions;

//string s = "daria@mail.ru";
//string pattern = "[0-9]{3}-[0-9]{3}-{0-9]{4}";

//if (Regex.IsMatch(s, pattern, RegexOptions.IgnoreCase))
//    Console.WriteLine("ОК");
//else Console.WriteLine("NO");

string Text = "дом корова осел и грязь";
string NewText = Text.Remove(0, 1);
Console.WriteLine(NewText);