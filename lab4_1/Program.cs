string? text = null;
string name = text ?? "Tom";
Console.WriteLine(name);

int? id = 200;
int personId = id ?? 1;
Console.WriteLine(personId);