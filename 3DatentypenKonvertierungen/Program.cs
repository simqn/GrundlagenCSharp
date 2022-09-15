//DatentypenKonvertierung



//Aufgabe 1


Console.WriteLine($"size of short: {short.MaxValue}");
Console.WriteLine($"size of short: {short.MinValue}");
Console.WriteLine("Short hat 16 Byte");

Console.WriteLine("");
Console.WriteLine($"size of int: {int.MaxValue}");
Console.WriteLine($"size of int: {int.MinValue}");
Console.WriteLine("int hat 32 Byte");

Console.WriteLine("");
Console.WriteLine($"size of long: {long.MaxValue}");
Console.WriteLine($"size of long: {long.MinValue}");
Console.WriteLine("Ein Long hat 64 Byte");

Console.WriteLine("");
Console.WriteLine($"size of float: {float.MaxValue}");
Console.WriteLine($"size of float: {float.MinValue}");
Console.WriteLine("Ein Float hat 32 Byte");

Console.WriteLine("");
Console.WriteLine($"size of double: {double.MaxValue}");
Console.WriteLine($"size of double: {double.MinValue}");
Console.WriteLine("Ein Double hat 64 Byte");


Console.WriteLine("");
Console.WriteLine($"size of decimal: {decimal.MaxValue}");
Console.WriteLine($"size of decimal: {decimal.MinValue}");
Console.WriteLine("Ein Decimal hat 128 Byte");


//Aufgabe 2

string vornameee = "Simon";
short alterrr = 17;
bool frage = true;
Console.WriteLine($"Die Person ist {alterrr} Jahre alt und heißt {vornameee}");
Console.WriteLine($"Ist diese Programmiersprache seine erste? {frage}");